namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemOptions : INestedOptions
    {
        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new price object inline.
        /// </summary>
        [JsonProperty("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this item for a phase on the subscription schedule.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
