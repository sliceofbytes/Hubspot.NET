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
    /// Representation of a tax defined in the external accounting system.
    /// </summary>
    [DataContract(Name = "Tax")]
    public partial class Tax : IEquatable<Tax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        /// <param name="code">The code/ID of the tax in the external accounting system. (required).</param>
        /// <param name="percentage">The tax percentage.  For example, 8.05 represents a 8.05% tax rate. (required).</param>
        /// <param name="name">The display name of the tax. (required).</param>
        public Tax(string code = default(string), decimal percentage = default(decimal), string name = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null) {
                throw new ArgumentNullException("code is a required property for Tax and cannot be null");
            }
            this.Code = code;
            this.Percentage = percentage;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Tax and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// The code/ID of the tax in the external accounting system.
        /// </summary>
        /// <value>The code/ID of the tax in the external accounting system.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The tax percentage.  For example, 8.05 represents a 8.05% tax rate.
        /// </summary>
        /// <value>The tax percentage.  For example, 8.05 represents a 8.05% tax rate.</value>
        [DataMember(Name = "percentage", IsRequired = true, EmitDefaultValue = false)]
        public decimal Percentage { get; set; }

        /// <summary>
        /// The display name of the tax.
        /// </summary>
        /// <value>The display name of the tax.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Tax {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Tax);
        }

        /// <summary>
        /// Returns true if Tax instances are equal
        /// </summary>
        /// <param name="input">Instance of Tax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tax input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
