using Newtonsoft.Json;

namespace Bybit.P2P.Models
{
    public class UploadChatFileResponse
    {
        [JsonProperty("uploadId")]
        public object UploadId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
