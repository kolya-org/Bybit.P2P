using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        public partial class SymbolInfo
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("exchangeId")]
            public string ExchangeId { get; set; }

            [JsonProperty("orgId")]
            public string OrgId { get; set; }

            [JsonProperty("tokenId")]
            public string TokenId { get; set; }

            [JsonProperty("currencyId")]
            public string CurrencyId { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("lowerLimitAlarm")]
            public long LowerLimitAlarm { get; set; }

            [JsonProperty("upperLimitAlarm")]
            public long UpperLimitAlarm { get; set; }

            [JsonProperty("itemDownRange")]
            public string ItemDownRange { get; set; }

            [JsonProperty("itemUpRange")]
            public string ItemUpRange { get; set; }

            [JsonProperty("currencyMinQuote")]
            public string CurrencyMinQuote { get; set; }

            [JsonProperty("currencyMaxQuote")]
            public string CurrencyMaxQuote { get; set; }

            [JsonProperty("currencyLowerMaxQuote")]
            public string CurrencyLowerMaxQuote { get; set; }

            [JsonProperty("tokenMinQuote")]
            public string TokenMinQuote { get; set; }

            [JsonProperty("tokenMaxQuote")]
            public string TokenMaxQuote { get; set; }

            [JsonProperty("kycCurrencyLimit")]
            public string KycCurrencyLimit { get; set; }

            [JsonProperty("itemSideLimit")]
            public long ItemSideLimit { get; set; }

            [JsonProperty("buyFeeRate")]
            public string BuyFeeRate { get; set; }

            [JsonProperty("sellFeeRate")]
            public string SellFeeRate { get; set; }

            [JsonProperty("orderAutoCancelMinute")]
            public long OrderAutoCancelMinute { get; set; }

            [JsonProperty("orderFinishMinute")]
            public long OrderFinishMinute { get; set; }

            [JsonProperty("tradeSide")]
            public long TradeSide { get; set; }

            [JsonProperty("currency")]
            public Currency Currency { get; set; }

            [JsonProperty("token")]
            public Token Token { get; set; }

            [JsonProperty("buyAd")]
            public object BuyAd { get; set; }

            [JsonProperty("sellAd")]
            public object SellAd { get; set; }
        }

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

        public partial class TradingPreferenceSet
        {
            [JsonProperty("hasUnPostAd")]
            public long HasUnPostAd { get; set; }

            [JsonProperty("isKyc")]
            public long IsKyc { get; set; }

            [JsonProperty("isEmail")]
            public long IsEmail { get; set; }

            [JsonProperty("isMobile")]
            public long IsMobile { get; set; }

            [JsonProperty("hasRegisterTime")]
            public long HasRegisterTime { get; set; }

            [JsonProperty("registerTimeThreshold")]
            public long RegisterTimeThreshold { get; set; }

            [JsonProperty("orderFinishNumberDay30")]
            public long OrderFinishNumberDay30 { get; set; }

            [JsonProperty("completeRateDay30")]
            public string CompleteRateDay30 { get; set; }

            [JsonProperty("nationalLimit")]
            public string NationalLimit { get; set; }

            [JsonProperty("hasOrderFinishNumberDay30")]
            public long HasOrderFinishNumberDay30 { get; set; }

            [JsonProperty("hasCompleteRateDay30")]
            public long HasCompleteRateDay30 { get; set; }

            [JsonProperty("hasNationalLimit")]
            public long HasNationalLimit { get; set; }
        }
    }
}
