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
    /// A revision of this custom action.
    /// </summary>
    [DataContract(Name = "ActionRevision")]
    public partial class ActionRevision : IEquatable<ActionRevision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRevision" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionRevision() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRevision" /> class.
        /// </summary>
        /// <param name="definition">definition (required).</param>
        /// <param name="createdAt">The date the revision was created. (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="revisionId">The version number of the custom action. (required).</param>
        public ActionRevision(ExtensionActionDefinition definition = default(ExtensionActionDefinition), DateTimeOffset createdAt = default(DateTimeOffset), string id = default(string), string revisionId = default(string))
        {
            // to ensure "definition" is required (not null)
            if (definition == null) {
                throw new ArgumentNullException("definition is a required property for ActionRevision and cannot be null");
            }
            this.Definition = definition;
            this.CreatedAt = createdAt;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ActionRevision and cannot be null");
            }
            this.Id = id;
            // to ensure "revisionId" is required (not null)
            if (revisionId == null) {
                throw new ArgumentNullException("revisionId is a required property for ActionRevision and cannot be null");
            }
            this.RevisionId = revisionId;
        }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name = "definition", IsRequired = true, EmitDefaultValue = false)]
        public ExtensionActionDefinition Definition { get; set; }

        /// <summary>
        /// The date the revision was created.
        /// </summary>
        /// <value>The date the revision was created.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The version number of the custom action.
        /// </summary>
        /// <value>The version number of the custom action.</value>
        [DataMember(Name = "revisionId", IsRequired = true, EmitDefaultValue = false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActionRevision {\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RevisionId: ").Append(RevisionId).Append("\n");
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
            return this.Equals(input as ActionRevision);
        }

        /// <summary>
        /// Returns true if ActionRevision instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionRevision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionRevision input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RevisionId == input.RevisionId ||
                    (this.RevisionId != null &&
                    this.RevisionId.Equals(input.RevisionId))
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
                if (this.Definition != null)
                {
                    hashCode = (hashCode * 59) + this.Definition.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.RevisionId != null)
                {
                    hashCode = (hashCode * 59) + this.RevisionId.GetHashCode();
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
