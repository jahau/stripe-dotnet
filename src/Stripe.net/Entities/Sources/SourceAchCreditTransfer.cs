namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceAchCreditTransfer : StripeEntity<SourceAchCreditTransfer>
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("swift_code")]
        public string SwiftCode { get; set; }
    }
}
