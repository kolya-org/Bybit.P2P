using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
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
