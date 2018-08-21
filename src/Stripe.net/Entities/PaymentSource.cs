﻿namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum PaymentSourceType
    {
        Account,
        BankAccount,
        Card,
        Source,
    }

    [JsonConverter(typeof(PaymentSourceConverter))]
    public class PaymentSource : StripeEntityWithId
    {
        public PaymentSourceType Type { get; set; }

        public Account Account { get; set; }

        public BankAccount BankAccount { get; set; }

        public Card Card { get; set; }

        public Source SourceObject { get; set; }
    }
}
