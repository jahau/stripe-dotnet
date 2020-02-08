namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("business_profile")]
        public AccountBusinessProfileOptions BusinessProfile { get; set; }

        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("company")]
        public AccountCompanyOptions Company { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_account")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, AccountBankAccountOptions, AccountCardOptions> ExternalAccount { get; set; }

        [JsonProperty("individual")]
        public PersonUpdateOptions Individual { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("requested_capabilities")]
        public List<string> RequestedCapabilities { get; set; }

        [JsonProperty("settings")]
        public AccountSettingsOptions Settings { get; set; }

        [JsonProperty("tos_acceptance")]
        public AccountTosAcceptanceOptions TosAcceptance { get; set; }
    }
}