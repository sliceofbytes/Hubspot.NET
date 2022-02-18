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
    /// HubDbTableRowV3
    /// </summary>
    [DataContract(Name = "HubDbTableRowV3")]
    public partial class HubDbTableRowV3 : IEquatable<HubDbTableRowV3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubDbTableRowV3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HubDbTableRowV3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HubDbTableRowV3" /> class.
        /// </summary>
        /// <param name="id">The id of the table row.</param>
        /// <param name="path">Specifies the value for &#x60;hs_path&#x60; column, which will be used as slug in the dynamic pages.</param>
        /// <param name="name">Specifies the value for &#x60;hs_name&#x60; column, which will be used as title in the dynamic pages.</param>
        /// <param name="createdAt">Timestamp at which the row is created.</param>
        /// <param name="updatedAt">Timestamp at which the row is updated last time.</param>
        /// <param name="childTableId">Specifies the value for the column child table id.</param>
        /// <param name="values">List of key value pairs with the column name and column value (required).</param>
        public HubDbTableRowV3(string id = default(string), string path = default(string), string name = default(string), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), string childTableId = default(string), Dictionary<string, Object> values = default(Dictionary<string, Object>))
        {
            // to ensure "values" is required (not null)
            if (values == null) {
                throw new ArgumentNullException("values is a required property for HubDbTableRowV3 and cannot be null");
            }
            this.Values = values;
            this.Id = id;
            this.Path = path;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ChildTableId = childTableId;
        }

        /// <summary>
        /// The id of the table row
        /// </summary>
        /// <value>The id of the table row</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
        /// Timestamp at which the row is created
        /// </summary>
        /// <value>Timestamp at which the row is created</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp at which the row is updated last time
        /// </summary>
        /// <value>Timestamp at which the row is updated last time</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Specifies the value for the column child table id
        /// </summary>
        /// <value>Specifies the value for the column child table id</value>
        [DataMember(Name = "childTableId", EmitDefaultValue = false)]
        public string ChildTableId { get; set; }

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
            sb.Append("class HubDbTableRowV3 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as HubDbTableRowV3);
        }

        /// <summary>
        /// Returns true if HubDbTableRowV3 instances are equal
        /// </summary>
        /// <param name="input">Instance of HubDbTableRowV3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HubDbTableRowV3 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ChildTableId == input.ChildTableId ||
                    (this.ChildTableId != null &&
                    this.ChildTableId.Equals(input.ChildTableId))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.ChildTableId != null)
                {
                    hashCode = (hashCode * 59) + this.ChildTableId.GetHashCode();
                }
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