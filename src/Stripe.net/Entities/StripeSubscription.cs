﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscription : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// One of <see cref="StripeBilling" />. When charging automatically, Stripe will attempt to pay this subscription at the end of the cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions.
        /// </summary>
        [JsonProperty("billing")]
        public StripeBilling? Billing { get; set; }

        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? CurrentPeriodStart { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        /// <summary>
        /// Number of days a customer has to pay invoices generated by this subscription. This value will be null for subscriptions where billing=charge_automatically.
        /// </summary>
        [JsonProperty("days_until_due")]
        public int? DaysUntilDue { get; set; }

        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        [JsonProperty("ended_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? EndedAt { get; set; }

        [JsonProperty("items")]
        public StripeList<StripeSubscriptionItem> Items { get; set; }

        // TODO: add livemode

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public StripePlan StripePlan { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? TrialStart { get; set; }
    }
}