namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceBitcoin : StripeEntity<SourceBitcoin>
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_charged")]
        public long AmountCharged { get; set; }

        [JsonProperty("amount_received")]
        public long AmountReceived { get; set; }

        [JsonProperty("amount_returned")]
        public long AmountReturned { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
