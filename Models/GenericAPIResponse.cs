using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models
{
    public class GenericAPIResponse
    {
        [JsonProperty("ret_msg")]
        public string? RetMsg { get; set; }

        [JsonProperty("ret_code")]
        public int? RetCode { get; set; }

        [JsonProperty("retMsg")]
        public string? RetMsgAlternative { get; set; }

        [JsonProperty("retCode")]
        public int? RetCodeAlternative { get; set; }

        [JsonProperty("result")]
        public object Result { get; set; }
    }
}
