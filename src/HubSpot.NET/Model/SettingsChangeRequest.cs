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
    /// New or updated webhook settings for an app.
    /// </summary>
    [DataContract(Name = "SettingsChangeRequest")]
    public partial class SettingsChangeRequest : IEquatable<SettingsChangeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsChangeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingsChangeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsChangeRequest" /> class.
        /// </summary>
        /// <param name="targetUrl">A publicly available URL for Hubspot to call where event payloads will be delivered. See [link-so-some-doc](#) for details about the format of these event payloads. (required).</param>
        /// <param name="throttling">throttling (required).</param>
        public SettingsChangeRequest(string targetUrl = default(string), ThrottlingSettings throttling = default(ThrottlingSettings))
        {
            // to ensure "targetUrl" is required (not null)
            if (targetUrl == null) {
                throw new ArgumentNullException("targetUrl is a required property for SettingsChangeRequest and cannot be null");
            }
            this.TargetUrl = targetUrl;
            // to ensure "throttling" is required (not null)
            if (throttling == null) {
                throw new ArgumentNullException("throttling is a required property for SettingsChangeRequest and cannot be null");
            }
            this.Throttling = throttling;
        }

        /// <summary>
        /// A publicly available URL for Hubspot to call where event payloads will be delivered. See [link-so-some-doc](#) for details about the format of these event payloads.
        /// </summary>
        /// <value>A publicly available URL for Hubspot to call where event payloads will be delivered. See [link-so-some-doc](#) for details about the format of these event payloads.</value>
        [DataMember(Name = "targetUrl", IsRequired = true, EmitDefaultValue = false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Gets or Sets Throttling
        /// </summary>
        [DataMember(Name = "throttling", IsRequired = true, EmitDefaultValue = false)]
        public ThrottlingSettings Throttling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettingsChangeRequest {\n");
            sb.Append("  TargetUrl: ").Append(TargetUrl).Append("\n");
            sb.Append("  Throttling: ").Append(Throttling).Append("\n");
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
            return this.Equals(input as SettingsChangeRequest);
        }

        /// <summary>
        /// Returns true if SettingsChangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsChangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsChangeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TargetUrl == input.TargetUrl ||
                    (this.TargetUrl != null &&
                    this.TargetUrl.Equals(input.TargetUrl))
                ) && 
                (
                    this.Throttling == input.Throttling ||
                    (this.Throttling != null &&
                    this.Throttling.Equals(input.Throttling))
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
                if (this.TargetUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TargetUrl.GetHashCode();
                }
                if (this.Throttling != null)
                {
                    hashCode = (hashCode * 59) + this.Throttling.GetHashCode();
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
