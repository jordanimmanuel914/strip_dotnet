namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleCreateOptions : SubscriptionScheduleSharedOptions
    {
        /// <summary>
        /// The identifier of the customer to create the subscription schedule for.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Migrate an existing subscription to be managed by a subscription schedule. If this
        /// parameter is set, a subscription schedule will be created using the subscription’s
        /// plan(s), set to auto-renew using the subscription’s interval. Other parameters cannot
        /// be set since their values will be inferred from the subscription.
        /// </summary>
        [JsonProperty("from_subscription")]
        public string FromSubscription { get; set; }

        /// <summary>
        /// The date at which the subscription schedule starts.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? StartDate { get; set; }
    }
}
