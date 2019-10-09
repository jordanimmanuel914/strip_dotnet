namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCreateOptions : AccountSharedOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("individual")]
        public PersonCreateOptions Individual { get; set; }

        /// <summary>
        /// One of <see cref="AccountType"/>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
