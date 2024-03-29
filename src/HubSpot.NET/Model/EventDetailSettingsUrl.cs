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
    /// EventDetailSettingsUrl
    /// </summary>
    [DataContract(Name = "EventDetailSettingsUrl")]
    public partial class EventDetailSettingsUrl : IEquatable<EventDetailSettingsUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDetailSettingsUrl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventDetailSettingsUrl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventDetailSettingsUrl" /> class.
        /// </summary>
        /// <param name="eventDetailsUrl">The url that will be used to fetch marketing event details by id. Must contain a &#x60;%s&#x60; character sequence that will be substituted with the event id. For example: &#x60;https://my.event.app/events/%s&#x60; (required).</param>
        public EventDetailSettingsUrl(string eventDetailsUrl = default(string))
        {
            // to ensure "eventDetailsUrl" is required (not null)
            if (eventDetailsUrl == null) {
                throw new ArgumentNullException("eventDetailsUrl is a required property for EventDetailSettingsUrl and cannot be null");
            }
            this.EventDetailsUrl = eventDetailsUrl;
        }

        /// <summary>
        /// The url that will be used to fetch marketing event details by id. Must contain a &#x60;%s&#x60; character sequence that will be substituted with the event id. For example: &#x60;https://my.event.app/events/%s&#x60;
        /// </summary>
        /// <value>The url that will be used to fetch marketing event details by id. Must contain a &#x60;%s&#x60; character sequence that will be substituted with the event id. For example: &#x60;https://my.event.app/events/%s&#x60;</value>
        [DataMember(Name = "eventDetailsUrl", IsRequired = true, EmitDefaultValue = false)]
        public string EventDetailsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventDetailSettingsUrl {\n");
            sb.Append("  EventDetailsUrl: ").Append(EventDetailsUrl).Append("\n");
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
            return this.Equals(input as EventDetailSettingsUrl);
        }

        /// <summary>
        /// Returns true if EventDetailSettingsUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of EventDetailSettingsUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventDetailSettingsUrl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventDetailsUrl == input.EventDetailsUrl ||
                    (this.EventDetailsUrl != null &&
                    this.EventDetailsUrl.Equals(input.EventDetailsUrl))
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
                if (this.EventDetailsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EventDetailsUrl.GetHashCode();
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
