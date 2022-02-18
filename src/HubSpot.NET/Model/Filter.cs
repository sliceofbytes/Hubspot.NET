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
    /// Filter
    /// </summary>
    [DataContract(Name = "Filter")]
    public partial class Filter : IEquatable<Filter>, IValidatableObject
    {
        /// <summary>
        /// null
        /// </summary>
        /// <value>null</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum EQ for value: EQ
            /// </summary>
            [EnumMember(Value = "EQ")]
            EQ = 1,

            /// <summary>
            /// Enum NEQ for value: NEQ
            /// </summary>
            [EnumMember(Value = "NEQ")]
            NEQ = 2,

            /// <summary>
            /// Enum LT for value: LT
            /// </summary>
            [EnumMember(Value = "LT")]
            LT = 3,

            /// <summary>
            /// Enum LTE for value: LTE
            /// </summary>
            [EnumMember(Value = "LTE")]
            LTE = 4,

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            [EnumMember(Value = "GT")]
            GT = 5,

            /// <summary>
            /// Enum GTE for value: GTE
            /// </summary>
            [EnumMember(Value = "GTE")]
            GTE = 6,

            /// <summary>
            /// Enum BETWEEN for value: BETWEEN
            /// </summary>
            [EnumMember(Value = "BETWEEN")]
            BETWEEN = 7,

            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 8,

            /// <summary>
            /// Enum NOTIN for value: NOT_IN
            /// </summary>
            [EnumMember(Value = "NOT_IN")]
            NOTIN = 9,

            /// <summary>
            /// Enum HASPROPERTY for value: HAS_PROPERTY
            /// </summary>
            [EnumMember(Value = "HAS_PROPERTY")]
            HASPROPERTY = 10,

            /// <summary>
            /// Enum NOTHASPROPERTY for value: NOT_HAS_PROPERTY
            /// </summary>
            [EnumMember(Value = "NOT_HAS_PROPERTY")]
            NOTHASPROPERTY = 11,

            /// <summary>
            /// Enum CONTAINSTOKEN for value: CONTAINS_TOKEN
            /// </summary>
            [EnumMember(Value = "CONTAINS_TOKEN")]
            CONTAINSTOKEN = 12,

            /// <summary>
            /// Enum NOTCONTAINSTOKEN for value: NOT_CONTAINS_TOKEN
            /// </summary>
            [EnumMember(Value = "NOT_CONTAINS_TOKEN")]
            NOTCONTAINSTOKEN = 13

        }


        /// <summary>
        /// null
        /// </summary>
        /// <value>null</value>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = false)]
        public OperatorEnum Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Filter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="propertyName">propertyName (required).</param>
        /// <param name="_operator">null (required).</param>
        public Filter(string value = default(string), string propertyName = default(string), OperatorEnum _operator = default(OperatorEnum))
        {
            // to ensure "propertyName" is required (not null)
            if (propertyName == null) {
                throw new ArgumentNullException("propertyName is a required property for Filter and cannot be null");
            }
            this.PropertyName = propertyName;
            this.Operator = _operator;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name = "propertyName", IsRequired = true, EmitDefaultValue = false)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(input as Filter);
        }

        /// <summary>
        /// Returns true if Filter instances are equal
        /// </summary>
        /// <param name="input">Instance of Filter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.PropertyName == input.PropertyName ||
                    (this.PropertyName != null &&
                    this.PropertyName.Equals(input.PropertyName))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.PropertyName != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
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
