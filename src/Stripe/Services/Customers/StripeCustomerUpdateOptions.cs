﻿using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCustomerUpdateOptions : CreditCardOptions
	{
		[JsonProperty("coupon")]
		public string Coupon { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("account_balance")]
		public int? AccountBalance { get; set; }
	}
}
