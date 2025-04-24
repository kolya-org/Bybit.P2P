using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
    public partial class AppraiseShow
    {
        [JsonProperty("appraiseCode")]
        public string AppraiseCode { get; set; }

        [JsonProperty("appraiseType")]
        public string AppraiseType { get; set; }
    }
}
