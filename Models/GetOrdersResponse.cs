using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models
{
    public class GetOrdersResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        public partial class Item
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("side")]
            public long Side { get; set; }

            [JsonProperty("tokenId")]
            public string TokenId { get; set; }

            [JsonProperty("orderType")]
            public string OrderType { get; set; }

            [JsonProperty("amount")]
            public string Amount { get; set; }

            [JsonProperty("currencyId")]
            public string CurrencyId { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("notifyTokenQuantity")]
            public string NotifyTokenQuantity { get; set; }

            [JsonProperty("notifyTokenId")]
            public string NotifyTokenId { get; set; }

            [JsonProperty("fee")]
            public string Fee { get; set; }

            [JsonProperty("targetNickName")]
            public string TargetNickName { get; set; }

            [JsonProperty("targetUserId")]
            public string TargetUserId { get; set; }

            [JsonProperty("status")]
            public long Status { get; set; }

            [JsonProperty("selfUnreadMsgCount")]
            public string SelfUnreadMsgCount { get; set; }

            [JsonProperty("createDate")]
            public string CreateDate { get; set; }

            [JsonProperty("transferLastSeconds")]
            public string TransferLastSeconds { get; set; }

            [JsonProperty("appealLastSeconds")]
            public string AppealLastSeconds { get; set; }

            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("sellerRealName")]
            public string SellerRealName { get; set; }

            [JsonProperty("buyerRealName")]
            public string BuyerRealName { get; set; }

            [JsonProperty("judgeInfo")]
            public JudgeInfo JudgeInfo { get; set; }

            [JsonProperty("unreadMsgCount")]
            public string UnreadMsgCount { get; set; }

            [JsonProperty("extension")]
            public Extension Extension { get; set; }

            [JsonProperty("bulkOrderFlag")]
            public bool BulkOrderFlag { get; set; }

            [JsonProperty("targetUserMaskId")]
            public string TargetUserMaskId { get; set; }

            [JsonProperty("loginUserMaskId")]
            public string LoginUserMaskId { get; set; }

            [JsonProperty("verificationOrderLastSeconds")]
            public string VerificationOrderLastSeconds { get; set; }

            [JsonProperty("verificationOrder")]
            public bool VerificationOrder { get; set; }
        }

        public partial class Extension
        {
            [JsonProperty("isDelayWithdraw")]
            public bool IsDelayWithdraw { get; set; }

            [JsonProperty("delayTime")]
            public string DelayTime { get; set; }

            [JsonProperty("startTime")]
            public string StartTime { get; set; }
        }

        public partial class JudgeInfo
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
