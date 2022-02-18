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
    /// BatchInputMarketingEventExternalUniqueIdentifier
    /// </summary>
    [DataContract(Name = "BatchInputMarketingEventExternalUniqueIdentifier")]
    public partial class BatchInputMarketingEventExternalUniqueIdentifier : IEquatable<BatchInputMarketingEventExternalUniqueIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputMarketingEventExternalUniqueIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchInputMarketingEventExternalUniqueIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputMarketingEventExternalUniqueIdentifier" /> class.
        /// </summary>
        /// <param name="inputs">inputs (required).</param>
        public BatchInputMarketingEventExternalUniqueIdentifier(List<MarketingEventExternalUniqueIdentifier> inputs = default(List<MarketingEventExternalUniqueIdentifier>))
        {
            // to ensure "inputs" is required (not null)
            if (inputs == null) {
                throw new ArgumentNullException("inputs is a required property for BatchInputMarketingEventExternalUniqueIdentifier and cannot be null");
            }
            this.Inputs = inputs;
        }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name = "inputs", IsRequired = true, EmitDefaultValue = false)]
        public List<MarketingEventExternalUniqueIdentifier> Inputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchInputMarketingEventExternalUniqueIdentifier {\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
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
            return this.Equals(input as BatchInputMarketingEventExternalUniqueIdentifier);
        }

        /// <summary>
        /// Returns true if BatchInputMarketingEventExternalUniqueIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchInputMarketingEventExternalUniqueIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchInputMarketingEventExternalUniqueIdentifier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
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
                if (this.Inputs != null)
                {
                    hashCode = (hashCode * 59) + this.Inputs.GetHashCode();
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
