using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
    public partial class AppraiseInfo
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
}
