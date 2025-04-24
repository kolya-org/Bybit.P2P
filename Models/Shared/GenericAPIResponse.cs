using Newtonsoft.Json;

namespace Bybit.P2P.Models.Shared
{
    public class GenericAPIResponse
    {
        [JsonProperty("ret_msg")]
        public string? RetMsg { get; set; }

        [JsonProperty("ret_code")]
        public int? RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string? RetMsgAlternative { get; set; }

        [JsonProperty("retCode")]
        public int? RetCodeAlternative { get; set; }

        [JsonProperty("result")]
        public object Result { get; set; }
    }
}
