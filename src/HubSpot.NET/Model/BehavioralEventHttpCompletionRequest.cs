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
    /// BehavioralEventHttpCompletionRequest
    /// </summary>
    [DataContract(Name = "BehavioralEventHttpCompletionRequest")]
    public partial class BehavioralEventHttpCompletionRequest : IEquatable<BehavioralEventHttpCompletionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BehavioralEventHttpCompletionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BehavioralEventHttpCompletionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BehavioralEventHttpCompletionRequest" /> class.
        /// </summary>
        /// <param name="utk">User token.</param>
        /// <param name="email">Email of visitor.</param>
        /// <param name="eventName">Internal name of the event-type to trigger (required).</param>
        /// <param name="properties">Map of properties for the event in the format property internal name - property value (required).</param>
        /// <param name="occurredAt">The time when this event occurred (if any). If this isn&#39;t set, the current time will be used.</param>
        /// <param name="objectId">The object id that this event occurred on. Could be a contact id or a visitor id..</param>
        public BehavioralEventHttpCompletionRequest(string utk = default(string), string email = default(string), string eventName = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>), DateTimeOffset occurredAt = default(DateTimeOffset), string objectId = default(string))
        {
            // to ensure "eventName" is required (not null)
            if (eventName == null) {
                throw new ArgumentNullException("eventName is a required property for BehavioralEventHttpCompletionRequest and cannot be null");
            }
            this.EventName = eventName;
            // to ensure "properties" is required (not null)
            if (properties == null) {
                throw new ArgumentNullException("properties is a required property for BehavioralEventHttpCompletionRequest and cannot be null");
            }
            this.Properties = properties;
            this.Utk = utk;
            this.Email = email;
            this.OccurredAt = occurredAt;
            this.ObjectId = objectId;
        }

        /// <summary>
        /// User token
        /// </summary>
        /// <value>User token</value>
        [DataMember(Name = "utk", EmitDefaultValue = false)]
        public string Utk { get; set; }

        /// <summary>
        /// Email of visitor
        /// </summary>
        /// <value>Email of visitor</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Internal name of the event-type to trigger
        /// </summary>
        /// <value>Internal name of the event-type to trigger</value>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// Map of properties for the event in the format property internal name - property value
        /// </summary>
        /// <value>Map of properties for the event in the format property internal name - property value</value>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// The time when this event occurred (if any). If this isn&#39;t set, the current time will be used
        /// </summary>
        /// <value>The time when this event occurred (if any). If this isn&#39;t set, the current time will be used</value>
        [DataMember(Name = "occurredAt", EmitDefaultValue = false)]
        public DateTimeOffset OccurredAt { get; set; }

        /// <summary>
        /// The object id that this event occurred on. Could be a contact id or a visitor id.
        /// </summary>
        /// <value>The object id that this event occurred on. Could be a contact id or a visitor id.</value>
        [DataMember(Name = "objectId", EmitDefaultValue = false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BehavioralEventHttpCompletionRequest {\n");
            sb.Append("  Utk: ").Append(Utk).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return this.Equals(input as BehavioralEventHttpCompletionRequest);
        }

        /// <summary>
        /// Returns true if BehavioralEventHttpCompletionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BehavioralEventHttpCompletionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BehavioralEventHttpCompletionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Utk == input.Utk ||
                    (this.Utk != null &&
                    this.Utk.Equals(input.Utk))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.OccurredAt == input.OccurredAt ||
                    (this.OccurredAt != null &&
                    this.OccurredAt.Equals(input.OccurredAt))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.Utk != null)
                {
                    hashCode = (hashCode * 59) + this.Utk.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.OccurredAt != null)
                {
                    hashCode = (hashCode * 59) + this.OccurredAt.GetHashCode();
                }
                if (this.ObjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectId.GetHashCode();
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
