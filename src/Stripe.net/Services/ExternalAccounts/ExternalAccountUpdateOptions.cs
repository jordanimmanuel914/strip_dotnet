namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExternalAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>The name of the person or business that owns the bank account.</summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of entity that holds the account. This can be either <c>individual</c> or
        /// <c>>company</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>City/District/Suburb/Town/Village.</summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>Billing address country, if provided when creating card.</summary>
        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>Address line 1 (Street address/PO Box/Company name).</summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>Address line 2 (Apartment/Suite/Unit/Building).</summary>
        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>State/County/Province/Region.</summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>ZIP or postal code.</summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// When set to true, this becomes the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        /// <summary>Two digit number representing the card's expiration month.</summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>Four digit number representing the card's expiration year.</summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>Cardholder name.</summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
