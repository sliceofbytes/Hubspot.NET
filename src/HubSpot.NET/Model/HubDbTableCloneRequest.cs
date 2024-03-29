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
    /// HubDbTableCloneRequest
    /// </summary>
    [DataContract(Name = "HubDbTableCloneRequest")]
    public partial class HubDbTableCloneRequest : IEquatable<HubDbTableCloneRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubDbTableCloneRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HubDbTableCloneRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HubDbTableCloneRequest" /> class.
        /// </summary>
        /// <param name="newName">The new name for the cloned table.</param>
        /// <param name="newLabel">The new label for the cloned table.</param>
        /// <param name="copyRows">Specifies whether to copy the rows during clone (required).</param>
        public HubDbTableCloneRequest(string newName = default(string), string newLabel = default(string), bool copyRows = default(bool))
        {
            this.CopyRows = copyRows;
            this.NewName = newName;
            this.NewLabel = newLabel;
        }

        /// <summary>
        /// The new name for the cloned table
        /// </summary>
        /// <value>The new name for the cloned table</value>
        [DataMember(Name = "newName", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// The new label for the cloned table
        /// </summary>
        /// <value>The new label for the cloned table</value>
        [DataMember(Name = "newLabel", EmitDefaultValue = false)]
        public string NewLabel { get; set; }

        /// <summary>
        /// Specifies whether to copy the rows during clone
        /// </summary>
        /// <value>Specifies whether to copy the rows during clone</value>
        [DataMember(Name = "copyRows", IsRequired = true, EmitDefaultValue = true)]
        public bool CopyRows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HubDbTableCloneRequest {\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  NewLabel: ").Append(NewLabel).Append("\n");
            sb.Append("  CopyRows: ").Append(CopyRows).Append("\n");
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
            return this.Equals(input as HubDbTableCloneRequest);
        }

        /// <summary>
        /// Returns true if HubDbTableCloneRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HubDbTableCloneRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HubDbTableCloneRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
                ) && 
                (
                    this.NewLabel == input.NewLabel ||
                    (this.NewLabel != null &&
                    this.NewLabel.Equals(input.NewLabel))
                ) && 
                (
                    this.CopyRows == input.CopyRows ||
                    this.CopyRows.Equals(input.CopyRows)
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
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
                }
                if (this.NewLabel != null)
                {
                    hashCode = (hashCode * 59) + this.NewLabel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CopyRows.GetHashCode();
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
