namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpxOptions : INestedOptions
    {
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
