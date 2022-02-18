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
    /// State of the token definition for update requests.
    /// </summary>
    [DataContract(Name = "TimelineEventTemplateTokenUpdateRequest")]
    public partial class TimelineEventTemplateTokenUpdateRequest : IEquatable<TimelineEventTemplateTokenUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineEventTemplateTokenUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimelineEventTemplateTokenUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineEventTemplateTokenUpdateRequest" /> class.
        /// </summary>
        /// <param name="label">Used for list segmentation and reporting. (required).</param>
        /// <param name="objectPropertyName">The name of the CRM object property. This will populate the CRM object property associated with the event. With enough of these, you can fully build CRM objects via the Timeline API..</param>
        /// <param name="options">If type is &#x60;enumeration&#x60;, we should have a list of options to choose from. (required).</param>
        public TimelineEventTemplateTokenUpdateRequest(string label = default(string), string objectPropertyName = default(string), List<TimelineEventTemplateTokenOption> options = default(List<TimelineEventTemplateTokenOption>))
        {
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for TimelineEventTemplateTokenUpdateRequest and cannot be null");
            }
            this.Label = label;
            // to ensure "options" is required (not null)
            if (options == null) {
                throw new ArgumentNullException("options is a required property for TimelineEventTemplateTokenUpdateRequest and cannot be null");
            }
            this.Options = options;
            this.ObjectPropertyName = objectPropertyName;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimelineEventTemplateTokenUpdateRequest {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ObjectPropertyName: ").Append(ObjectPropertyName).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as TimelineEventTemplateTokenUpdateRequest);
        }

        /// <summary>
        /// Returns true if TimelineEventTemplateTokenUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TimelineEventTemplateTokenUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimelineEventTemplateTokenUpdateRequest input)
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
