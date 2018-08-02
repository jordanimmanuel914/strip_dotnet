namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeFileLinkSharedOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// A future timestamp after which the link will no longer be usable.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("expires_at")]
        internal long? ExpiresAtInternal
        {
            get
            {
                if (!this.ExpiresAt.HasValue)
                {
                    return null;
                }

                return EpochTime.ConvertDateTimeToEpoch(this.ExpiresAt.Value);
            }
        }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
