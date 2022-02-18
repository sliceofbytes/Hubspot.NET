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
    /// FeedbackSubmissionsSimplePublicObjectInput
    /// </summary>
    [DataContract(Name = "FeedbackSubmissionsSimplePublicObjectInput")]
    public partial class FeedbackSubmissionsSimplePublicObjectInput : IEquatable<FeedbackSubmissionsSimplePublicObjectInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSubmissionsSimplePublicObjectInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeedbackSubmissionsSimplePublicObjectInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSubmissionsSimplePublicObjectInput" /> class.
        /// </summary>
        /// <param name="properties">properties (required).</param>
        public FeedbackSubmissionsSimplePublicObjectInput(Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            // to ensure "properties" is required (not null)
            if (properties == null) {
                throw new ArgumentNullException("properties is a required property for FeedbackSubmissionsSimplePublicObjectInput and cannot be null");
            }
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeedbackSubmissionsSimplePublicObjectInput {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as FeedbackSubmissionsSimplePublicObjectInput);
        }

        /// <summary>
        /// Returns true if FeedbackSubmissionsSimplePublicObjectInput instances are equal
        /// </summary>
        /// <param name="input">Instance of FeedbackSubmissionsSimplePublicObjectInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackSubmissionsSimplePublicObjectInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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