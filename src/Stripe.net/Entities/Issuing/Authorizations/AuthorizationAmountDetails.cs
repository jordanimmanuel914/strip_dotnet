namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationAmountDetails : StripeEntity<AuthorizationAmountDetails>
    {
        /// <summary>
        /// The fee charged by the ATM for the cash withdrawal.
        /// </summary>
        [JsonProperty("atm_fee")]
        public long? AtmFee { get; set; }
    }
}
