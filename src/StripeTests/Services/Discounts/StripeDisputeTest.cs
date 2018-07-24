namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeDisputeTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/disputes/dp_123");
            var dispute = Mapper<StripeDispute>.MapFromJson(json);
            Assert.NotNull(dispute);
            Assert.IsType<StripeDispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "charge",
            };

            string json = GetFixture("/v1/disputes/dp_123", expansions);
            var dispute = Mapper<StripeDispute>.MapFromJson(json);
            Assert.NotNull(dispute);
            Assert.IsType<StripeDispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("dispute", dispute.Object);

            Assert.NotNull(dispute.Charge);
            Assert.Equal("charge", dispute.Charge.Object);
        }
    }
}
