namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentConfirmOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the PaymentIntent. Required if a publishable key is used to
        /// confirm the payment intent.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("off_session")]
        public AnyOf<bool?, string> OffSession { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }
    }
}
