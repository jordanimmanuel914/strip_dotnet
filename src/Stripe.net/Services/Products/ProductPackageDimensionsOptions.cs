namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductPackageDimensionsOptions : INestedOptions
    {
        [JsonProperty("height")]
        public decimal? Height { get; set; }

        [JsonProperty("length")]
        public decimal? Length { get; set; }

        [JsonProperty("weight")]
        public decimal? Weight { get; set; }

        [JsonProperty("width")]
        public decimal? Width { get; set; }
    }
}
