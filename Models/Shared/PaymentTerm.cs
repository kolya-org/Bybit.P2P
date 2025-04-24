using Newtonsoft.Json;

namespace Bybit.P2P.Models.Shared
{
    public partial class PaymentTerm
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realName")]
        public string RealName { get; set; }

        [JsonProperty("paymentType")]
        public long PaymentType { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("accountNo")]
        public string AccountNo { get; set; }

        [JsonProperty("qrcode")]
        public string Qrcode { get; set; }

        [JsonProperty("visible")]
        public long Visible { get; set; }

        [JsonProperty("payMessage")]
        public string PayMessage { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("clabe")]
        public string Clabe { get; set; }

        [JsonProperty("debitCardNumber")]
        public string DebitCardNumber { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        [JsonProperty("concept")]
        public string Concept { get; set; }

        [JsonProperty("online")]
        public string Online { get; set; }

        [JsonProperty("paymentExt1")]
        public string PaymentExt1 { get; set; }

        [JsonProperty("paymentExt2")]
        public string PaymentExt2 { get; set; }

        [JsonProperty("paymentExt3")]
        public string PaymentExt3 { get; set; }

        [JsonProperty("paymentExt4")]
        public string PaymentExt4 { get; set; }

        [JsonProperty("paymentExt5")]
        public string PaymentExt5 { get; set; }

        [JsonProperty("paymentExt6")]
        public string PaymentExt6 { get; set; }

        [JsonProperty("paymentTemplateVersion")]
        public long PaymentTemplateVersion { get; set; }

        [JsonProperty("paymentConfigVo")]
        public PaymentTermConfig PaymentConfig { get; set; }

        [JsonProperty("ruPaymentPrompt")]
        public bool RuPaymentPrompt { get; set; }

        [JsonProperty("realNameVerified")]
        public bool RealNameVerified { get; set; }
    }
}
