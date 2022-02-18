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
    /// Defines an object type.
    /// </summary>
    [DataContract(Name = "ObjectTypeDefinition")]
    public partial class ObjectTypeDefinition : IEquatable<ObjectTypeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObjectTypeDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTypeDefinition" /> class.
        /// </summary>
        /// <param name="labels">labels (required).</param>
        /// <param name="requiredProperties">The names of properties that should be **required** when creating an object of this type. (required).</param>
        /// <param name="searchableProperties">Names of properties that will be indexed for this object type in by HubSpot&#39;s product search. (required).</param>
        /// <param name="primaryDisplayProperty">The name of the primary property for this object. This will be displayed as primary on the HubSpot record page for this object type..</param>
        /// <param name="secondaryDisplayProperties">The names of secondary properties for this object. These will be displayed as secondary on the HubSpot record page for this object type. (required).</param>
        /// <param name="archived">archived (required).</param>
        /// <param name="id">A unique ID for this object type. Will be defined as {meta-type}-{unique ID}. (required).</param>
        /// <param name="fullyQualifiedName">fullyQualifiedName (required).</param>
        /// <param name="createdAt">When the object type was created..</param>
        /// <param name="updatedAt">When the object type was last updated..</param>
        /// <param name="objectTypeId">objectTypeId (required).</param>
        /// <param name="name">A unique name for this object. For internal use only. (required).</param>
        /// <param name="portalId">The ID of the account that this object type is specific to..</param>
        public ObjectTypeDefinition(ObjectTypeDefinitionLabels labels = default(ObjectTypeDefinitionLabels), List<string> requiredProperties = default(List<string>), List<string> searchableProperties = default(List<string>), string primaryDisplayProperty = default(string), List<string> secondaryDisplayProperties = default(List<string>), bool archived = default(bool), string id = default(string), string fullyQualifiedName = default(string), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), string objectTypeId = default(string), string name = default(string), int portalId = default(int))
        {
            // to ensure "labels" is required (not null)
            if (labels == null) {
                throw new ArgumentNullException("labels is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.Labels = labels;
            // to ensure "requiredProperties" is required (not null)
            if (requiredProperties == null) {
                throw new ArgumentNullException("requiredProperties is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.RequiredProperties = requiredProperties;
            // to ensure "searchableProperties" is required (not null)
            if (searchableProperties == null) {
                throw new ArgumentNullException("searchableProperties is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.SearchableProperties = searchableProperties;
            // to ensure "secondaryDisplayProperties" is required (not null)
            if (secondaryDisplayProperties == null) {
                throw new ArgumentNullException("secondaryDisplayProperties is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.SecondaryDisplayProperties = secondaryDisplayProperties;
            this.Archived = archived;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.Id = id;
            // to ensure "fullyQualifiedName" is required (not null)
            if (fullyQualifiedName == null) {
                throw new ArgumentNullException("fullyQualifiedName is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.FullyQualifiedName = fullyQualifiedName;
            // to ensure "objectTypeId" is required (not null)
            if (objectTypeId == null) {
                throw new ArgumentNullException("objectTypeId is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.ObjectTypeId = objectTypeId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ObjectTypeDefinition and cannot be null");
            }
            this.Name = name;
            this.PrimaryDisplayProperty = primaryDisplayProperty;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PortalId = portalId;
        }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", IsRequired = true, EmitDefaultValue = false)]
        public ObjectTypeDefinitionLabels Labels { get; set; }

        /// <summary>
        /// The names of properties that should be **required** when creating an object of this type.
        /// </summary>
        /// <value>The names of properties that should be **required** when creating an object of this type.</value>
        [DataMember(Name = "requiredProperties", IsRequired = true, EmitDefaultValue = false)]
        public List<string> RequiredProperties { get; set; }

        /// <summary>
        /// Names of properties that will be indexed for this object type in by HubSpot&#39;s product search.
        /// </summary>
        /// <value>Names of properties that will be indexed for this object type in by HubSpot&#39;s product search.</value>
        [DataMember(Name = "searchableProperties", IsRequired = true, EmitDefaultValue = false)]
        public List<string> SearchableProperties { get; set; }

        /// <summary>
        /// The name of the primary property for this object. This will be displayed as primary on the HubSpot record page for this object type.
        /// </summary>
        /// <value>The name of the primary property for this object. This will be displayed as primary on the HubSpot record page for this object type.</value>
        [DataMember(Name = "primaryDisplayProperty", EmitDefaultValue = false)]
        public string PrimaryDisplayProperty { get; set; }

        /// <summary>
        /// The names of secondary properties for this object. These will be displayed as secondary on the HubSpot record page for this object type.
        /// </summary>
        /// <value>The names of secondary properties for this object. These will be displayed as secondary on the HubSpot record page for this object type.</value>
        [DataMember(Name = "secondaryDisplayProperties", IsRequired = true, EmitDefaultValue = false)]
        public List<string> SecondaryDisplayProperties { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name = "archived", IsRequired = true, EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// A unique ID for this object type. Will be defined as {meta-type}-{unique ID}.
        /// </summary>
        /// <value>A unique ID for this object type. Will be defined as {meta-type}-{unique ID}.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FullyQualifiedName
        /// </summary>
        [DataMember(Name = "fullyQualifiedName", IsRequired = true, EmitDefaultValue = false)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// When the object type was created.
        /// </summary>
        /// <value>When the object type was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// When the object type was last updated.
        /// </summary>
        /// <value>When the object type was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ObjectTypeId
        /// </summary>
        [DataMember(Name = "objectTypeId", IsRequired = true, EmitDefaultValue = false)]
        public string ObjectTypeId { get; set; }

        /// <summary>
        /// A unique name for this object. For internal use only.
        /// </summary>
        /// <value>A unique name for this object. For internal use only.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the account that this object type is specific to.
        /// </summary>
        /// <value>The ID of the account that this object type is specific to.</value>
        [DataMember(Name = "portalId", EmitDefaultValue = false)]
        public int PortalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectTypeDefinition {\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  RequiredProperties: ").Append(RequiredProperties).Append("\n");
            sb.Append("  SearchableProperties: ").Append(SearchableProperties).Append("\n");
            sb.Append("  PrimaryDisplayProperty: ").Append(PrimaryDisplayProperty).Append("\n");
            sb.Append("  SecondaryDisplayProperties: ").Append(SecondaryDisplayProperties).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FullyQualifiedName: ").Append(FullyQualifiedName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ObjectTypeId: ").Append(ObjectTypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
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
            return this.Equals(input as ObjectTypeDefinition);
        }

        /// <summary>
        /// Returns true if ObjectTypeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectTypeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectTypeDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Labels == input.Labels ||
                    (this.Labels != null &&
                    this.Labels.Equals(input.Labels))
                ) && 
                (
                    this.RequiredProperties == input.RequiredProperties ||
                    this.RequiredProperties != null &&
                    input.RequiredProperties != null &&
                    this.RequiredProperties.SequenceEqual(input.RequiredProperties)
                ) && 
                (
                    this.SearchableProperties == input.SearchableProperties ||
                    this.SearchableProperties != null &&
                    input.SearchableProperties != null &&
                    this.SearchableProperties.SequenceEqual(input.SearchableProperties)
                ) && 
                (
                    this.PrimaryDisplayProperty == input.PrimaryDisplayProperty ||
                    (this.PrimaryDisplayProperty != null &&
                    this.PrimaryDisplayProperty.Equals(input.PrimaryDisplayProperty))
                ) && 
                (
                    this.SecondaryDisplayProperties == input.SecondaryDisplayProperties ||
                    this.SecondaryDisplayProperties != null &&
                    input.SecondaryDisplayProperties != null &&
                    this.SecondaryDisplayProperties.SequenceEqual(input.SecondaryDisplayProperties)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FullyQualifiedName == input.FullyQualifiedName ||
                    (this.FullyQualifiedName != null &&
                    this.FullyQualifiedName.Equals(input.FullyQualifiedName))
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
                    this.ObjectTypeId == input.ObjectTypeId ||
                    (this.ObjectTypeId != null &&
                    this.ObjectTypeId.Equals(input.ObjectTypeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PortalId == input.PortalId ||
                    this.PortalId.Equals(input.PortalId)
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
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.RequiredProperties != null)
                {
                    hashCode = (hashCode * 59) + this.RequiredProperties.GetHashCode();
                }
                if (this.SearchableProperties != null)
                {
                    hashCode = (hashCode * 59) + this.SearchableProperties.GetHashCode();
                }
                if (this.PrimaryDisplayProperty != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryDisplayProperty.GetHashCode();
                }
                if (this.SecondaryDisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryDisplayProperties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.FullyQualifiedName != null)
                {
                    hashCode = (hashCode * 59) + this.FullyQualifiedName.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.ObjectTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectTypeId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PortalId.GetHashCode();
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
