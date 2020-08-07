namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerInvoiceSettingsCustomFieldOptions : INestedOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
