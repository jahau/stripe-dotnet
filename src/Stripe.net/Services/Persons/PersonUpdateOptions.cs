namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The person’s address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the person’s address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person’s address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// The person’s date of birth.
        /// </summary>
        [JsonProperty("dob")]
        public DobOptions Dob { get; set; }

        /// <summary>
        /// The person’s email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The person’s first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Kana variation of the person’s first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person’s first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// The person’s gender (International regulations require either <c>male</c> or
        /// <c>female</c>).
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The person’s ID number, as appropriate for their country. For example, a social
        /// security number in the U.S., social insurance number in Canada, etc. Instead of the
        /// number itself, you can also provide a PII token provided by Stripe.js.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// The person’s last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The Kana variation of the person’s last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person’s last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        /// <summary>
        /// The person’s maiden name.
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format. Individual keys can be
        /// unset by posting an empty value to them. All keys can be unset by posting an empty
        /// value to metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A person token, used to securely provide details to the person.
        /// </summary>
        [JsonProperty("person_token")]
        public string PersonToken { get; set; }

        /// <summary>
        /// The person’s phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The relationship that this person has with the account’s legal entity.
        /// </summary>
        [JsonProperty("relationship")]
        public PersonRelationshipOptions Relationship { get; set; }

        /// <summary>
        /// The last 4 digits of the person’s social security number.
        /// </summary>
        [JsonProperty("ssn_last_4")]
        [AllowNameMismatch]
        public string SSNLast4 { get; set; }

        /// <summary>
        /// The person’s verification status.
        /// </summary>
        [JsonProperty("verification")]
        public PersonVerificationOptions Verification { get; set; }
    }
}
