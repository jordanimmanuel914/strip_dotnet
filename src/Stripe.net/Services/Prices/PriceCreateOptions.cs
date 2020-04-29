namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the price can be used for new purchases.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Describes how to compute the price per period. Either <c>per_unit</c> or <c>tiered</c>.
        /// <c>per_unit</c> indicates that the fixed amount (specified in <see cref="UnitAmount"/>
        /// or <see cref="UnitAmountDecimal"/> will be charged per unit in <c>quantity</c> (for
        /// prices with <see cref="PriceRecurring.UsageType"/> set to <c>licensed</c>), or per unit
        /// of total usage (for prices with <see cref="PriceRecurring.UsageType"/> set to
        /// <c>metered</c>). <c>tiered</c> indicates that the unit pricing will be computed using a
        /// tiering strategy as defined using the <see cref="Tiers"/> and <see cref="TiersMode"/>
        /// attributes.
        /// </summary>
        [JsonProperty("billing_scheme")]
        public string BillingScheme { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A lookup key used to retrieve prices dynamically from a static string.
        /// </summary>
        [JsonProperty("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A brief description of the price, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// The ID of the product that this price will belong to.
        /// </summary>
        [JsonProperty("product")]
        internal string Product { get; set; }

        /// <summary>
        /// These fields can be used to create a new product that this price will belong to.
        /// </summary>
        [JsonProperty("product_data")]
        internal PriceProductDataOptions ProductData { get; set; }

        /// <summary>
        /// The recurring components of a price such as its interval.
        /// </summary>
        [JsonProperty("recurring")]
        public PriceRecurringOptions Recurring { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires
        /// <see cref="BillingScheme"/> to be set to <c>tiered</c>.
        /// </summary>
        [JsonProperty("tiers")]
        public List<PriceTierOptions> Tiers { get; set; }

        /// <summary>
        /// Defines if the tiering price should be <c>graduated</c> or <c>volume</c> based. In
        /// volume-based tiering, the maximum quantity within a period determines the per unit
        /// price, in <c>graduated</c> tiering pricing can successively change as the quantity
        /// grows.
        /// </summary>
        [JsonProperty("tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// If set to <c>true</c>, will atomically remove the lookup key from the existing price,
        /// and assign it to this price.
        /// </summary>
        [JsonProperty("transfer_lookup_key")]
        public bool? TransferLookupKey { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the
        /// billed price. Cannot be combined with <see cref="Tiers"/>.
        /// </summary>
        [JsonProperty("transform_quantity")]
        public PriceTransformQuantityOptions TransformQuantity { get; set; }

        /// <summary>
        /// The amount in cents to be charged on the interval specified.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <see cref="UnitAmount"/>, but contains a decimal value with at most 12 decimal
        /// places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
