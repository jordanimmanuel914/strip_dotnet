﻿namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class PaymentSourceConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);

            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var incoming = JObject.Load(reader);

            var source = new PaymentSource
            {
                Id = incoming.SelectToken("id").ToString()
            };

            if (incoming.SelectToken("object")?.ToString() == "account")
            {
                source.Type = PaymentSourceType.Account;
                source.Account = Mapper<Account>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "bank_account")
            {
                source.Type = PaymentSourceType.BankAccount;
                source.BankAccount = Mapper<BankAccount>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "card")
            {
                source.Type = PaymentSourceType.Card;
                source.Card = Mapper<Card>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "source")
            {
                source.Type = PaymentSourceType.Source;
                source.SourceObject = Mapper<Source>.MapFromJson(incoming.ToString());
            }

            return source;
        }
    }
}