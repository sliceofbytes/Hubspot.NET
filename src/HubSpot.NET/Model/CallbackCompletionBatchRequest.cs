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
    /// Any information to send back to Workflows when completing an action callback as part of a batch request.
    /// </summary>
    [DataContract(Name = "CallbackCompletionBatchRequest")]
    public partial class CallbackCompletionBatchRequest : IEquatable<CallbackCompletionBatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackCompletionBatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallbackCompletionBatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackCompletionBatchRequest" /> class.
        /// </summary>
        /// <param name="callbackId">The ID of the callback to complete. (required).</param>
        /// <param name="outputFields">A map of action output names and values. (required).</param>
        public CallbackCompletionBatchRequest(string callbackId = default(string), Dictionary<string, string> outputFields = default(Dictionary<string, string>))
        {
            // to ensure "callbackId" is required (not null)
            if (callbackId == null) {
                throw new ArgumentNullException("callbackId is a required property for CallbackCompletionBatchRequest and cannot be null");
            }
            this.CallbackId = callbackId;
            // to ensure "outputFields" is required (not null)
            if (outputFields == null) {
                throw new ArgumentNullException("outputFields is a required property for CallbackCompletionBatchRequest and cannot be null");
            }
            this.OutputFields = outputFields;
        }

        /// <summary>
        /// The ID of the callback to complete.
        /// </summary>
        /// <value>The ID of the callback to complete.</value>
        [DataMember(Name = "callbackId", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackId { get; set; }

        /// <summary>
        /// A map of action output names and values.
        /// </summary>
        /// <value>A map of action output names and values.</value>
        [DataMember(Name = "outputFields", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> OutputFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CallbackCompletionBatchRequest {\n");
            sb.Append("  CallbackId: ").Append(CallbackId).Append("\n");
            sb.Append("  OutputFields: ").Append(OutputFields).Append("\n");
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
            return this.Equals(input as CallbackCompletionBatchRequest);
        }

        /// <summary>
        /// Returns true if CallbackCompletionBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CallbackCompletionBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallbackCompletionBatchRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CallbackId == input.CallbackId ||
                    (this.CallbackId != null &&
                    this.CallbackId.Equals(input.CallbackId))
                ) && 
                (
                    this.OutputFields == input.OutputFields ||
                    this.OutputFields != null &&
                    input.OutputFields != null &&
                    this.OutputFields.SequenceEqual(input.OutputFields)
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
                if (this.CallbackId != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackId.GetHashCode();
                }
                if (this.OutputFields != null)
                {
                    hashCode = (hashCode * 59) + this.OutputFields.GetHashCode();
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