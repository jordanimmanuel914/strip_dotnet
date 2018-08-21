namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InventoryOptions : INestedOptions
    {
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
