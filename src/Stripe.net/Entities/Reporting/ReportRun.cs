namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportRun : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        [JsonProperty("reportType")]
        public string ReportType { get; set; }

        [JsonProperty("result")]
        public StripeFileUpload Result { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("succeeded_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime SucceededAt { get; set; }
    }
}
