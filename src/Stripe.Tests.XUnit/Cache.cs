﻿using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        static Cache()
        {
            Items = new Dictionary<string, object>();
        }

        /// <summary>
        /// This holds a list of cached items for re-use. Customers, Plans, Subscriptions, etc.
        /// </summary>
        public static Dictionary<string, object> Items { get; set; }

        public static string ApiKey => Environment.GetEnvironmentVariable("stripe_test_secret_key");
    }
}
