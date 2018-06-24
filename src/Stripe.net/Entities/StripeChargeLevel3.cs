using Newtonsoft.Json;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeChargeLevel3 : StripeEntity
    {
        [JsonProperty("line_items")]
        public List<StripeChargeLevel3LineItem> LineItems { get; set; }

        [JsonProperty("merchant_reference")]
        public string MerchantReference { get; set; }

        [JsonProperty("shipping_address_zip")]
        public string ShippingAddressZip { get; set; }

        [JsonProperty("shipping_amount")]
        public int ShippingAmount { get; set; }
    }
}