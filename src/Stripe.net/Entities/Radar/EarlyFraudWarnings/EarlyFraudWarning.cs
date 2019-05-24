namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EarlyFraudWarning : StripeEntity, IHasId, IHasObject
    {
        /// <summary>Unique identifier for the object.</summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// An EFW is actionable if it has not received a dispute and has not been fully refunded.
        /// You may wish to proactively refund a charge that receives an EFW, in order to avoid
        /// receiving a dispute later.
        /// </summary>
        [JsonProperty("actionable")]
        public bool Actionable { get; set; }

        #region Expandable Application

        /// <summary>ID of the charge this early fraud warning is for.</summary>
        [JsonIgnore]
        public string ChargeId { get; set; }

        [JsonIgnore]
        public Charge Charge { get; set; }

        [JsonProperty("application")]
        internal object InternalCharge
        {
            get
            {
                return this.Charge ?? (object)this.ChargeId;
            }

            set
            {
                StringOrObject<Charge>.Map(value, s => this.ChargeId = s, o => this.Charge = o);
            }
        }
        #endregion

        /// <summary>Time at which the object was created.</summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The type of fraud labelled by the issuer. One of <c>card_never_received</c>,
        /// <c>fraudulent_card_application</c>, <c>made_with_counterfeit_card</c>,
        /// <c>made_with_lost_card</c>, <c>made_with_stolen_card</c>, <c>misc</c>,
        /// <c>unauthorized_use_of_card</c>.
        /// </summary>
        [JsonProperty("fraud_type")]
        public string FraudType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c>
        /// if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
