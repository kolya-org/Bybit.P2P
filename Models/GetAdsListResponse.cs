using Bybit.P2P.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bybit.P2P.Models
{
    public class GetAdsListResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public List<Advertisement> Items { get; set; }

        [JsonProperty("hiddenFlag")]
        public bool HiddenFlag { get; set; }
    }
}
