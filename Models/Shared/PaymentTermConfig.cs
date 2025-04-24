using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bybit.P2P.Models.Shared
{
    public partial class PaymentTermConfig
    {
        [JsonProperty("paymentType")]
        public long PaymentType { get; set; }

        [JsonProperty("paymentName")]
        public string PaymentName { get; set; }

        [JsonProperty("paymentDialect")]
        public string PaymentDialect { get; set; }

        [JsonProperty("paymentTemplateItem")]
        public List<object> PaymentTemplateItem { get; set; }

        [JsonProperty("checkType")]
        public long CheckType { get; set; }

        [JsonProperty("sort")]
        public long Sort { get; set; }

        [JsonProperty("addTips")]
        public string AddTips { get; set; }

        [JsonProperty("itemTips")]
        public string ItemTips { get; set; }

        [JsonProperty("online")]
        public long Online { get; set; }

        [JsonProperty("items")]
        public List<PaymentTermConfigItem> Items { get; set; }

        public partial class PaymentTermConfigItem
        {
            [JsonProperty("view")]
            public bool View { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("placeholder")]
            public string Placeholder { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("maxLength")]
            public string MaxLength { get; set; }

            [JsonProperty("required")]
            public bool ItemRequired { get; set; }
        }
    }
}
