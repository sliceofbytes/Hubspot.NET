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
    /// Indicates if importing invoices from the external account system into HubSpot is supported for the integration.
    /// </summary>
    [DataContract(Name = "ImportInvoiceFeature")]
    public partial class ImportInvoiceFeature : IEquatable<ImportInvoiceFeature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportInvoiceFeature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportInvoiceFeature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportInvoiceFeature" /> class.
        /// </summary>
        /// <param name="enabled">Indicates if importing invoices from the external account system into HubSpot. (required).</param>
        public ImportInvoiceFeature(bool enabled = default(bool))
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Indicates if importing invoices from the external account system into HubSpot.
        /// </summary>
        /// <value>Indicates if importing invoices from the external account system into HubSpot.</value>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImportInvoiceFeature {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as ImportInvoiceFeature);
        }

        /// <summary>
        /// Returns true if ImportInvoiceFeature instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportInvoiceFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportInvoiceFeature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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