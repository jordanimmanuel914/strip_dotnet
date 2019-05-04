namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Card : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("authorization_controls")]
        public AuthorizationControls AuthorizationControls { get; set; }

        [JsonProperty("billing")]
        public Billing Billing { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("cardholder")]
        public Cardholder Cardholder { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        #region Expandable ReplacementFor
        [JsonIgnore]
        public string ReplacementForId { get; set; }

        [JsonIgnore]
        public Card ReplacementFor { get; set; }

        [JsonProperty("replacement_for")]
        internal object InternalReplacementFor
        {
            get
            {
                return this.ReplacementFor ?? (object)this.ReplacementForId;
            }

            set
            {
                StringOrObject<Card>.Map(value, s => this.ReplacementForId = s, o => this.ReplacementFor = o);
            }
        }
        #endregion

        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        [JsonProperty("shipping")]
        public CardShipping Shipping { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
