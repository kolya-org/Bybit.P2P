using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
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
        public Ad BuyAd { get; set; }

        [JsonProperty("sellAd")]
        public Ad SellAd { get; set; }

        public partial class Ad
        {
            [JsonProperty("paymentPeriods")]
            public List<long> PaymentPeriods { get; set; }
        }
    }
}
