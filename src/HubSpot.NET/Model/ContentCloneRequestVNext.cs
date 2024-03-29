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
    /// Request body object for cloning content.
    /// </summary>
    [DataContract(Name = "ContentCloneRequestVNext")]
    public partial class ContentCloneRequestVNext : IEquatable<ContentCloneRequestVNext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentCloneRequestVNext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentCloneRequestVNext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentCloneRequestVNext" /> class.
        /// </summary>
        /// <param name="id">ID of the object to be cloned. (required).</param>
        /// <param name="cloneName">Name of the cloned object..</param>
        public ContentCloneRequestVNext(string id = default(string), string cloneName = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ContentCloneRequestVNext and cannot be null");
            }
            this.Id = id;
            this.CloneName = cloneName;
        }

        /// <summary>
        /// ID of the object to be cloned.
        /// </summary>
        /// <value>ID of the object to be cloned.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the cloned object.
        /// </summary>
        /// <value>Name of the cloned object.</value>
        [DataMember(Name = "cloneName", EmitDefaultValue = false)]
        public string CloneName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentCloneRequestVNext {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CloneName: ").Append(CloneName).Append("\n");
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
            return this.Equals(input as ContentCloneRequestVNext);
        }

        /// <summary>
        /// Returns true if ContentCloneRequestVNext instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentCloneRequestVNext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentCloneRequestVNext input)
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
                    this.CloneName == input.CloneName ||
                    (this.CloneName != null &&
                    this.CloneName.Equals(input.CloneName))
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
                if (this.CloneName != null)
                {
                    hashCode = (hashCode * 59) + this.CloneName.GetHashCode();
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
