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
    /// An object detailing a summary of the import record outputs
    /// </summary>
    [DataContract(Name = "PublicImportMetadata")]
    public partial class PublicImportMetadata : IEquatable<PublicImportMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicImportMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicImportMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicImportMetadata" /> class.
        /// </summary>
        /// <param name="objectLists">The lists containing the imported objects. (required).</param>
        /// <param name="counters">Summarized outcomes of each row a developer attempted to import into HubSpot. (required).</param>
        /// <param name="fileIds">The IDs of files uploaded in the File Manager API. (required).</param>
        public PublicImportMetadata(List<PublicObjectListRecord> objectLists = default(List<PublicObjectListRecord>), Dictionary<string, int> counters = default(Dictionary<string, int>), List<string> fileIds = default(List<string>))
        {
            // to ensure "objectLists" is required (not null)
            if (objectLists == null) {
                throw new ArgumentNullException("objectLists is a required property for PublicImportMetadata and cannot be null");
            }
            this.ObjectLists = objectLists;
            // to ensure "counters" is required (not null)
            if (counters == null) {
                throw new ArgumentNullException("counters is a required property for PublicImportMetadata and cannot be null");
            }
            this.Counters = counters;
            // to ensure "fileIds" is required (not null)
            if (fileIds == null) {
                throw new ArgumentNullException("fileIds is a required property for PublicImportMetadata and cannot be null");
            }
            this.FileIds = fileIds;
        }

        /// <summary>
        /// The lists containing the imported objects.
        /// </summary>
        /// <value>The lists containing the imported objects.</value>
        [DataMember(Name = "objectLists", IsRequired = true, EmitDefaultValue = false)]
        public List<PublicObjectListRecord> ObjectLists { get; set; }

        /// <summary>
        /// Summarized outcomes of each row a developer attempted to import into HubSpot.
        /// </summary>
        /// <value>Summarized outcomes of each row a developer attempted to import into HubSpot.</value>
        [DataMember(Name = "counters", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, int> Counters { get; set; }

        /// <summary>
        /// The IDs of files uploaded in the File Manager API.
        /// </summary>
        /// <value>The IDs of files uploaded in the File Manager API.</value>
        [DataMember(Name = "fileIds", IsRequired = true, EmitDefaultValue = false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicImportMetadata {\n");
            sb.Append("  ObjectLists: ").Append(ObjectLists).Append("\n");
            sb.Append("  Counters: ").Append(Counters).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
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
            return this.Equals(input as PublicImportMetadata);
        }

        /// <summary>
        /// Returns true if PublicImportMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicImportMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicImportMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectLists == input.ObjectLists ||
                    this.ObjectLists != null &&
                    input.ObjectLists != null &&
                    this.ObjectLists.SequenceEqual(input.ObjectLists)
                ) && 
                (
                    this.Counters == input.Counters ||
                    this.Counters != null &&
                    input.Counters != null &&
                    this.Counters.SequenceEqual(input.Counters)
                ) && 
                (
                    this.FileIds == input.FileIds ||
                    this.FileIds != null &&
                    input.FileIds != null &&
                    this.FileIds.SequenceEqual(input.FileIds)
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
                if (this.ObjectLists != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectLists.GetHashCode();
                }
                if (this.Counters != null)
                {
                    hashCode = (hashCode * 59) + this.Counters.GetHashCode();
                }
                if (this.FileIds != null)
                {
                    hashCode = (hashCode * 59) + this.FileIds.GetHashCode();
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