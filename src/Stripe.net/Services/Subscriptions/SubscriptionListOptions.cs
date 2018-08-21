﻿namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionListOptions : ListOptions
    {
        /// <summary>
        /// The billing mode of the subscriptions to retrieve. One of <see cref="Billing" />.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        /// <summary>
        /// The ID of the customer whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The ID of the plan whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// The status of the subscriptions to retrieve. One of <see cref="SubscriptionStatuses"/> or <c>all</c>. Passing in a value of <c>canceled</c> will return all canceled subscriptions, including those belonging to deleted customers. Passing in a value of <c>all</c> will return subscriptions of all statuses.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
