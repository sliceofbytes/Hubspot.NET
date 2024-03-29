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
    /// A request to import external accounting contact properties in HubSpot
    /// </summary>
    [DataContract(Name = "UpdatedContact")]
    public partial class UpdatedContact : IEquatable<UpdatedContact>, IValidatableObject
    {
        /// <summary>
        /// The operation to be performed.
        /// </summary>
        /// <value>The operation to be performed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SyncActionEnum
        {
            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            [EnumMember(Value = "CREATE")]
            CREATE = 1,

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            UPDATE = 2,

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            [EnumMember(Value = "DELETE")]
            DELETE = 3

        }


        /// <summary>
        /// The operation to be performed.
        /// </summary>
        /// <value>The operation to be performed.</value>
        [DataMember(Name = "syncAction", IsRequired = true, EmitDefaultValue = false)]
        public SyncActionEnum SyncAction { get; set; }
        /// <summary>
        /// Designates the type of the customer object.
        /// </summary>
        /// <value>Designates the type of the customer object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomerTypeEnum
        {
            /// <summary>
            /// Enum CONTACT for value: CONTACT
            /// </summary>
            [EnumMember(Value = "CONTACT")]
            CONTACT = 1,

            /// <summary>
            /// Enum COMPANY for value: COMPANY
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANY = 2

        }


        /// <summary>
        /// Designates the type of the customer object.
        /// </summary>
        /// <value>Designates the type of the customer object.</value>
        [DataMember(Name = "customerType", EmitDefaultValue = false)]
        public CustomerTypeEnum? CustomerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatedContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedContact" /> class.
        /// </summary>
        /// <param name="syncAction">The operation to be performed. (required).</param>
        /// <param name="updatedAt">The timestamp (ISO8601 format) when the customer was updated in the external accounting system. (required).</param>
        /// <param name="emailAddress">The customer&#39;s email address (required).</param>
        /// <param name="id">The ID of the customer in the external accounting system. (required).</param>
        /// <param name="customerType">Designates the type of the customer object..</param>
        public UpdatedContact(SyncActionEnum syncAction = default(SyncActionEnum), DateTimeOffset updatedAt = default(DateTimeOffset), string emailAddress = default(string), string id = default(string), CustomerTypeEnum? customerType = default(CustomerTypeEnum?))
        {
            this.SyncAction = syncAction;
            this.UpdatedAt = updatedAt;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null) {
                throw new ArgumentNullException("emailAddress is a required property for UpdatedContact and cannot be null");
            }
            this.EmailAddress = emailAddress;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for UpdatedContact and cannot be null");
            }
            this.Id = id;
            this.CustomerType = customerType;
        }

        /// <summary>
        /// The timestamp (ISO8601 format) when the customer was updated in the external accounting system.
        /// </summary>
        /// <value>The timestamp (ISO8601 format) when the customer was updated in the external accounting system.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// The customer&#39;s email address
        /// </summary>
        /// <value>The customer&#39;s email address</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The ID of the customer in the external accounting system.
        /// </summary>
        /// <value>The ID of the customer in the external accounting system.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatedContact {\n");
            sb.Append("  SyncAction: ").Append(SyncAction).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
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
            return this.Equals(input as UpdatedContact);
        }

        /// <summary>
        /// Returns true if UpdatedContact instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatedContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatedContact input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SyncAction == input.SyncAction ||
                    this.SyncAction.Equals(input.SyncAction)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CustomerType == input.CustomerType ||
                    this.CustomerType.Equals(input.CustomerType)
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
                hashCode = (hashCode * 59) + this.SyncAction.GetHashCode();
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CustomerType.GetHashCode();
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
