using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.P2P.Models.Shared
{
    public class Generic2FA
    {
        [JsonProperty("securityRiskToken")]
        public string SecurityRiskToken { get; set; }

        [JsonProperty("riskTokenType")]
        public string RiskTokenType { get; set; }

        [JsonProperty("riskVersion")]
        public string RiskVersion { get; set; }

        [JsonProperty("needSecurityRisk")]
        public bool NeedSecurityRisk { get; set; }
    }
}
