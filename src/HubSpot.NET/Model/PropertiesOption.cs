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
    /// PropertiesOption
    /// </summary>
    [DataContract(Name = "PropertiesOption")]
    public partial class PropertiesOption : IEquatable<PropertiesOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOption" /> class.
        /// </summary>
        /// <param name="label">A human-readable option label that will be shown in HubSpot. (required).</param>
        /// <param name="value">The internal value of the option, which must be used when setting the property value through the API. (required).</param>
        /// <param name="description">A description of the option..</param>
        /// <param name="displayOrder">Options are displayed in order starting with the lowest positive integer value. Values of -1 will cause the option to be displayed after any positive values..</param>
        /// <param name="hidden">Hidden options will not be displayed in HubSpot. (required).</param>
        public PropertiesOption(string label = default(string), string value = default(string), string description = default(string), int displayOrder = default(int), bool hidden = default(bool))
        {
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for PropertiesOption and cannot be null");
            }
            this.Label = label;
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for PropertiesOption and cannot be null");
            }
            this.Value = value;
            this.Hidden = hidden;
            this.Description = description;
            this.DisplayOrder = displayOrder;
        }

        /// <summary>
        /// A human-readable option label that will be shown in HubSpot.
        /// </summary>
        /// <value>A human-readable option label that will be shown in HubSpot.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The internal value of the option, which must be used when setting the property value through the API.
        /// </summary>
        /// <value>The internal value of the option, which must be used when setting the property value through the API.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// A description of the option.
        /// </summary>
        /// <value>A description of the option.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Options are displayed in order starting with the lowest positive integer value. Values of -1 will cause the option to be displayed after any positive values.
        /// </summary>
        /// <value>Options are displayed in order starting with the lowest positive integer value. Values of -1 will cause the option to be displayed after any positive values.</value>
        [DataMember(Name = "displayOrder", EmitDefaultValue = false)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Hidden options will not be displayed in HubSpot.
        /// </summary>
        /// <value>Hidden options will not be displayed in HubSpot.</value>
        [DataMember(Name = "hidden", IsRequired = true, EmitDefaultValue = true)]
        public bool Hidden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertiesOption {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
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
            return this.Equals(input as PropertiesOption);
        }

        /// <summary>
        /// Returns true if PropertiesOption instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    this.DisplayOrder.Equals(input.DisplayOrder)
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    this.Hidden.Equals(input.Hidden)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayOrder.GetHashCode();
                hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
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
