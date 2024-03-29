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
    /// Column
    /// </summary>
    [DataContract(Name = "Column")]
    public partial class Column : IEquatable<Column>, IValidatableObject
    {
        /// <summary>
        /// Type of the column
        /// </summary>
        /// <value>Type of the column</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NULL for value: NULL
            /// </summary>
            [EnumMember(Value = "NULL")]
            NULL = 1,

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            [EnumMember(Value = "TEXT")]
            TEXT = 2,

            /// <summary>
            /// Enum NUMBER for value: NUMBER
            /// </summary>
            [EnumMember(Value = "NUMBER")]
            NUMBER = 3,

            /// <summary>
            /// Enum URL for value: URL
            /// </summary>
            [EnumMember(Value = "URL")]
            URL = 4,

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            [EnumMember(Value = "IMAGE")]
            IMAGE = 5,

            /// <summary>
            /// Enum SELECT for value: SELECT
            /// </summary>
            [EnumMember(Value = "SELECT")]
            SELECT = 6,

            /// <summary>
            /// Enum MULTISELECT for value: MULTISELECT
            /// </summary>
            [EnumMember(Value = "MULTISELECT")]
            MULTISELECT = 7,

            /// <summary>
            /// Enum BOOLEAN for value: BOOLEAN
            /// </summary>
            [EnumMember(Value = "BOOLEAN")]
            BOOLEAN = 8,

            /// <summary>
            /// Enum LOCATION for value: LOCATION
            /// </summary>
            [EnumMember(Value = "LOCATION")]
            LOCATION = 9,

            /// <summary>
            /// Enum DATE for value: DATE
            /// </summary>
            [EnumMember(Value = "DATE")]
            DATE = 10,

            /// <summary>
            /// Enum DATETIME for value: DATETIME
            /// </summary>
            [EnumMember(Value = "DATETIME")]
            DATETIME = 11,

            /// <summary>
            /// Enum CURRENCY for value: CURRENCY
            /// </summary>
            [EnumMember(Value = "CURRENCY")]
            CURRENCY = 12,

            /// <summary>
            /// Enum RICHTEXT for value: RICHTEXT
            /// </summary>
            [EnumMember(Value = "RICHTEXT")]
            RICHTEXT = 13,

            /// <summary>
            /// Enum FOREIGNID for value: FOREIGN_ID
            /// </summary>
            [EnumMember(Value = "FOREIGN_ID")]
            FOREIGNID = 14,

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            VIDEO = 15,

            /// <summary>
            /// Enum CTA for value: CTA
            /// </summary>
            [EnumMember(Value = "CTA")]
            CTA = 16

        }


        /// <summary>
        /// Type of the column
        /// </summary>
        /// <value>Type of the column</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Column() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        /// <param name="name">Name of the column (required).</param>
        /// <param name="label">Label of the column (required).</param>
        /// <param name="id">Column Id.</param>
        /// <param name="width">Column width for HubDB UI.</param>
        /// <param name="foreignTableId">Foreign table id referenced.</param>
        /// <param name="foreignColumnId">Foreign Column id.</param>
        /// <param name="foreignIds">Foreign Ids.</param>
        /// <param name="foreignIdsById">Foreign ids.</param>
        /// <param name="foreignIdsByName">Foreign ids by name.</param>
        /// <param name="type">Type of the column (required).</param>
        /// <param name="optionCount">Number of options available.</param>
        /// <param name="archived">Specifies whether the column is archived.</param>
        /// <param name="options">Options to choose for select and multi-select columns.</param>
        public Column(string name = default(string), string label = default(string), string id = default(string), int width = default(int), long foreignTableId = default(long), int foreignColumnId = default(int), List<ForeignId> foreignIds = default(List<ForeignId>), Dictionary<string, ForeignId> foreignIdsById = default(Dictionary<string, ForeignId>), Dictionary<string, ForeignId> foreignIdsByName = default(Dictionary<string, ForeignId>), TypeEnum type = default(TypeEnum), int optionCount = default(int), bool archived = default(bool), List<Option> options = default(List<Option>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Column and cannot be null");
            }
            this.Name = name;
            // to ensure "label" is required (not null)
            if (label == null) {
                throw new ArgumentNullException("label is a required property for Column and cannot be null");
            }
            this.Label = label;
            this.Type = type;
            this.Id = id;
            this.Width = width;
            this.ForeignTableId = foreignTableId;
            this.ForeignColumnId = foreignColumnId;
            this.ForeignIds = foreignIds;
            this.ForeignIdsById = foreignIdsById;
            this.ForeignIdsByName = foreignIdsByName;
            this.OptionCount = optionCount;
            this.Archived = archived;
            this.Options = options;
        }

        /// <summary>
        /// Name of the column
        /// </summary>
        /// <value>Name of the column</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Label of the column
        /// </summary>
        /// <value>Label of the column</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Column Id
        /// </summary>
        /// <value>Column Id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Column width for HubDB UI
        /// </summary>
        /// <value>Column width for HubDB UI</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Foreign table id referenced
        /// </summary>
        /// <value>Foreign table id referenced</value>
        [DataMember(Name = "foreignTableId", EmitDefaultValue = false)]
        public long ForeignTableId { get; set; }

        /// <summary>
        /// Foreign Column id
        /// </summary>
        /// <value>Foreign Column id</value>
        [DataMember(Name = "foreignColumnId", EmitDefaultValue = false)]
        public int ForeignColumnId { get; set; }

        /// <summary>
        /// Foreign Ids
        /// </summary>
        /// <value>Foreign Ids</value>
        [DataMember(Name = "foreignIds", EmitDefaultValue = false)]
        public List<ForeignId> ForeignIds { get; set; }

        /// <summary>
        /// Foreign ids
        /// </summary>
        /// <value>Foreign ids</value>
        [DataMember(Name = "foreignIdsById", EmitDefaultValue = false)]
        public Dictionary<string, ForeignId> ForeignIdsById { get; set; }

        /// <summary>
        /// Foreign ids by name
        /// </summary>
        /// <value>Foreign ids by name</value>
        [DataMember(Name = "foreignIdsByName", EmitDefaultValue = false)]
        public Dictionary<string, ForeignId> ForeignIdsByName { get; set; }

        /// <summary>
        /// Number of options available
        /// </summary>
        /// <value>Number of options available</value>
        [DataMember(Name = "optionCount", EmitDefaultValue = false)]
        public int OptionCount { get; set; }

        /// <summary>
        /// Specifies whether the column is archived
        /// </summary>
        /// <value>Specifies whether the column is archived</value>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Options to choose for select and multi-select columns
        /// </summary>
        /// <value>Options to choose for select and multi-select columns</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<Option> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Column {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  ForeignTableId: ").Append(ForeignTableId).Append("\n");
            sb.Append("  ForeignColumnId: ").Append(ForeignColumnId).Append("\n");
            sb.Append("  ForeignIds: ").Append(ForeignIds).Append("\n");
            sb.Append("  ForeignIdsById: ").Append(ForeignIdsById).Append("\n");
            sb.Append("  ForeignIdsByName: ").Append(ForeignIdsByName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OptionCount: ").Append(OptionCount).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
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
            return this.Equals(input as Column);
        }

        /// <summary>
        /// Returns true if Column instances are equal
        /// </summary>
        /// <param name="input">Instance of Column to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Column input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.ForeignTableId == input.ForeignTableId ||
                    this.ForeignTableId.Equals(input.ForeignTableId)
                ) && 
                (
                    this.ForeignColumnId == input.ForeignColumnId ||
                    this.ForeignColumnId.Equals(input.ForeignColumnId)
                ) && 
                (
                    this.ForeignIds == input.ForeignIds ||
                    this.ForeignIds != null &&
                    input.ForeignIds != null &&
                    this.ForeignIds.SequenceEqual(input.ForeignIds)
                ) && 
                (
                    this.ForeignIdsById == input.ForeignIdsById ||
                    this.ForeignIdsById != null &&
                    input.ForeignIdsById != null &&
                    this.ForeignIdsById.SequenceEqual(input.ForeignIdsById)
                ) && 
                (
                    this.ForeignIdsByName == input.ForeignIdsByName ||
                    this.ForeignIdsByName != null &&
                    input.ForeignIdsByName != null &&
                    this.ForeignIdsByName.SequenceEqual(input.ForeignIdsByName)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.OptionCount == input.OptionCount ||
                    this.OptionCount.Equals(input.OptionCount)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.ForeignTableId.GetHashCode();
                hashCode = (hashCode * 59) + this.ForeignColumnId.GetHashCode();
                if (this.ForeignIds != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignIds.GetHashCode();
                }
                if (this.ForeignIdsById != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignIdsById.GetHashCode();
                }
                if (this.ForeignIdsByName != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignIdsByName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.OptionCount.GetHashCode();
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
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
