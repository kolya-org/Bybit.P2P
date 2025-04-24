using Newtonsoft.Json;

namespace Bybit.P2P.Models.Shared
{
    public partial class TradingPreferenceSet
    {
        [JsonProperty("hasUnPostAd")]
        public long HasUnPostAd { get; set; }

        [JsonProperty("isKyc")]
        public long IsKyc { get; set; }

        [JsonProperty("isEmail")]
        public long IsEmail { get; set; }

        [JsonProperty("isMobile")]
        public long IsMobile { get; set; }

        [JsonProperty("hasRegisterTime")]
        public long HasRegisterTime { get; set; }

        [JsonProperty("registerTimeThreshold")]
        public long RegisterTimeThreshold { get; set; }

        [JsonProperty("orderFinishNumberDay30")]
        public long OrderFinishNumberDay30 { get; set; }

        [JsonProperty("completeRateDay30")]
        public string CompleteRateDay30 { get; set; }

        [JsonProperty("nationalLimit")]
        public string NationalLimit { get; set; }

        [JsonProperty("hasOrderFinishNumberDay30")]
        public long HasOrderFinishNumberDay30 { get; set; }

        [JsonProperty("hasCompleteRateDay30")]
        public long HasCompleteRateDay30 { get; set; }

        [JsonProperty("hasNationalLimit")]
        public long HasNationalLimit { get; set; }
    }
}
