namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplicationFeeRefund : StripeEntity<ApplicationFeeRefund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Balance Transaction
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction.Id;
            set => this.InternalBalanceTransaction.Id = value;
        }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction.ExpandedObject;
            set => this.InternalBalanceTransaction.ExpandedObject = value;
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Fee
        [JsonIgnore]
        public string FeeId
        {
            get => this.InternalFee.Id;
            set => this.InternalFee.Id = value;
        }

        [JsonIgnore]
        public ApplicationFee Fee
        {
            get => this.InternalFee.ExpandedObject;
            set => this.InternalFee.ExpandedObject = value;
        }

        [JsonProperty("fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
        internal ExpandableField<ApplicationFee> InternalFee { get; set; }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
