namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ThreeDSecureCreateOptions : BaseOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If you pass a card id, you must also pass the customer id.
        /// </summary>
        [JsonProperty("card")]
        [AllowNameMismatch]
        public string CardTokenOrCardId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
