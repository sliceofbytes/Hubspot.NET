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
    /// PropertyModificationMetadata
    /// </summary>
    [DataContract(Name = "PropertyModificationMetadata")]
    public partial class PropertyModificationMetadata : IEquatable<PropertyModificationMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModificationMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyModificationMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModificationMetadata" /> class.
        /// </summary>
        /// <param name="archivable">archivable (required).</param>
        /// <param name="readOnlyDefinition">readOnlyDefinition (required).</param>
        /// <param name="readOnlyOptions">readOnlyOptions.</param>
        /// <param name="readOnlyValue">readOnlyValue (required).</param>
        public PropertyModificationMetadata(bool archivable = default(bool), bool readOnlyDefinition = default(bool), bool readOnlyOptions = default(bool), bool readOnlyValue = default(bool))
        {
            this.Archivable = archivable;
            this.ReadOnlyDefinition = readOnlyDefinition;
            this.ReadOnlyValue = readOnlyValue;
            this.ReadOnlyOptions = readOnlyOptions;
        }

        /// <summary>
        /// Gets or Sets Archivable
        /// </summary>
        [DataMember(Name = "archivable", IsRequired = true, EmitDefaultValue = true)]
        public bool Archivable { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnlyDefinition
        /// </summary>
        [DataMember(Name = "readOnlyDefinition", IsRequired = true, EmitDefaultValue = true)]
        public bool ReadOnlyDefinition { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnlyOptions
        /// </summary>
        [DataMember(Name = "readOnlyOptions", EmitDefaultValue = true)]
        public bool ReadOnlyOptions { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnlyValue
        /// </summary>
        [DataMember(Name = "readOnlyValue", IsRequired = true, EmitDefaultValue = true)]
        public bool ReadOnlyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyModificationMetadata {\n");
            sb.Append("  Archivable: ").Append(Archivable).Append("\n");
            sb.Append("  ReadOnlyDefinition: ").Append(ReadOnlyDefinition).Append("\n");
            sb.Append("  ReadOnlyOptions: ").Append(ReadOnlyOptions).Append("\n");
            sb.Append("  ReadOnlyValue: ").Append(ReadOnlyValue).Append("\n");
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
            return this.Equals(input as PropertyModificationMetadata);
        }

        /// <summary>
        /// Returns true if PropertyModificationMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyModificationMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyModificationMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Archivable == input.Archivable ||
                    this.Archivable.Equals(input.Archivable)
                ) && 
                (
                    this.ReadOnlyDefinition == input.ReadOnlyDefinition ||
                    this.ReadOnlyDefinition.Equals(input.ReadOnlyDefinition)
                ) && 
                (
                    this.ReadOnlyOptions == input.ReadOnlyOptions ||
                    this.ReadOnlyOptions.Equals(input.ReadOnlyOptions)
                ) && 
                (
                    this.ReadOnlyValue == input.ReadOnlyValue ||
                    this.ReadOnlyValue.Equals(input.ReadOnlyValue)
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
                hashCode = (hashCode * 59) + this.Archivable.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadOnlyDefinition.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadOnlyOptions.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadOnlyValue.GetHashCode();
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
