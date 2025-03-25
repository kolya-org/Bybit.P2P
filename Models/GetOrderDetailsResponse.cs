using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
        public List<ConfirmedPayTermClass> PaymentTermList { get; set; }

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
        public ConfirmedPayTermClass PaymentTermResult { get; set; }

        [JsonProperty("orderFinishMinute")]
        public long OrderFinishMinute { get; set; }

        [JsonProperty("confirmedPayTerm")]
        public ConfirmedPayTermClass ConfirmedPayTerm { get; set; }

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
        public ExtensionClass Extension { get; set; }

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
        public AppraiseInfoClass AppraiseInfo { get; set; }

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
        public JudgeInfoClass JudgeInfo { get; set; }

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
        public List<string> TargetUserDisplays { get; set; }

        [JsonProperty("appealProcessChangeFlag")]
        public bool AppealProcessChangeFlag { get; set; }

        [JsonProperty("appealNegotiationNode")]
        public long AppealNegotiationNode { get; set; }

        public partial class AppraiseInfoClass
        {
            [JsonProperty("anonymous")]
            public string Anonymous { get; set; }

            [JsonProperty("appraiseContent")]
            public string AppraiseContent { get; set; }

            [JsonProperty("appraiseId")]
            public string AppraiseId { get; set; }

            [JsonProperty("appraiseType")]
            public string AppraiseType { get; set; }

            [JsonProperty("modifyFlag")]
            public string ModifyFlag { get; set; }

            [JsonProperty("updateDate")]
            public string UpdateDate { get; set; }
        }

        public partial class ConfirmedPayTermClass
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

            [JsonProperty("online")]
            public string Online { get; set; }

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

            [JsonProperty("paymentConfigVo")]
            public PaymentConfigVo PaymentConfigVo { get; set; }

            [JsonProperty("ruPaymentPrompt")]
            public bool RuPaymentPrompt { get; set; }
        }

        public partial class PaymentConfigVo
        {
            [JsonProperty("paymentType")]
            public string PaymentType { get; set; }

            [JsonProperty("checkType")]
            public long CheckType { get; set; }

            [JsonProperty("sort")]
            public long Sort { get; set; }

            [JsonProperty("paymentName")]
            public string PaymentName { get; set; }

            [JsonProperty("addTips")]
            public string AddTips { get; set; }

            [JsonProperty("itemTips")]
            public string ItemTips { get; set; }

            [JsonProperty("online")]
            public long Online { get; set; }

            [JsonProperty("items")]
            public List<object> Items { get; set; }
        }

        public partial class ExtensionClass
        {
            [JsonProperty("isDelayWithdraw")]
            public bool IsDelayWithdraw { get; set; }

            [JsonProperty("delayTime")]
            public string DelayTime { get; set; }

            [JsonProperty("startTime")]
            public string StartTime { get; set; }
        }

        public partial class JudgeInfoClass
        {
            [JsonProperty("autoJudgeUnlockTime")]
            public string AutoJudgeUnlockTime { get; set; }

            [JsonProperty("dissentResult")]
            public string DissentResult { get; set; }

            [JsonProperty("preDissent")]
            public string PreDissent { get; set; }

            [JsonProperty("postDissent")]
            public string PostDissent { get; set; }
        }
    }
}
