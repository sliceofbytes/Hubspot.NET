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
    /// The indexed data in HubSpot
    /// </summary>
    [DataContract(Name = "IndexedData")]
    public partial class IndexedData : IEquatable<IndexedData>, IValidatableObject
    {
        /// <summary>
        /// The type of document. Can be &#x60;SITE_PAGE&#x60;, &#x60;LANDING_PAGE&#x60;, &#x60;BLOG_POST&#x60;, &#x60;LISTING_PAGE&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;.
        /// </summary>
        /// <value>The type of document. Can be &#x60;SITE_PAGE&#x60;, &#x60;LANDING_PAGE&#x60;, &#x60;BLOG_POST&#x60;, &#x60;LISTING_PAGE&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum LANDINGPAGE for value: LANDING_PAGE
            /// </summary>
            [EnumMember(Value = "LANDING_PAGE")]
            LANDINGPAGE = 1,

            /// <summary>
            /// Enum BLOGPOST for value: BLOG_POST
            /// </summary>
            [EnumMember(Value = "BLOG_POST")]
            BLOGPOST = 2,

            /// <summary>
            /// Enum SITEPAGE for value: SITE_PAGE
            /// </summary>
            [EnumMember(Value = "SITE_PAGE")]
            SITEPAGE = 3,

            /// <summary>
            /// Enum KNOWLEDGEARTICLE for value: KNOWLEDGE_ARTICLE
            /// </summary>
            [EnumMember(Value = "KNOWLEDGE_ARTICLE")]
            KNOWLEDGEARTICLE = 4,

            /// <summary>
            /// Enum LISTINGPAGE for value: LISTING_PAGE
            /// </summary>
            [EnumMember(Value = "LISTING_PAGE")]
            LISTINGPAGE = 5

        }


        /// <summary>
        /// The type of document. Can be &#x60;SITE_PAGE&#x60;, &#x60;LANDING_PAGE&#x60;, &#x60;BLOG_POST&#x60;, &#x60;LISTING_PAGE&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;.
        /// </summary>
        /// <value>The type of document. Can be &#x60;SITE_PAGE&#x60;, &#x60;LANDING_PAGE&#x60;, &#x60;BLOG_POST&#x60;, &#x60;LISTING_PAGE&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndexedData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedData" /> class.
        /// </summary>
        /// <param name="id">The ID of the document in HubSpot. (required).</param>
        /// <param name="type">The type of document. Can be &#x60;SITE_PAGE&#x60;, &#x60;LANDING_PAGE&#x60;, &#x60;BLOG_POST&#x60;, &#x60;LISTING_PAGE&#x60;, or &#x60;KNOWLEDGE_ARTICLE&#x60;. (required).</param>
        /// <param name="fields">The indexed fields in HubSpot. (required).</param>
        public IndexedData(string id = default(string), TypeEnum type = default(TypeEnum), Dictionary<string, SearchHitField> fields = default(Dictionary<string, SearchHitField>))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for IndexedData and cannot be null");
            }
            this.Id = id;
            this.Type = type;
            // to ensure "fields" is required (not null)
            if (fields == null) {
                throw new ArgumentNullException("fields is a required property for IndexedData and cannot be null");
            }
            this.Fields = fields;
        }

        /// <summary>
        /// The ID of the document in HubSpot.
        /// </summary>
        /// <value>The ID of the document in HubSpot.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The indexed fields in HubSpot.
        /// </summary>
        /// <value>The indexed fields in HubSpot.</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, SearchHitField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndexedData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as IndexedData);
        }

        /// <summary>
        /// Returns true if IndexedData instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexedData input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
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
