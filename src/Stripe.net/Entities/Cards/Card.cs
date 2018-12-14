namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Card : StripeEntity, IHasId, IHasMetadata, IHasObject, IExternalAccount, IPaymentSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Account
        public string AccountId { get; set; }

        [JsonIgnore]
        public Account Account { get; set; }

        [JsonProperty("account")]
        internal object InternalAccount
        {
            set
            {
                StringOrObject<Account>.Map(value, s => this.AccountId = s, o => this.Account = o);
            }
        }
        #endregion

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        [JsonProperty("available_payout_methods")]
        public string[] AvailablePayoutMethods { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        [JsonProperty("default_for_currency")]
        public bool DefaultForCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        #region Expandable Recipient
        public string RecipientId { get; set; }

        [JsonIgnore]
        public Recipient Recipient { get; set; }

        [JsonProperty("recipient")]
        internal object InternalRecipient
        {
            set
            {
                StringOrObject<Recipient>.Map(value, s => this.RecipientId = s, o => this.Recipient = o);
            }
        }
        #endregion

        [JsonProperty("three_d_secure")]
        public string ThreeDSecure { get; set; }

        [JsonProperty("tokenization_method")]
        public string TokenizationMethod { get; set; }

        // The properties below are for internal use only and not returned as part of standard API requests.
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iin")]
        public string IIN { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }
    }
}
