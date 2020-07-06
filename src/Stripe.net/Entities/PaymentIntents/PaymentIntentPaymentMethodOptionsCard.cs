namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsCard : StripeEntity<PaymentIntentPaymentMethodOptionsCard>
    {
        /// <summary>
        /// Installment details for this payment (Mexico only).
        /// </summary>
        [JsonProperty("installments")]
        public PaymentIntentPaymentMethodOptionsCardInstallments Installments { get; set; }

        /// <summary>
        /// Selected network to process this PaymentIntent on. Depends on the available networks of the card
        /// attached to the PaymentIntent. Can be only set confirm-time.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// We strongly recommend that you rely on our SCA engine to automatically prompt your
        /// customers for authentication based on risk level and other requirements. However, if
        /// you wish to request authentication based on logic from your own fraud engine, provide
        /// this option. Permitted values include: <c>automatic</c>, <c>any</c>, or
        /// <c>challenge_only</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
