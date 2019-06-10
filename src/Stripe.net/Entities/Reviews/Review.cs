namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Review : StripeEntity<Review>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge.Id;
            set => this.InternalCharge.Id = value;
        }

        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge.ExpandedObject;
            set => this.InternalCharge.ExpandedObject = value;
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("open")]
        public bool Open { get; set; }

        #region Expandable PaymentIntent
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent.Id;
            set => this.InternalPaymentIntent.Id = value;
        }

        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent.ExpandedObject;
            set => this.InternalPaymentIntent.ExpandedObject = value;
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
