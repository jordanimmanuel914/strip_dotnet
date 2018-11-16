namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ThreeDSecureTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/3d_secure/tdsrc_123");
            var resource = JsonConvert.DeserializeObject<ThreeDSecure>(json);
            Assert.NotNull(resource);
            Assert.IsType<ThreeDSecure>(resource);
            Assert.NotNull(resource.Id);
            Assert.Equal("three_d_secure", resource.Object);
        }
    }
}
