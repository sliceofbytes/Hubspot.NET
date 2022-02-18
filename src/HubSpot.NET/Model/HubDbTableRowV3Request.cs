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
    /// HubDbTableRowV3Request
    /// </summary>
    [DataContract(Name = "HubDbTableRowV3Request")]
    public partial class HubDbTableRowV3Request : IEquatable<HubDbTableRowV3Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubDbTableRowV3Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HubDbTableRowV3Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HubDbTableRowV3Request" /> class.
        /// </summary>
        /// <param name="path">Specifies the value for &#x60;hs_path&#x60; column, which will be used as slug in the dynamic pages.</param>
        /// <param name="name">Specifies the value for &#x60;hs_name&#x60; column, which will be used as title in the dynamic pages.</param>
        /// <param name="childTableId">Specifies the value for the column child table id.</param>
        /// <param name="values">List of key value pairs with the column name and column value (required).</param>
        public HubDbTableRowV3Request(string path = default(string), string name = default(string), int childTableId = default(int), Dictionary<string, Object> values = default(Dictionary<string, Object>))
        {
            // to ensure "values" is required (not null)
            if (values == null) {
                throw new ArgumentNullException("values is a required property for HubDbTableRowV3Request and cannot be null");
            }
            this.Values = values;
            this.Path = path;
            this.Name = name;
            this.ChildTableId = childTableId;
        }

        /// <summary>
        /// Specifies the value for &#x60;hs_path&#x60; column, which will be used as slug in the dynamic pages
        /// </summary>
        /// <value>Specifies the value for &#x60;hs_path&#x60; column, which will be used as slug in the dynamic pages</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Specifies the value for &#x60;hs_name&#x60; column, which will be used as title in the dynamic pages
        /// </summary>
        /// <value>Specifies the value for &#x60;hs_name&#x60; column, which will be used as title in the dynamic pages</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the value for the column child table id
        /// </summary>
        /// <value>Specifies the value for the column child table id</value>
        [DataMember(Name = "childTableId", EmitDefaultValue = false)]
        public int ChildTableId { get; set; }

        /// <summary>
        /// List of key value pairs with the column name and column value
        /// </summary>
        /// <value>List of key value pairs with the column name and column value</value>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HubDbTableRowV3Request {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChildTableId: ").Append(ChildTableId).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as HubDbTableRowV3Request);
        }

        /// <summary>
        /// Returns true if HubDbTableRowV3Request instances are equal
        /// </summary>
        /// <param name="input">Instance of HubDbTableRowV3Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HubDbTableRowV3Request input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ChildTableId == input.ChildTableId ||
                    this.ChildTableId.Equals(input.ChildTableId)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChildTableId.GetHashCode();
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
