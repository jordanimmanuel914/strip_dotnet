namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    // TODO: Rename to CardAuthorizationControls in a future major version and move to Card folder.
    public class AuthorizationControls : StripeEntity<AuthorizationControls>
    {
        /// <summary>
        /// Categories of authorizations permitted for this card.
        /// </summary>
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        /// <summary>
        /// Categories of authorizations to always decline for this card.
        /// </summary>
        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [Obsolete("Use Card.Currency instead.")]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Obsolete("Use SpendingLimits instead.")]
        [JsonProperty("max_amount")]
        public long? MaxAmount { get; set; }

        /// <summary>
        /// Maximum count of approved authorizations on this card. Counts all authorizations
        /// retroactively.
        /// </summary>
        [JsonProperty("max_approvals")]
        public long? MaxApprovals { get; set; }

        /// <summary>
        /// Limit the spending with rules based on time intervals and categories.
        /// </summary>
        [JsonProperty("spending_limits")]
        public List<CardAuthorizationControlsSpendingLimit> SpendingLimits { get; set; }

        /// <summary>
        /// Currency for the amounts within spending_limits. Locked to the currency of the card.
        /// </summary>
        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
