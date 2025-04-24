using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bybit.P2P.Models
{
    public class GetCurrentBalanceResponse
    {
        [JsonProperty("memberId")]
        public string MemberId { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("balance")]
        public List<BalanceClass> Balance { get; set; }

        public partial class BalanceClass
        {
            [JsonProperty("coin")]
            public string Coin { get; set; }

            [JsonProperty("transferBalance")]
            public string TransferBalance { get; set; }

            [JsonProperty("walletBalance")]
            public string WalletBalance { get; set; }

            [JsonProperty("bonus")]
            public string Bonus { get; set; }
        }
    }
}
