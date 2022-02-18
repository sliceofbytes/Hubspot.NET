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
    /// A serverless function associated with this custom workflow action.
    /// </summary>
    [DataContract(Name = "ActionFunction")]
    public partial class ActionFunction : IEquatable<ActionFunction>, IValidatableObject
    {
        /// <summary>
        /// The type of function. This determines when the function will be called.
        /// </summary>
        /// <value>The type of function. This determines when the function will be called.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FunctionTypeEnum
        {
            /// <summary>
            /// Enum PREACTIONEXECUTION for value: PRE_ACTION_EXECUTION
            /// </summary>
            [EnumMember(Value = "PRE_ACTION_EXECUTION")]
            PREACTIONEXECUTION = 1,

            /// <summary>
            /// Enum PREFETCHOPTIONS for value: PRE_FETCH_OPTIONS
            /// </summary>
            [EnumMember(Value = "PRE_FETCH_OPTIONS")]
            PREFETCHOPTIONS = 2,

            /// <summary>
            /// Enum POSTFETCHOPTIONS for value: POST_FETCH_OPTIONS
            /// </summary>
            [EnumMember(Value = "POST_FETCH_OPTIONS")]
            POSTFETCHOPTIONS = 3

        }


        /// <summary>
        /// The type of function. This determines when the function will be called.
        /// </summary>
        /// <value>The type of function. This determines when the function will be called.</value>
        [DataMember(Name = "functionType", IsRequired = true, EmitDefaultValue = false)]
        public FunctionTypeEnum FunctionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionFunction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionFunction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionFunction" /> class.
        /// </summary>
        /// <param name="functionSource">The function source code. (required).</param>
        /// <param name="functionType">The type of function. This determines when the function will be called. (required).</param>
        /// <param name="id">The ID qualifier for the function. This is used to specify which input field a function is associated with for &#x60;PRE_FETCH_OPTIONS&#x60; and &#x60;POST_FETCH_OPTIONS&#x60; function types..</param>
        public ActionFunction(string functionSource = default(string), FunctionTypeEnum functionType = default(FunctionTypeEnum), string id = default(string))
        {
            // to ensure "functionSource" is required (not null)
            if (functionSource == null) {
                throw new ArgumentNullException("functionSource is a required property for ActionFunction and cannot be null");
            }
            this.FunctionSource = functionSource;
            this.FunctionType = functionType;
            this.Id = id;
        }

        /// <summary>
        /// The function source code.
        /// </summary>
        /// <value>The function source code.</value>
        [DataMember(Name = "functionSource", IsRequired = true, EmitDefaultValue = false)]
        public string FunctionSource { get; set; }

        /// <summary>
        /// The ID qualifier for the function. This is used to specify which input field a function is associated with for &#x60;PRE_FETCH_OPTIONS&#x60; and &#x60;POST_FETCH_OPTIONS&#x60; function types.
        /// </summary>
        /// <value>The ID qualifier for the function. This is used to specify which input field a function is associated with for &#x60;PRE_FETCH_OPTIONS&#x60; and &#x60;POST_FETCH_OPTIONS&#x60; function types.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActionFunction {\n");
            sb.Append("  FunctionSource: ").Append(FunctionSource).Append("\n");
            sb.Append("  FunctionType: ").Append(FunctionType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ActionFunction);
        }

        /// <summary>
        /// Returns true if ActionFunction instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionFunction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FunctionSource == input.FunctionSource ||
                    (this.FunctionSource != null &&
                    this.FunctionSource.Equals(input.FunctionSource))
                ) && 
                (
                    this.FunctionType == input.FunctionType ||
                    this.FunctionType.Equals(input.FunctionType)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.FunctionSource != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionSource.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FunctionType.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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