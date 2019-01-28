namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CustomerInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Default custom fields to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }
    }
}
