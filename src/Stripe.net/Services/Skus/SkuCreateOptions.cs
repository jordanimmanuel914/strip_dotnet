namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SkuCreateOptions : BaseOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Whether or not the SKU is currently available for purchase. Defaults to true.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A dictionary of attributes and values for the attributes defined by the product. If, for
        /// example, a product's attributes are <c>["size", "gender"]</c>, a valid SKU has the
        /// following dictionary of attributes: <c>{"size": "Medium", "gender": "Unisex"}</c>.
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The identifier for the SKU. Must be unique. If not provided, an identifier will be randomly generated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The URL of an image for this SKU, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Description of the SKU's inventory.
        /// </summary>
        [JsonProperty("inventory")]
        public InventoryOptions Inventory { get; set; }

        /// <summary>
        /// Set of key/value pairs that you can attach to an object. It can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The dimensions of this SKU for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public PackageDimensionOptions PackageDimensions { get; set; }

        /// <summary>
        /// The cost of the item as a positive integer in the smallest currency unit (that is, 100 cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a 0-decimal currency).
        /// </summary>
        [JsonProperty("price")]
        public long? Price { get; set; }

        /// <summary>
        /// The ID of the product this SKU is associated with. The product must be currently active.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
