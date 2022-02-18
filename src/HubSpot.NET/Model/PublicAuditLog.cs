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
    /// PublicAuditLog
    /// </summary>
    [DataContract(Name = "PublicAuditLog")]
    public partial class PublicAuditLog : IEquatable<PublicAuditLog>, IValidatableObject
    {
        /// <summary>
        /// The type of event that took place (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED).
        /// </summary>
        /// <value>The type of event that took place (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED = 1,

            /// <summary>
            /// Enum UPDATED for value: UPDATED
            /// </summary>
            [EnumMember(Value = "UPDATED")]
            UPDATED = 2,

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            [EnumMember(Value = "PUBLISHED")]
            PUBLISHED = 3,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 4,

            /// <summary>
            /// Enum UNPUBLISHED for value: UNPUBLISHED
            /// </summary>
            [EnumMember(Value = "UNPUBLISHED")]
            UNPUBLISHED = 5

        }


        /// <summary>
        /// The type of event that took place (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED).
        /// </summary>
        /// <value>The type of event that took place (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED).</value>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = false)]
        public EventEnum Event { get; set; }
        /// <summary>
        /// The type of the object (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.)
        /// </summary>
        /// <value>The type of the object (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectTypeEnum
        {
            /// <summary>
            /// Enum BLOG for value: BLOG
            /// </summary>
            [EnumMember(Value = "BLOG")]
            BLOG = 1,

            /// <summary>
            /// Enum BLOGPOST for value: BLOG_POST
            /// </summary>
            [EnumMember(Value = "BLOG_POST")]
            BLOGPOST = 2,

            /// <summary>
            /// Enum LANDINGPAGE for value: LANDING_PAGE
            /// </summary>
            [EnumMember(Value = "LANDING_PAGE")]
            LANDINGPAGE = 3,

            /// <summary>
            /// Enum WEBSITEPAGE for value: WEBSITE_PAGE
            /// </summary>
            [EnumMember(Value = "WEBSITE_PAGE")]
            WEBSITEPAGE = 4,

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            [EnumMember(Value = "TEMPLATE")]
            TEMPLATE = 5,

            /// <summary>
            /// Enum MODULE for value: MODULE
            /// </summary>
            [EnumMember(Value = "MODULE")]
            MODULE = 6,

            /// <summary>
            /// Enum GLOBALMODULE for value: GLOBAL_MODULE
            /// </summary>
            [EnumMember(Value = "GLOBAL_MODULE")]
            GLOBALMODULE = 7,

            /// <summary>
            /// Enum SERVERLESSFUNCTION for value: SERVERLESS_FUNCTION
            /// </summary>
            [EnumMember(Value = "SERVERLESS_FUNCTION")]
            SERVERLESSFUNCTION = 8,

            /// <summary>
            /// Enum DOMAIN for value: DOMAIN
            /// </summary>
            [EnumMember(Value = "DOMAIN")]
            DOMAIN = 9,

            /// <summary>
            /// Enum URLMAPPING for value: URL_MAPPING
            /// </summary>
            [EnumMember(Value = "URL_MAPPING")]
            URLMAPPING = 10,

            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL = 11,

            /// <summary>
            /// Enum CONTENTSETTINGS for value: CONTENT_SETTINGS
            /// </summary>
            [EnumMember(Value = "CONTENT_SETTINGS")]
            CONTENTSETTINGS = 12,

            /// <summary>
            /// Enum HUBDBTABLE for value: HUBDB_TABLE
            /// </summary>
            [EnumMember(Value = "HUBDB_TABLE")]
            HUBDBTABLE = 13,

            /// <summary>
            /// Enum KNOWLEDGEBASEARTICLE for value: KNOWLEDGE_BASE_ARTICLE
            /// </summary>
            [EnumMember(Value = "KNOWLEDGE_BASE_ARTICLE")]
            KNOWLEDGEBASEARTICLE = 14,

            /// <summary>
            /// Enum KNOWLEDGEBASE for value: KNOWLEDGE_BASE
            /// </summary>
            [EnumMember(Value = "KNOWLEDGE_BASE")]
            KNOWLEDGEBASE = 15,

            /// <summary>
            /// Enum THEME for value: THEME
            /// </summary>
            [EnumMember(Value = "THEME")]
            THEME = 16,

            /// <summary>
            /// Enum CSS for value: CSS
            /// </summary>
            [EnumMember(Value = "CSS")]
            CSS = 17,

            /// <summary>
            /// Enum JS for value: JS
            /// </summary>
            [EnumMember(Value = "JS")]
            JS = 18

        }


        /// <summary>
        /// The type of the object (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.)
        /// </summary>
        /// <value>The type of the object (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.)</value>
        [DataMember(Name = "objectType", IsRequired = true, EmitDefaultValue = false)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuditLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicAuditLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuditLog" /> class.
        /// </summary>
        /// <param name="objectId">The ID of the object. (required).</param>
        /// <param name="userId">The ID of the user who caused the event. (required).</param>
        /// <param name="timestamp">The timestamp at which the event occurred. (required).</param>
        /// <param name="objectName">The internal name of the object in HubSpot. (required).</param>
        /// <param name="fullName">The name of the user who caused the event. (required).</param>
        /// <param name="_event">The type of event that took place (CREATED, UPDATED, PUBLISHED, DELETED, UNPUBLISHED). (required).</param>
        /// <param name="objectType">The type of the object (BLOG, LANDING_PAGE, DOMAIN, HUBDB_TABLE etc.) (required).</param>
        public PublicAuditLog(string objectId = default(string), string userId = default(string), DateTimeOffset timestamp = default(DateTimeOffset), string objectName = default(string), string fullName = default(string), EventEnum _event = default(EventEnum), ObjectTypeEnum objectType = default(ObjectTypeEnum))
        {
            // to ensure "objectId" is required (not null)
            if (objectId == null) {
                throw new ArgumentNullException("objectId is a required property for PublicAuditLog and cannot be null");
            }
            this.ObjectId = objectId;
            // to ensure "userId" is required (not null)
            if (userId == null) {
                throw new ArgumentNullException("userId is a required property for PublicAuditLog and cannot be null");
            }
            this.UserId = userId;
            this.Timestamp = timestamp;
            // to ensure "objectName" is required (not null)
            if (objectName == null) {
                throw new ArgumentNullException("objectName is a required property for PublicAuditLog and cannot be null");
            }
            this.ObjectName = objectName;
            // to ensure "fullName" is required (not null)
            if (fullName == null) {
                throw new ArgumentNullException("fullName is a required property for PublicAuditLog and cannot be null");
            }
            this.FullName = fullName;
            this.Event = _event;
            this.ObjectType = objectType;
        }

        /// <summary>
        /// The ID of the object.
        /// </summary>
        /// <value>The ID of the object.</value>
        [DataMember(Name = "objectId", IsRequired = true, EmitDefaultValue = false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// The ID of the user who caused the event.
        /// </summary>
        /// <value>The ID of the user who caused the event.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// The timestamp at which the event occurred.
        /// </summary>
        /// <value>The timestamp at which the event occurred.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The internal name of the object in HubSpot.
        /// </summary>
        /// <value>The internal name of the object in HubSpot.</value>
        [DataMember(Name = "objectName", IsRequired = true, EmitDefaultValue = false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// The name of the user who caused the event.
        /// </summary>
        /// <value>The name of the user who caused the event.</value>
        [DataMember(Name = "fullName", IsRequired = true, EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicAuditLog {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
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
            return this.Equals(input as PublicAuditLog);
        }

        /// <summary>
        /// Returns true if PublicAuditLog instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicAuditLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicAuditLog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ObjectName == input.ObjectName ||
                    (this.ObjectName != null &&
                    this.ObjectName.Equals(input.ObjectName))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Event == input.Event ||
                    this.Event.Equals(input.Event)
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
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
                if (this.ObjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.ObjectName != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectName.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Event.GetHashCode();
                hashCode = (hashCode * 59) + this.ObjectType.GetHashCode();
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
