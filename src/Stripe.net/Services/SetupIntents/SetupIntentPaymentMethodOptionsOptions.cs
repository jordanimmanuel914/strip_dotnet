// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for any card setup attempted on this SetupIntent.
        /// </summary>
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> SetupIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public SetupIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }
    }
}
