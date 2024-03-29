/*
 * HubSpot
 *
 * Provides a way for apps to subscribe to certain change events in HubSpot. Once configured, apps will receive event payloads containing details about the changes at a specified target URL. There can only be one target URL for receiving event notifications per app.
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HubSpot.NET.Client.OpenAPIDateConverter;

namespace HubSpot.NET.Model
{
    /// <summary>
    /// CardObjectTypeBody
    /// </summary>
    [DataContract(Name = "CardObjectTypeBody")]
    public partial class CardObjectTypeBody : IEquatable<CardObjectTypeBody>, IValidatableObject
    {
        /// <summary>
        /// A CRM object type where this card should be displayed.
        /// </summary>
        /// <value>A CRM object type where this card should be displayed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 1,

            /// <summary>
            /// Enum Deals for value: deals
            /// </summary>
            [EnumMember(Value = "deals")]
            Deals = 2,

            /// <summary>
            /// Enum Companies for value: companies
            /// </summary>
            [EnumMember(Value = "companies")]
            Companies = 3,

            /// <summary>
            /// Enum Tickets for value: tickets
            /// </summary>
            [EnumMember(Value = "tickets")]
            Tickets = 4

        }


        /// <summary>
        /// A CRM object type where this card should be displayed.
        /// </summary>
        /// <value>A CRM object type where this card should be displayed.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardObjectTypeBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardObjectTypeBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardObjectTypeBody" /> class.
        /// </summary>
        /// <param name="name">A CRM object type where this card should be displayed. (required).</param>
        /// <param name="propertiesToSend">An array of properties that should be sent to this card&#39;s target URL when the data fetch request is made. Must be valid properties for the corresponding CRM object type. (required).</param>
        public CardObjectTypeBody(NameEnum name = default(NameEnum), List<string> propertiesToSend = default(List<string>))
        {
            this.Name = name;
            // to ensure "propertiesToSend" is required (not null)
            if (propertiesToSend == null) {
                throw new ArgumentNullException("propertiesToSend is a required property for CardObjectTypeBody and cannot be null");
            }
            this.PropertiesToSend = propertiesToSend;
        }

        /// <summary>
        /// An array of properties that should be sent to this card&#39;s target URL when the data fetch request is made. Must be valid properties for the corresponding CRM object type.
        /// </summary>
        /// <value>An array of properties that should be sent to this card&#39;s target URL when the data fetch request is made. Must be valid properties for the corresponding CRM object type.</value>
        [DataMember(Name = "propertiesToSend", IsRequired = true, EmitDefaultValue = false)]
        public List<string> PropertiesToSend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardObjectTypeBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertiesToSend: ").Append(PropertiesToSend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CardObjectTypeBody);
        }

        /// <summary>
        /// Returns true if CardObjectTypeBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CardObjectTypeBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardObjectTypeBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.PropertiesToSend == input.PropertiesToSend ||
                    this.PropertiesToSend != null &&
                    input.PropertiesToSend != null &&
                    this.PropertiesToSend.SequenceEqual(input.PropertiesToSend)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                if (this.PropertiesToSend != null)
                {
                    hashCode = (hashCode * 59) + this.PropertiesToSend.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
