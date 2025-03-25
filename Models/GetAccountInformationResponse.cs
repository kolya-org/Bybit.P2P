using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models
{
    public class GetAccountInformationResponse
    {
        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("defaultNickName")]
        public bool DefaultNickName { get; set; }

        [JsonProperty("whiteFlag")]
        public long WhiteFlag { get; set; }

        [JsonProperty("contactConfig")]
        public bool ContactConfig { get; set; }

        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("kycLevel")]
        public long KycLevel { get; set; }

        [JsonProperty("lastLogoutTime")]
        public string LastLogoutTime { get; set; }

        [JsonProperty("recentRate")]
        public long RecentRate { get; set; }

        [JsonProperty("totalFinishCount")]
        public long TotalFinishCount { get; set; }

        [JsonProperty("totalFinishSellCount")]
        public long TotalFinishSellCount { get; set; }

        [JsonProperty("totalFinishBuyCount")]
        public long TotalFinishBuyCount { get; set; }

        [JsonProperty("recentFinishCount")]
        public long RecentFinishCount { get; set; }

        [JsonProperty("averageReleaseTime")]
        public string AverageReleaseTime { get; set; }

        [JsonProperty("averageTransferTime")]
        public string AverageTransferTime { get; set; }

        [JsonProperty("accountCreateDays")]
        public long AccountCreateDays { get; set; }

        [JsonProperty("firstTradeDays")]
        public long FirstTradeDays { get; set; }

        [JsonProperty("realName")]
        public string RealName { get; set; }

        [JsonProperty("recentTradeAmount")]
        public string RecentTradeAmount { get; set; }

        [JsonProperty("totalTradeAmount")]
        public string TotalTradeAmount { get; set; }

        [JsonProperty("executeNum")]
        public long ExecuteNum { get; set; }

        [JsonProperty("orderNum")]
        public long OrderNum { get; set; }

        [JsonProperty("hasUnPostAd")]
        public long HasUnPostAd { get; set; }

        [JsonProperty("registerTime")]
        public string RegisterTime { get; set; }

        [JsonProperty("authStatus")]
        public long AuthStatus { get; set; }

        [JsonProperty("kycCountryCode")]
        public string KycCountryCode { get; set; }

        [JsonProperty("blocked")]
        public string Blocked { get; set; }

        [JsonProperty("goodAppraiseRate")]
        public string GoodAppraiseRate { get; set; }

        [JsonProperty("goodAppraiseCount")]
        public long GoodAppraiseCount { get; set; }

        [JsonProperty("badAppraiseCount")]
        public long BadAppraiseCount { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("paymentCount")]
        public long PaymentCount { get; set; }

        [JsonProperty("contactCount")]
        public long ContactCount { get; set; }

        [JsonProperty("realNameMask")]
        public string RealNameMask { get; set; }

        [JsonProperty("vipLevel")]
        public long VipLevel { get; set; }

        [JsonProperty("vipProfit")]
        public List<string> VipProfit { get; set; }

        [JsonProperty("userTag")]
        public List<string> UserTag { get; set; }

        [JsonProperty("userCancelCountLimit")]
        public long UserCancelCountLimit { get; set; }

        [JsonProperty("paymentRealNameUneditable")]
        public bool PaymentRealNameUneditable { get; set; }

        [JsonProperty("lostRoleAffected")]
        public bool LostRoleAffected { get; set; }

        [JsonProperty("userCurPrivilege")]
        public List<string> UserCurPrivilege { get; set; }

        [JsonProperty("userType")]
        public string UserType { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("realNameEn")]
        public string RealNameEn { get; set; }

        [JsonProperty("canSubOnline")]
        public bool CanSubOnline { get; set; }

        [JsonProperty("curPrivilegeInfo")]
        public List<CurPrivilegeInfoClass> CurPrivilegeInfo { get; set; }

        [JsonProperty("openApiSwitch")]
        public long OpenApiSwitch { get; set; }

        public partial class CurPrivilegeInfoClass
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("data")]
            public string Data { get; set; }
        }
    }
}
