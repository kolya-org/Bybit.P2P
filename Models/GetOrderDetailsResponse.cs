using Bybit.P2P.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bybit.P2P.Models
{
    public class GetOrderDetailsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("side")]
        public long Side { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("makerUserId")]
        public string MakerUserId { get; set; }

        [JsonProperty("targetAccountId")]
        public string TargetAccountId { get; set; }

        [JsonProperty("targetUserId")]
        public string TargetUserId { get; set; }

        [JsonProperty("targetNickName")]
        public string TargetNickName { get; set; }

        [JsonProperty("targetFirstName")]
        public string TargetFirstName { get; set; }

        [JsonProperty("targetSecondName")]
        public string TargetSecondName { get; set; }

        [JsonProperty("targetUserAuthStatus")]
        public long TargetUserAuthStatus { get; set; }

        [JsonProperty("targetConnectInformation")]
        public string TargetConnectInformation { get; set; }

        [JsonProperty("payerRealName")]
        public string PayerRealName { get; set; }

        [JsonProperty("sellerRealName")]
        public string SellerRealName { get; set; }

        [JsonProperty("buyerRealName")]
        public string BuyerRealName { get; set; }

        [JsonProperty("tokenId")]
        public string TokenId { get; set; }

        [JsonProperty("tokenName")]
        public string TokenName { get; set; }

        [JsonProperty("currencyId")]
        public string CurrencyId { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("payCode")]
        public string PayCode { get; set; }

        [JsonProperty("paymentType")]
        public long PaymentType { get; set; }

        [JsonProperty("transferDate")]
        public string TransferDate { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("paymentTermList")]
        public List<PaymentTerm> PaymentTermList { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("transferLastSeconds")]
        public string TransferLastSeconds { get; set; }

        [JsonProperty("recentOrderNum")]
        public long RecentOrderNum { get; set; }

        [JsonProperty("recentExecuteRate")]
        public long RecentExecuteRate { get; set; }

        [JsonProperty("appealLastSeconds")]
        public string AppealLastSeconds { get; set; }

        [JsonProperty("appealContent")]
        public string AppealContent { get; set; }

        [JsonProperty("appealType")]
        public long AppealType { get; set; }

        [JsonProperty("appealNickName")]
        public string AppealNickName { get; set; }

        [JsonProperty("canAppeal")]
        public string CanAppeal { get; set; }

        [JsonProperty("totalAppealTimes")]
        public string TotalAppealTimes { get; set; }

        [JsonProperty("appealedTimes")]
        public string AppealedTimes { get; set; }

        [JsonProperty("paymentTermResult")]
        public PaymentTerm PaymentTermResult { get; set; }

        [JsonProperty("orderFinishMinute")]
        public long OrderFinishMinute { get; set; }

        [JsonProperty("confirmedPayTerm")]
        public PaymentTerm ConfirmedPayTerm { get; set; }

        [JsonProperty("makerFee")]
        public string MakerFee { get; set; }

        [JsonProperty("takerFee")]
        public string TakerFee { get; set; }

        [JsonProperty("fee")]
        public string Fee { get; set; }

        [JsonProperty("showContact")]
        public bool ShowContact { get; set; }

        [JsonProperty("contactInfo")]
        public List<object> ContactInfo { get; set; }

        [JsonProperty("tokenBalance")]
        public string TokenBalance { get; set; }

        [JsonProperty("fiatBalance")]
        public string FiatBalance { get; set; }

        [JsonProperty("unreadMsgCount")]
        public string UnreadMsgCount { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("extension")]
        public Extension Extension { get; set; }

        [JsonProperty("selfUnreadMsgCount")]
        public string SelfUnreadMsgCount { get; set; }

        [JsonProperty("judgeType")]
        public string JudgeType { get; set; }

        [JsonProperty("canReport")]
        public bool CanReport { get; set; }

        [JsonProperty("canReportDisagree")]
        public bool CanReportDisagree { get; set; }

        [JsonProperty("canReportType")]
        public List<string> CanReportType { get; set; }

        [JsonProperty("canReportDisagreeType")]
        public List<object> CanReportDisagreeType { get; set; }

        [JsonProperty("appraiseStatus")]
        public string AppraiseStatus { get; set; }

        [JsonProperty("appraiseInfo")]
        public AppraiseInfo AppraiseInfo { get; set; }

        [JsonProperty("canReportDisagreeTypes")]
        public List<object> CanReportDisagreeTypes { get; set; }

        [JsonProperty("canReportTypes")]
        public List<string> CanReportTypes { get; set; }

        [JsonProperty("orderType")]
        public string OrderType { get; set; }

        [JsonProperty("middleToken")]
        public string MiddleToken { get; set; }

        [JsonProperty("beforePrice")]
        public string BeforePrice { get; set; }

        [JsonProperty("beforeQuantity")]
        public string BeforeQuantity { get; set; }

        [JsonProperty("beforeToken")]
        public string BeforeToken { get; set; }

        [JsonProperty("alternative")]
        public string Alternative { get; set; }

        [JsonProperty("appealUserId")]
        public string AppealUserId { get; set; }

        [JsonProperty("notifyTokenId")]
        public string NotifyTokenId { get; set; }

        [JsonProperty("notifyTokenQuantity")]
        public string NotifyTokenQuantity { get; set; }

        [JsonProperty("cancelResponsible")]
        public string CancelResponsible { get; set; }

        [JsonProperty("chainType")]
        public string ChainType { get; set; }

        [JsonProperty("chainAddress")]
        public string ChainAddress { get; set; }

        [JsonProperty("tradeHashCode")]
        public string TradeHashCode { get; set; }

        [JsonProperty("estimatedGasFee")]
        public string EstimatedGasFee { get; set; }

        [JsonProperty("gasFeeTokenId")]
        public string GasFeeTokenId { get; set; }

        [JsonProperty("tradingFeeTokenId")]
        public string TradingFeeTokenId { get; set; }

        [JsonProperty("onChainInfo")]
        public string OnChainInfo { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("displayRefund")]
        public string DisplayRefund { get; set; }

        [JsonProperty("chainWithdrawLastSeconds")]
        public string ChainWithdrawLastSeconds { get; set; }

        [JsonProperty("chainTransferLastSeconds")]
        public string ChainTransferLastSeconds { get; set; }

        [JsonProperty("orderSource")]
        public string OrderSource { get; set; }

        [JsonProperty("cancelReason")]
        public string CancelReason { get; set; }

        [JsonProperty("sellerCancelExamineRemainTime")]
        public string SellerCancelExamineRemainTime { get; set; }

        [JsonProperty("needSellerExamineCancel")]
        public bool NeedSellerExamineCancel { get; set; }

        [JsonProperty("couponCurrencyAmount")]
        public string CouponCurrencyAmount { get; set; }

        [JsonProperty("totalCurrencyAmount")]
        public string TotalCurrencyAmount { get; set; }

        [JsonProperty("usedCoupon")]
        public bool UsedCoupon { get; set; }

        [JsonProperty("couponTokenId")]
        public string CouponTokenId { get; set; }

        [JsonProperty("couponQuantity")]
        public string CouponQuantity { get; set; }

        [JsonProperty("completedOrderAppealCount")]
        public long CompletedOrderAppealCount { get; set; }

        [JsonProperty("totalCompletedOrderAppealCount")]
        public long TotalCompletedOrderAppealCount { get; set; }

        [JsonProperty("realOrderStatus")]
        public long RealOrderStatus { get; set; }

        [JsonProperty("appealVersion")]
        public long AppealVersion { get; set; }

        [JsonProperty("judgeInfo")]
        public JudgeInfo JudgeInfo { get; set; }

        [JsonProperty("helpType")]
        public string HelpType { get; set; }

        [JsonProperty("appealFlowStatus")]
        public string AppealFlowStatus { get; set; }

        [JsonProperty("appealSubStatus")]
        public string AppealSubStatus { get; set; }

        [JsonProperty("bulkOrderFlag")]
        public bool BulkOrderFlag { get; set; }

        [JsonProperty("targetUserType")]
        public string TargetUserType { get; set; }

        [JsonProperty("targetUserDisplays")]
        public List<object> TargetUserDisplays { get; set; }

        [JsonProperty("appealProcessChangeFlag")]
        public bool AppealProcessChangeFlag { get; set; }

        [JsonProperty("appealNegotiationNode")]
        public long AppealNegotiationNode { get; set; }

        [JsonProperty("loginUserMaskId")]
        public string LoginUserMaskId { get; set; }

        [JsonProperty("targetUserMaskId")]
        public string TargetUserMaskId { get; set; }

        [JsonProperty("appraiseShow")]
        public List<AppraiseShow> AppraiseShow { get; set; }

        [JsonProperty("showPaymentList")]
        public bool ShowPaymentList { get; set; }

        [JsonProperty("verificationOrderLastSeconds")]
        public string VerificationOrderLastSeconds { get; set; }

        [JsonProperty("verificationOrder")]
        public bool VerificationOrder { get; set; }

        [JsonProperty("proofDownloadFlag")]
        public bool ProofDownloadFlag { get; set; }
    }
}
