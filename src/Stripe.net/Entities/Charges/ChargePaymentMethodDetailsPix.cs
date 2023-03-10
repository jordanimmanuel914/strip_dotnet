// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsPix : StripeEntity<ChargePaymentMethodDetailsPix>
    {
        /// <summary>
        /// Unique transaction id generated by BCB.
        /// </summary>
        [JsonProperty("bank_transaction_id")]
        public string BankTransactionId { get; set; }
    }
}
