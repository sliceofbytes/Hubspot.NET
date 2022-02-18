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
    /// State of the token definition.
    /// </summary>
    [DataContract(Name = "TimelineEventTemplateToken")]
    public partial class TimelineEventTemplateToken : IEquatable<TimelineEventTemplateToken>, IValidatableObject
    {
        /// <summary>
        /// The data type of the token. You can currently choose from [string, number, date, enumeration].
        /// </summary>
        /// <value>The data type of the token. You can currently choose from [string, number, date, enumeration].</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 1,

            /// <summary>
            /// Enum Enumeration for value: enumeration
            /// </summary>
            [EnumMember(Value = "enumeration")]
            Enumeration = 2,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 3,

            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 4

        }


        /// <summary>
        /// The data type of the token. You can currently choose from [string, number, date, enumeration].
        /// </summary>
        /// <value>The data type of the token. You can currently choose from [string, number, date, enumeration].</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineEventTemplateToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimelineEventTemplateToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineEventTemplateToken" /> class.
        /// </summary>
        /// <param name="label">Used for list segmentation and reporting. (required).</param>
        /// <param name="objectPropertyName">The name of the CRM object property. This will populate the CRM object property associated with the event. With enough of these, you can fully build CRM objects via the Timeline API..</param>
        /// <param name="options">If type is &#x60;enumeration&#x60;, we should have a list of options to choose from. (required).</param>
        /// <param name="name">The name of the token referenced in the templates. This must be unique for the specific template. It may only contain alphanumeric characters, periods, dashes, or underscores (. - _). (required).</param>
        /// <param name="type">The data type of the token. You can currently choose from [string, number, date, enumeration]. (required).</param>
        /// <param name="createdAt">The date and time that the Event Template Token was created, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020..</param>
        /// <param name="updatedAt">The date and time that the Event Template Token was last updated, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020..</param>
        public TimelineEventTemplateToken(string label = default(string), string objectPropertyName = default(string), List<TimelineEventTemplateTokenOption> options = default(List<TimelineEventTemplateTokenOption>), string name = default(string), TypeEnum type = default(TypeEnum), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset))
        {
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for TimelineEventTemplateToken and cannot be null");
            }
            this.Label = label;
            // to ensure "options" is required (not null)
            if (options == null) {
                throw new ArgumentNullException("options is a required property for TimelineEventTemplateToken and cannot be null");
            }
            this.Options = options;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for TimelineEventTemplateToken and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.ObjectPropertyName = objectPropertyName;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Used for list segmentation and reporting.
        /// </summary>
        /// <value>Used for list segmentation and reporting.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The name of the CRM object property. This will populate the CRM object property associated with the event. With enough of these, you can fully build CRM objects via the Timeline API.
        /// </summary>
        /// <value>The name of the CRM object property. This will populate the CRM object property associated with the event. With enough of these, you can fully build CRM objects via the Timeline API.</value>
        [DataMember(Name = "objectPropertyName", EmitDefaultValue = false)]
        public string ObjectPropertyName { get; set; }

        /// <summary>
        /// If type is &#x60;enumeration&#x60;, we should have a list of options to choose from.
        /// </summary>
        /// <value>If type is &#x60;enumeration&#x60;, we should have a list of options to choose from.</value>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = false)]
        public List<TimelineEventTemplateTokenOption> Options { get; set; }

        /// <summary>
        /// The name of the token referenced in the templates. This must be unique for the specific template. It may only contain alphanumeric characters, periods, dashes, or underscores (. - _).
        /// </summary>
        /// <value>The name of the token referenced in the templates. This must be unique for the specific template. It may only contain alphanumeric characters, periods, dashes, or underscores (. - _).</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The date and time that the Event Template Token was created, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020.
        /// </summary>
        /// <value>The date and time that the Event Template Token was created, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date and time that the Event Template Token was last updated, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020.
        /// </summary>
        /// <value>The date and time that the Event Template Token was last updated, as an ISO 8601 timestamp. Will be null if the template was created before Feb 18th, 2020.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimelineEventTemplateToken {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ObjectPropertyName: ").Append(ObjectPropertyName).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TimelineEventTemplateToken);
        }

        /// <summary>
        /// Returns true if TimelineEventTemplateToken instances are equal
        /// </summary>
        /// <param name="input">Instance of TimelineEventTemplateToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimelineEventTemplateToken input)
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
                    this.ObjectPropertyName == input.ObjectPropertyName ||
                    (this.ObjectPropertyName != null &&
                    this.ObjectPropertyName.Equals(input.ObjectPropertyName))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.ObjectPropertyName != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectPropertyName.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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