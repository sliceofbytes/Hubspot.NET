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
    /// SubscriptionDefinition
    /// </summary>
    [DataContract(Name = "SubscriptionDefinition")]
    public partial class SubscriptionDefinition : IEquatable<SubscriptionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDefinition" /> class.
        /// </summary>
        /// <param name="id">The ID of the definition. (required).</param>
        /// <param name="name">The name of the subscription. (required).</param>
        /// <param name="description">A description of the subscription. (required).</param>
        /// <param name="purpose">The purpose of this subscription or the department in your organization that uses it..</param>
        /// <param name="communicationMethod">The method or technology used to contact..</param>
        /// <param name="isActive">Whether the definition is active or archived. (required).</param>
        /// <param name="isDefault">A subscription definition created by HubSpot. (required).</param>
        /// <param name="isInternal">A default description that is used by some HubSpot tools and cannot be edited. (required).</param>
        /// <param name="createdAt">Time at which the definition was created. (required).</param>
        /// <param name="updatedAt">Time at which the definition was last updated. (required).</param>
        public SubscriptionDefinition(string id = default(string), string name = default(string), string description = default(string), string purpose = default(string), string communicationMethod = default(string), bool isActive = default(bool), bool isDefault = default(bool), bool isInternal = default(bool), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for SubscriptionDefinition and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for SubscriptionDefinition and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null) {
                throw new ArgumentNullException("description is a required property for SubscriptionDefinition and cannot be null");
            }
            this.Description = description;
            this.IsActive = isActive;
            this.IsDefault = isDefault;
            this.IsInternal = isInternal;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Purpose = purpose;
            this.CommunicationMethod = communicationMethod;
        }

        /// <summary>
        /// The ID of the definition.
        /// </summary>
        /// <value>The ID of the definition.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the subscription.
        /// </summary>
        /// <value>The name of the subscription.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the subscription.
        /// </summary>
        /// <value>A description of the subscription.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The purpose of this subscription or the department in your organization that uses it.
        /// </summary>
        /// <value>The purpose of this subscription or the department in your organization that uses it.</value>
        [DataMember(Name = "purpose", EmitDefaultValue = false)]
        public string Purpose { get; set; }

        /// <summary>
        /// The method or technology used to contact.
        /// </summary>
        /// <value>The method or technology used to contact.</value>
        [DataMember(Name = "communicationMethod", EmitDefaultValue = false)]
        public string CommunicationMethod { get; set; }

        /// <summary>
        /// Whether the definition is active or archived.
        /// </summary>
        /// <value>Whether the definition is active or archived.</value>
        [DataMember(Name = "isActive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// A subscription definition created by HubSpot.
        /// </summary>
        /// <value>A subscription definition created by HubSpot.</value>
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// A default description that is used by some HubSpot tools and cannot be edited.
        /// </summary>
        /// <value>A default description that is used by some HubSpot tools and cannot be edited.</value>
        [DataMember(Name = "isInternal", IsRequired = true, EmitDefaultValue = true)]
        public bool IsInternal { get; set; }

        /// <summary>
        /// Time at which the definition was created.
        /// </summary>
        /// <value>Time at which the definition was created.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Time at which the definition was last updated.
        /// </summary>
        /// <value>Time at which the definition was last updated.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  CommunicationMethod: ").Append(CommunicationMethod).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  IsInternal: ").Append(IsInternal).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SubscriptionDefinition);
        }

        /// <summary>
        /// Returns true if SubscriptionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.CommunicationMethod == input.CommunicationMethod ||
                    (this.CommunicationMethod != null &&
                    this.CommunicationMethod.Equals(input.CommunicationMethod))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.IsInternal == input.IsInternal ||
                    this.IsInternal.Equals(input.IsInternal)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Purpose != null)
                {
                    hashCode = (hashCode * 59) + this.Purpose.GetHashCode();
                }
                if (this.CommunicationMethod != null)
                {
                    hashCode = (hashCode * 59) + this.CommunicationMethod.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInternal.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
