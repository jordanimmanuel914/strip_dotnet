using System;
using System.IO;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests.camel_case_contract_resolver
{
    public class when_mapping_discount
    {
        private static StripeDiscount _discount;

        static when_mapping_discount()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        private Because of = () =>
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "discount.json");
            var json = File.ReadAllText(path);
            _discount = Mapper<StripeDiscount>.MapFromJson(json);
        };

        private It should_not_throw_exception = () => _discount.CustomerId.ShouldEqual("cus_5GC5XeHUC4TmO9");
    }
}