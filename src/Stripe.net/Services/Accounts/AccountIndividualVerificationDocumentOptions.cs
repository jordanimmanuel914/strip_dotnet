namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountIndividualVerificationDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
