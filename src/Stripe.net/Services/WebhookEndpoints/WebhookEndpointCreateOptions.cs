namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class WebhookEndpointCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Events sent to this endpoint will be generated with this API version instead of your
        /// account's default API version. We recommend that you set this to the API version that
        /// the library is pinned to in <see cref="StripeConfiguration.ApiVersion"/>.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Whether this endpoint should receive events from connected accounts or your account.
        /// </summary>
        [JsonProperty("connect")]
        public bool? Connect { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint.
        /// </summary>
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
