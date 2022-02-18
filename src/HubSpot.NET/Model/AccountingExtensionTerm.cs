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
    /// Representation of payment terms that are defined in the external accounting system. One of &#39;dueDays&#39; or &#39;dueDate&#39; is required.
    /// </summary>
    [DataContract(Name = "AccountingExtensionTerm")]
    public partial class AccountingExtensionTerm : IEquatable<AccountingExtensionTerm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingExtensionTerm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountingExtensionTerm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingExtensionTerm" /> class.
        /// </summary>
        /// <param name="dueDate">The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd).</param>
        /// <param name="name">The display name of the payment terms. (required).</param>
        /// <param name="id">The ID of the payment terms in the external accounting system. (required).</param>
        /// <param name="dueDays">The number of days that these payment terms represent..</param>
        public AccountingExtensionTerm(DateTimeOffset dueDate = default(DateTimeOffset), string name = default(string), string id = default(string), int dueDays = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for AccountingExtensionTerm and cannot be null");
            }
            this.Name = name;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for AccountingExtensionTerm and cannot be null");
            }
            this.Id = id;
            this.DueDate = dueDate;
            this.DueDays = dueDays;
        }

        /// <summary>
        /// The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd)
        /// </summary>
        /// <value>The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd)</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset DueDate { get; set; }

        /// <summary>
        /// The display name of the payment terms.
        /// </summary>
        /// <value>The display name of the payment terms.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the payment terms in the external accounting system.
        /// </summary>
        /// <value>The ID of the payment terms in the external accounting system.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The number of days that these payment terms represent.
        /// </summary>
        /// <value>The number of days that these payment terms represent.</value>
        [DataMember(Name = "dueDays", EmitDefaultValue = false)]
        public int DueDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountingExtensionTerm {\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DueDays: ").Append(DueDays).Append("\n");
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
            return this.Equals(input as AccountingExtensionTerm);
        }

        /// <summary>
        /// Returns true if AccountingExtensionTerm instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountingExtensionTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountingExtensionTerm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DueDays == input.DueDays ||
                    this.DueDays.Equals(input.DueDays)
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
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DueDays.GetHashCode();
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