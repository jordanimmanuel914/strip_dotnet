// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptions : StripeEntity<PaymentIntentPaymentMethodOptions>
    {
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("sofort")]
        public PaymentIntentPaymentMethodOptionsSofort Sofort { get; set; }
    }
}
