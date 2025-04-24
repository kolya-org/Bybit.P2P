using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bybit.P2P.Models
{
    public class GetChatMessagesResponse
    {
        [JsonProperty("result")]
        public List<MessageClass> Messages { get; set; }

        [JsonProperty("totalRows")]
        public string TotalRows { get; set; }

        [JsonProperty("totalPages")]
        public string TotalPages { get; set; }

        [JsonProperty("currentPage")]
        public string CurrentPage { get; set; }

        [JsonProperty("dayLimit")]
        public string DayLimit { get; set; }

        [JsonProperty("showDayLimit")]
        public bool ShowDayLimit { get; set; }

        public class MessageClass
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("accountId")]
            public string AccountId { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("msgType")]
            public long MsgType { get; set; }

            [JsonProperty("msgCode")]
            public long MsgCode { get; set; }

            [JsonProperty("createDate")]
            public string CreateDate { get; set; }

            [JsonProperty("isRead")]
            public long IsRead { get; set; }

            [JsonProperty("contentType")]
            public string ContentType { get; set; }

            [JsonProperty("roleType")]
            public string RoleType { get; set; }

            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("orderId")]
            public string OrderId { get; set; }

            [JsonProperty("msgUuid")]
            public string MsgUuid { get; set; }

            [JsonProperty("nickName")]
            public string NickName { get; set; }

            [JsonProperty("read")]
            public long Read { get; set; }

            [JsonProperty("fileName")]
            public string FileName { get; set; }

            [JsonProperty("onlyForCustomer")]
            public long OnlyForCustomer { get; set; }
        }
    }
}
