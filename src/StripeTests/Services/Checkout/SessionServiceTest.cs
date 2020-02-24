namespace StripeTests.Checkout
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Checkout;
    using Xunit;

    public class SessionServiceTest : BaseStripeTest
    {
        private const string SessionId = "cs_123";
        private readonly SessionService service;
        private readonly SessionCreateOptions createOptions;
        private readonly SessionListOptions listOptions;

        public SessionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SessionService(this.StripeClient);

            this.createOptions = new SessionCreateOptions
            {
                CancelUrl = "https://stripe.com/cancel",
                ClientReferenceId = "1234",
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Amount = 1234,
                        Currency = "usd",
                        Description = "item1",
                        Images = new List<string>
                        {
                            "https://stripe.com/image1",
                        },
                        Name = "item name",
                        Quantity = 2,
                    },
                },
                PaymentIntentData = new SessionPaymentIntentDataOptions
                {
                    Description = "description",
                    Shipping = new ChargeShippingOptions
                    {
                        Name = "name",
                        Phone = "555-555-5555",
                        Address = new AddressOptions
                        {
                            State = "CA",
                            City = "City",
                            Line1 = "Line1",
                            Line2 = "Line2",
                            PostalCode = "90210",
                            Country = "US",
                        },
                    },
                },
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                SuccessUrl = "https://stripe.com/success",
            };

            this.listOptions = new SessionListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var session = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var session = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public void Get()
        {
            var session = this.service.Get(SessionId);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions/cs_123");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var session = await this.service.GetAsync(SessionId);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions/cs_123");
            Assert.NotNull(session);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public void List()
        {
            var intents = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions");
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("checkout.session", intents.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var intents = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/checkout/sessions");
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("checkout.session", intents.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var intents = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(intents);
            Assert.Equal("checkout.session", intents[0].Object);
        }
    }
}
