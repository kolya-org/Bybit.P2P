using Bybit.P2P.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bybit.P2P.Models
{
    public class GetOnlineAdsResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        public partial class Item
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("accountId")]
            public string AccountId { get; set; }

            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("nickName")]
            public string NickName { get; set; }

            [JsonProperty("tokenId")]
            public string TokenId { get; set; }

            [JsonProperty("tokenName")]
            public string TokenName { get; set; }

            [JsonProperty("currencyId")]
            public string CurrencyId { get; set; }

            [JsonProperty("side")]
            public long Side { get; set; }

            [JsonProperty("priceType")]
            public long PriceType { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("premium")]
            public string Premium { get; set; }

            [JsonProperty("lastQuantity")]
            public string LastQuantity { get; set; }

            [JsonProperty("quantity")]
            public string Quantity { get; set; }

            [JsonProperty("frozenQuantity")]
            public string FrozenQuantity { get; set; }

            [JsonProperty("executedQuantity")]
            public string ExecutedQuantity { get; set; }

            [JsonProperty("minAmount")]
            public string MinAmount { get; set; }

            [JsonProperty("maxAmount")]
            public string MaxAmount { get; set; }

            [JsonProperty("remark")]
            public string Remark { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("createDate")]
            public string CreateDate { get; set; }

            [JsonProperty("payments")]
            public List<string> Payments { get; set; }

            [JsonProperty("orderNum")]
            public long OrderNum { get; set; }

            [JsonProperty("finishNum")]
            public long FinishNum { get; set; }

            [JsonProperty("recentOrderNum")]
            public long RecentOrderNum { get; set; }

            [JsonProperty("recentExecuteRate")]
            public long RecentExecuteRate { get; set; }

            [JsonProperty("fee")]
            public string Fee { get; set; }

            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("lastLogoutTime")]
            public string LastLogoutTime { get; set; }

            [JsonProperty("blocked")]
            public string Blocked { get; set; }

            [JsonProperty("makerContact")]
            public bool MakerContact { get; set; }

            [JsonProperty("symbolInfo")]
            public SymbolInfo SymbolInfo { get; set; }

            [JsonProperty("tradingPreferenceSet")]
            public TradingPreferenceSet TradingPreferenceSet { get; set; }

            [JsonProperty("version")]
            public long Version { get; set; }

            [JsonProperty("authStatus")]
            public long AuthStatus { get; set; }

            [JsonProperty("recommend")]
            public bool Recommend { get; set; }

            [JsonProperty("recommendTag")]
            public string RecommendTag { get; set; }

            [JsonProperty("authTag")]
            public List<string> AuthTag { get; set; }

            [JsonProperty("userType")]
            public string UserType { get; set; }

            [JsonProperty("itemType")]
            public string ItemType { get; set; }

            [JsonProperty("paymentPeriod")]
            public long PaymentPeriod { get; set; }

            [JsonProperty("userMaskId")]
            public string UserMaskId { get; set; }

            [JsonProperty("verificationOrderSwitch")]
            public bool VerificationOrderSwitch { get; set; }

            [JsonProperty("verificationOrderLabels")]
            public List<object> VerificationOrderLabels { get; set; }

            [JsonProperty("verificationOrderAmount")]
            public string VerificationOrderAmount { get; set; }

            [JsonProperty("ban")]
            public bool Ban { get; set; }

            [JsonProperty("baned")]
            public bool Baned { get; set; }
        }
    }
}
