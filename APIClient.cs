using Bybit.P2P.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bybit.P2P
{
    public class APIClient
    {
        private string API_KEY { get; set; }
        private string API_SECRET { get; set; }
        private bool TESTNET { get; set; } = false;
        private string DOMAIN { get; set; } = "bybit";
        private string TLD { get; set; } = "com";
        private int RECV_WINDOW { get; set; } = 5000;
        private bool RSA { get; set; } = false;

        private string URL { get; set; } = "";

        public HttpClient client { get; set; } = new HttpClient();

        public APIClient(
            string apiKey,
            string apiSecret,
            bool testnet,
            string domain = "bybit",
            string tld = "com",
            int recv_window = 5000,
            bool rsa = false
            )
        {
            API_KEY = apiKey;
            API_SECRET = apiSecret;
            TESTNET = testnet;
            DOMAIN = domain;
            TLD = tld;
            RECV_WINDOW = recv_window;
            RSA = rsa;

            string subdomain = TESTNET ? "api-testnet" : "api";
            URL = $"https://{subdomain}.{DOMAIN}.{TLD}";
        }

        internal static string GenerateQueryString(Dictionary<string, object> map)
        {
            return string.Join("&", map.Select(kvp => $"{kvp.Key}={kvp.Value}"));
        }

        internal static string MapOutAnObject(object? obj)
        {
            // use reflection to find all properties and build a Dictionary<string, object> map
            var map = new Dictionary<string, object>();

            if (obj != null)
            {
                var properties = obj.GetType().GetProperties().ToList();
                foreach (var prop in properties)
                {
                    map.Add(prop.Name, prop.GetValue(obj));
                }
            }

            return GenerateQueryString(map);
        }

        internal string GenerateSign(long ts, string input)
        {
            string rawData = ts + API_KEY + RECV_WINDOW + input;

            return RSA ? ComputeRSA(rawData) : ComputeHMAC(rawData);
        }

        internal string GenerateBinarySign(long ts, byte[] input)
        {
            byte[] data = Encoding.UTF8.GetBytes(ts + API_KEY + RECV_WINDOW)
                                       .Concat(input)
                                       .ToArray();

            return RSA ? ComputeRSA(data) : ComputeHMAC(data);
        }

        internal static long UnixMS() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        internal string ComputeHMAC(string data) => ComputeHMAC(Encoding.UTF8.GetBytes(data));

        internal string ComputeHMAC(byte[] data)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(API_SECRET));
            byte[] signature = hmac.ComputeHash(data);
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        internal string ComputeRSA(string data)
        {
            throw new NotImplementedException();
        }

        internal string ComputeRSA(byte[] data)
        {
            throw new NotImplementedException();
        }

        internal async Task<T> SendRequest<T>(string endpoint, HttpMethod method, object? data)
        {
            var ts = UnixMS();

            HttpResponseMessage? resp = null;
            HttpRequestMessage? httpMsg = null;

            if (method == HttpMethod.Post)
            {
                httpMsg = new HttpRequestMessage(method, $"{URL}{endpoint}");

                var jsonStr = JsonConvert.SerializeObject(data);
                var postSign = GenerateSign(ts, jsonStr);

                httpMsg.Content = new StringContent(jsonStr, Encoding.UTF8, "application/json");

                PrepareMessage(httpMsg, ts, postSign);
            } else if (method == HttpMethod.Get)
            {
                var qs = MapOutAnObject(data);
                var getSign = GenerateSign(ts, qs);
                var needsQuestionMark = qs.Length > 0 ? "?" : "";

                httpMsg = new HttpRequestMessage(method, $"{URL}{endpoint}{needsQuestionMark}{qs}");

                PrepareMessage(httpMsg, ts, getSign);
            } else if (method == HttpMethod.Put)
            {
                string boundary = "boundary-for-file";
                string mimeType = "image/png";

                var multiform = new MultipartFormDataContent(boundary: boundary);

                var values = data.GetType().GetProperties().ToDictionary(p => p.Name, p => p.GetValue(data));
                var filepath = (string)values["upload_file"];
                string filename = Path.GetFileName(filepath);

                var fileContents = File.ReadAllBytes(filepath);
                multiform.Add(new ByteArrayContent(fileContents), "upload_file", filename);

                httpMsg = new HttpRequestMessage(HttpMethod.Post, $"{URL}{endpoint}");
                httpMsg.Content = multiform;

                byte[] payload = Encoding.UTF8.GetBytes(
                    $"--{boundary}\r\n" +
                    $"Content-Disposition: form-data; name=upload_file; filename={filename}; filename*=utf-8''{filename}\r\n\r\n"
                )
                .Concat(fileContents)
                .Concat(Encoding.UTF8.GetBytes($"\r\n--{boundary}--\r\n"))
                .ToArray();

                var binarySign = GenerateBinarySign(ts, payload);

                PrepareMessage(httpMsg, ts, binarySign);
            }

            resp = await client.SendAsync(httpMsg);

            var statusCode = resp.StatusCode;
            if (statusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception($"Request failed with status code {statusCode}");
            }

            // parse response
            var respJsonStr = await resp.Content.ReadAsStringAsync();
            var respObject = JsonConvert.DeserializeObject<GenericAPIResponse>(respJsonStr);

            // check for errors
            var retCode = respObject.RetCode ?? respObject.RetCodeAlternative;
            var retMsg = respObject.RetMsg ?? respObject.RetMsgAlternative;

            if (retCode != 0)
            {
                throw new Exception($"API Error: {retMsg} (ErrCode: {retCode})");
            }

            // re-parse actual result
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(respObject.Result));
        }

        private void PrepareMessage(HttpRequestMessage httpMsg, long ts, string sign)
        {
            // add all the required fields
            httpMsg.Headers.Add("X-BAPI-API-KEY", API_KEY);
            httpMsg.Headers.Add("X-BAPI-SIGN", sign);
            httpMsg.Headers.Add("X-BAPI-SIGN-TYPE", "2");
            httpMsg.Headers.Add("X-BAPI-TIMESTAMP", ts.ToString());
            httpMsg.Headers.Add("X-BAPI-RECV-WINDOW", RECV_WINDOW.ToString());
        }
    }
}