using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
    public partial class Currency
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("exchangeId")]
        public string ExchangeId { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("currencyId")]
        public string CurrencyId { get; set; }

        [JsonProperty("scale")]
        public long Scale { get; set; }
    }
}
