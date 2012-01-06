﻿using Newtonsoft.Json;
using Stripe.Infrastructure;
namespace Stripe
{
    public class StripeTokenService
    {
		public StripeToken Create(StripeTokenCreateOptions createOptions)
		{
			var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Tokens);

			var response = Requestor.PostString(url);

			return Mapper<StripeToken>.MapFromJson(response);
		}

		public StripeToken Get(string tokenId)
		{
			var url = string.Format("{0}/{1}", Urls.Tokens, tokenId);

			var response = Requestor.GetString(url);

			return Mapper<StripeToken>.MapFromJson(response);
		}
    }
}