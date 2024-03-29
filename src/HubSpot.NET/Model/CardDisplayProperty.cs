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
    /// Definition for a card display property.
    /// </summary>
    [DataContract(Name = "CardDisplayProperty")]
    public partial class CardDisplayProperty : IEquatable<CardDisplayProperty>, IValidatableObject
    {
        /// <summary>
        /// Type of data represented by this property.
        /// </summary>
        /// <value>Type of data represented by this property.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataTypeEnum
        {
            /// <summary>
            /// Enum BOOLEAN for value: BOOLEAN
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN = 1,

            /// <summary>
            /// Enum CURRENCY for value: CURRENCY
            /// </summary>
            [EnumMember(Value = "CURRENCY")]
            CURRENCY = 2,

            /// <summary>
            /// Enum DATE for value: DATE
            /// </summary>
            [EnumMember(Value = "DATE")]
            DATE = 3,

            /// <summary>
            /// Enum DATETIME for value: DATETIME
            /// </summary>
            [EnumMember(Value = "DATETIME")]
            DATETIME = 4,

            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL = 5,

            /// <summary>
            /// Enum LINK for value: LINK
            /// </summary>
            [EnumMember(Value = "LINK")]
            LINK = 6,

            /// <summary>
            /// Enum NUMERIC for value: NUMERIC
            /// </summary>
            [EnumMember(Value = "NUMERIC")]
            NUMERIC = 7,

            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 8,

            /// <summary>
            /// Enum STATUS for value: STATUS
            /// </summary>
            [EnumMember(Value = "STATUS")]
            STATUS = 9

        }


        /// <summary>
        /// Type of data represented by this property.
        /// </summary>
        /// <value>Type of data represented by this property.</value>
        [DataMember(Name = "dataType", IsRequired = true, EmitDefaultValue = false)]
        public DataTypeEnum DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDisplayProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardDisplayProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDisplayProperty" /> class.
        /// </summary>
        /// <param name="name">An internal identifier for this property. This value must be unique TODO. (required).</param>
        /// <param name="label">The label for this property as you&#39;d like it displayed to users. (required).</param>
        /// <param name="dataType">Type of data represented by this property. (required).</param>
        /// <param name="options">An array of available options that can be displayed. Only used in when &#x60;dataType&#x60; is &#x60;STATUS&#x60;. (required).</param>
        public CardDisplayProperty(string name = default(string), string label = default(string), DataTypeEnum dataType = default(DataTypeEnum), List<DisplayOption> options = default(List<DisplayOption>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CardDisplayProperty and cannot be null");
            }
            this.Name = name;
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for CardDisplayProperty and cannot be null");
            }
            this.Label = label;
            this.DataType = dataType;
            // to ensure "options" is required (not null)
            if (options == null) {
                throw new ArgumentNullException("options is a required property for CardDisplayProperty and cannot be null");
            }
            this.Options = options;
        }

        /// <summary>
        /// An internal identifier for this property. This value must be unique TODO.
        /// </summary>
        /// <value>An internal identifier for this property. This value must be unique TODO.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The label for this property as you&#39;d like it displayed to users.
        /// </summary>
        /// <value>The label for this property as you&#39;d like it displayed to users.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// An array of available options that can be displayed. Only used in when &#x60;dataType&#x60; is &#x60;STATUS&#x60;.
        /// </summary>
        /// <value>An array of available options that can be displayed. Only used in when &#x60;dataType&#x60; is &#x60;STATUS&#x60;.</value>
        [DataMember(Name = "options", IsRequired = true, EmitDefaultValue = false)]
        public List<DisplayOption> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardDisplayProperty {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as CardDisplayProperty);
        }

        /// <summary>
        /// Returns true if CardDisplayProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of CardDisplayProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardDisplayProperty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
