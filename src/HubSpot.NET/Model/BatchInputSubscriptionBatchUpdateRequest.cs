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
    /// BatchInputSubscriptionBatchUpdateRequest
    /// </summary>
    [DataContract(Name = "BatchInputSubscriptionBatchUpdateRequest")]
    public partial class BatchInputSubscriptionBatchUpdateRequest : IEquatable<BatchInputSubscriptionBatchUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputSubscriptionBatchUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchInputSubscriptionBatchUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputSubscriptionBatchUpdateRequest" /> class.
        /// </summary>
        /// <param name="inputs">inputs (required).</param>
        public BatchInputSubscriptionBatchUpdateRequest(List<SubscriptionBatchUpdateRequest> inputs = default(List<SubscriptionBatchUpdateRequest>))
        {
            // to ensure "inputs" is required (not null)
            if (inputs == null) {
                throw new ArgumentNullException("inputs is a required property for BatchInputSubscriptionBatchUpdateRequest and cannot be null");
            }
            this.Inputs = inputs;
        }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name = "inputs", IsRequired = true, EmitDefaultValue = false)]
        public List<SubscriptionBatchUpdateRequest> Inputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchInputSubscriptionBatchUpdateRequest {\n");
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
            return this.Equals(input as BatchInputSubscriptionBatchUpdateRequest);
        }

        /// <summary>
        /// Returns true if BatchInputSubscriptionBatchUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchInputSubscriptionBatchUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchInputSubscriptionBatchUpdateRequest input)
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
