using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
    public partial class Extension
    {
        [JsonProperty("isDelayWithdraw")]
        public bool IsDelayWithdraw { get; set; }

        [JsonProperty("delayTime")]
        public string DelayTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }
    }
}
