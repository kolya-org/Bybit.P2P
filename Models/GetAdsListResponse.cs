using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models
{
    public class GetAdsListResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("hiddenFlag")]
        public bool HiddenFlag { get; set; }

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

            [JsonProperty("symbolInfo")]
            public SymbolInfo SymbolInfo { get; set; }

            [JsonProperty("tradingPreferenceSet")]
            public TradingPreferenceSet TradingPreferenceSet { get; set; }

            [JsonProperty("paymentTerms")]
            public List<PaymentTerm> PaymentTerms { get; set; }

            [JsonProperty("version")]
            public long Version { get; set; }

            [JsonProperty("updateDate")]
            public string UpdateDate { get; set; }

            [JsonProperty("feeRate")]
            public string FeeRate { get; set; }

            [JsonProperty("paymentPeriod")]
            public long PaymentPeriod { get; set; }

            [JsonProperty("itemType")]
            public string ItemType { get; set; }
        }

        public partial class PaymentTerm
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("realName")]
            public string RealName { get; set; }

            [JsonProperty("paymentType")]
            public long PaymentType { get; set; }

            [JsonProperty("bankName")]
            public string BankName { get; set; }

            [JsonProperty("branchName")]
            public string BranchName { get; set; }

            [JsonProperty("accountNo")]
            public string AccountNo { get; set; }

            [JsonProperty("qrcode")]
            public string Qrcode { get; set; }

            [JsonProperty("visible")]
            public long Visible { get; set; }

            [JsonProperty("payMessage")]
            public string PayMessage { get; set; }

            [JsonProperty("firstName")]
            public string FirstName { get; set; }

            [JsonProperty("lastName")]
            public string LastName { get; set; }

            [JsonProperty("secondLastName")]
            public string SecondLastName { get; set; }

            [JsonProperty("clabe")]
            public string Clabe { get; set; }

            [JsonProperty("debitCardNumber")]
            public string DebitCardNumber { get; set; }

            [JsonProperty("mobile")]
            public string Mobile { get; set; }

            [JsonProperty("businessName")]
            public string BusinessName { get; set; }

            [JsonProperty("concept")]
            public string Concept { get; set; }

            [JsonProperty("paymentExt1")]
            public string PaymentExt1 { get; set; }

            [JsonProperty("paymentExt2")]
            public string PaymentExt2 { get; set; }

            [JsonProperty("paymentExt3")]
            public string PaymentExt3 { get; set; }

            [JsonProperty("paymentExt4")]
            public string PaymentExt4 { get; set; }

            [JsonProperty("paymentExt5")]
            public string PaymentExt5 { get; set; }

            [JsonProperty("paymentExt6")]
            public string PaymentExt6 { get; set; }

            [JsonProperty("paymentTemplateVersion")]
            public long PaymentTemplateVersion { get; set; }

            [JsonProperty("paymentConfig")]
            public PaymentConfig PaymentConfig { get; set; }

            [JsonProperty("realNameVerified")]
            public bool RealNameVerified { get; set; }
        }

        public partial class PaymentConfig
        {
            [JsonProperty("paymentType")]
            public long PaymentType { get; set; }

            [JsonProperty("paymentName")]
            public string PaymentName { get; set; }

            [JsonProperty("paymentDialect")]
            public string PaymentDialect { get; set; }

            [JsonProperty("paymentTemplateItem")]
            public List<object> PaymentTemplateItem { get; set; }
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
            public Ad BuyAd { get; set; }

            [JsonProperty("sellAd")]
            public Ad SellAd { get; set; }
        }

        public partial class Ad
        {
            [JsonProperty("paymentPeriods")]
            public List<long> PaymentPeriods { get; set; }
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
