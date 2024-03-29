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
    /// Request body object for setting a new primary language.
    /// </summary>
    [DataContract(Name = "SetNewLanguagePrimaryRequestVNext")]
    public partial class SetNewLanguagePrimaryRequestVNext : IEquatable<SetNewLanguagePrimaryRequestVNext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetNewLanguagePrimaryRequestVNext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetNewLanguagePrimaryRequestVNext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetNewLanguagePrimaryRequestVNext" /> class.
        /// </summary>
        /// <param name="id">ID of object to set as primary in multi-language group. (required).</param>
        public SetNewLanguagePrimaryRequestVNext(string id = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for SetNewLanguagePrimaryRequestVNext and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// ID of object to set as primary in multi-language group.
        /// </summary>
        /// <value>ID of object to set as primary in multi-language group.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetNewLanguagePrimaryRequestVNext {\n");
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
            return this.Equals(input as SetNewLanguagePrimaryRequestVNext);
        }

        /// <summary>
        /// Returns true if SetNewLanguagePrimaryRequestVNext instances are equal
        /// </summary>
        /// <param name="input">Instance of SetNewLanguagePrimaryRequestVNext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetNewLanguagePrimaryRequestVNext input)
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
