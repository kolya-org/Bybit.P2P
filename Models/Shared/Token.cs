using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
    public partial class Token
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("exchangeId")]
        public string ExchangeId { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("tokenId")]
        public string TokenId { get; set; }

        [JsonProperty("scale")]
        public long Scale { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }
}
