namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardInstallmentsPlanOptions : INestedOptions
    {
        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is the number of installment payments
        /// your customer will make to their credit card.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is the interval between installment
        /// payments your customer will make to their credit card.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Type of installment plan, one of <c>fixed_count</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
