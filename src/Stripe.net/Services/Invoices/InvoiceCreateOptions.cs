﻿namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceCreateOptions : BaseOptions, ISupportMetadata
    {
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        /// <summary>
        /// One of <see cref="Billing" />. When charging automatically, Stripe will attempt to pay this invoice using the default source attached to the customer. When sending an invoice, Stripe will email this invoice to the customer with payment instructions. Defaults to charge_automatically.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        /// <summary>
        /// The number of days from which the invoice is created until it is due. Only valid for invoices where billing=send_invoice.
        /// </summary>
        [JsonProperty("days_until_due")]
        public int? DaysUntilDue { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. Only valid for invoices where billing=send_invoice.
        /// </summary>
        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }
    }
}
