// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebitOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// Verification method for the intent.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
