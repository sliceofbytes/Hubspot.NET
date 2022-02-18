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
    /// MarketingEventCreateRequestParams
    /// </summary>
    [DataContract(Name = "MarketingEventCreateRequestParams")]
    public partial class MarketingEventCreateRequestParams : IEquatable<MarketingEventCreateRequestParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingEventCreateRequestParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarketingEventCreateRequestParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingEventCreateRequestParams" /> class.
        /// </summary>
        /// <param name="eventName">The name of the marketing event. (required).</param>
        /// <param name="eventType">Describes what type of event this is.  For example: &#x60;WEBINAR&#x60;, &#x60;CONFERENCE&#x60;, &#x60;WORKSHOP&#x60;.</param>
        /// <param name="startDateTime">The start date and time of the marketing event..</param>
        /// <param name="endDateTime">The end date and time of the marketing event..</param>
        /// <param name="eventOrganizer">The name of the organizer of the marketing event. (required).</param>
        /// <param name="eventDescription">The description of the marketing event..</param>
        /// <param name="eventUrl">A URL in the external event application where the marketing event can be managed..</param>
        /// <param name="eventCancelled">Indicates if the marketing event has been cancelled.  Defaults to &#x60;false&#x60;.</param>
        /// <param name="customProperties">A list of PropertyValues. These can be whatever kind of property names and values you want. However, they must already exist on the HubSpot account&#39;s definition of the MarketingEvent Object. If they don&#39;t they will be filtered out and not set. In order to do this you&#39;ll need to create a new PropertyGroup on the HubSpot account&#39;s MarketingEvent object for your specific app and create the Custom Property you want to track on that HubSpot account. Do not create any new default properties on the MarketingEvent object as that will apply to all HubSpot accounts. .</param>
        /// <param name="externalAccountId">The accountId that is associated with this marketing event in the external event application. (required).</param>
        /// <param name="externalEventId">The id of the marketing event in the external event application. (required).</param>
        public MarketingEventCreateRequestParams(string eventName = default(string), string eventType = default(string), DateTimeOffset startDateTime = default(DateTimeOffset), DateTimeOffset endDateTime = default(DateTimeOffset), string eventOrganizer = default(string), string eventDescription = default(string), string eventUrl = default(string), bool eventCancelled = default(bool), List<PropertyValue> customProperties = default(List<PropertyValue>), string externalAccountId = default(string), string externalEventId = default(string))
        {
            // to ensure "eventName" is required (not null)
            if (eventName == null) {
                throw new ArgumentNullException("eventName is a required property for MarketingEventCreateRequestParams and cannot be null");
            }
            this.EventName = eventName;
            // to ensure "eventOrganizer" is required (not null)
            if (eventOrganizer == null) {
                throw new ArgumentNullException("eventOrganizer is a required property for MarketingEventCreateRequestParams and cannot be null");
            }
            this.EventOrganizer = eventOrganizer;
            // to ensure "externalAccountId" is required (not null)
            if (externalAccountId == null) {
                throw new ArgumentNullException("externalAccountId is a required property for MarketingEventCreateRequestParams and cannot be null");
            }
            this.ExternalAccountId = externalAccountId;
            // to ensure "externalEventId" is required (not null)
            if (externalEventId == null) {
                throw new ArgumentNullException("externalEventId is a required property for MarketingEventCreateRequestParams and cannot be null");
            }
            this.ExternalEventId = externalEventId;
            this.EventType = eventType;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.EventDescription = eventDescription;
            this.EventUrl = eventUrl;
            this.EventCancelled = eventCancelled;
            this.CustomProperties = customProperties;
        }

        /// <summary>
        /// The name of the marketing event.
        /// </summary>
        /// <value>The name of the marketing event.</value>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// Describes what type of event this is.  For example: &#x60;WEBINAR&#x60;, &#x60;CONFERENCE&#x60;, &#x60;WORKSHOP&#x60;
        /// </summary>
        /// <value>Describes what type of event this is.  For example: &#x60;WEBINAR&#x60;, &#x60;CONFERENCE&#x60;, &#x60;WORKSHOP&#x60;</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// The start date and time of the marketing event.
        /// </summary>
        /// <value>The start date and time of the marketing event.</value>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTimeOffset StartDateTime { get; set; }

        /// <summary>
        /// The end date and time of the marketing event.
        /// </summary>
        /// <value>The end date and time of the marketing event.</value>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public DateTimeOffset EndDateTime { get; set; }

        /// <summary>
        /// The name of the organizer of the marketing event.
        /// </summary>
        /// <value>The name of the organizer of the marketing event.</value>
        [DataMember(Name = "eventOrganizer", IsRequired = true, EmitDefaultValue = false)]
        public string EventOrganizer { get; set; }

        /// <summary>
        /// The description of the marketing event.
        /// </summary>
        /// <value>The description of the marketing event.</value>
        [DataMember(Name = "eventDescription", EmitDefaultValue = false)]
        public string EventDescription { get; set; }

        /// <summary>
        /// A URL in the external event application where the marketing event can be managed.
        /// </summary>
        /// <value>A URL in the external event application where the marketing event can be managed.</value>
        [DataMember(Name = "eventUrl", EmitDefaultValue = false)]
        public string EventUrl { get; set; }

        /// <summary>
        /// Indicates if the marketing event has been cancelled.  Defaults to &#x60;false&#x60;
        /// </summary>
        /// <value>Indicates if the marketing event has been cancelled.  Defaults to &#x60;false&#x60;</value>
        [DataMember(Name = "eventCancelled", EmitDefaultValue = true)]
        public bool EventCancelled { get; set; }

        /// <summary>
        /// A list of PropertyValues. These can be whatever kind of property names and values you want. However, they must already exist on the HubSpot account&#39;s definition of the MarketingEvent Object. If they don&#39;t they will be filtered out and not set. In order to do this you&#39;ll need to create a new PropertyGroup on the HubSpot account&#39;s MarketingEvent object for your specific app and create the Custom Property you want to track on that HubSpot account. Do not create any new default properties on the MarketingEvent object as that will apply to all HubSpot accounts. 
        /// </summary>
        /// <value>A list of PropertyValues. These can be whatever kind of property names and values you want. However, they must already exist on the HubSpot account&#39;s definition of the MarketingEvent Object. If they don&#39;t they will be filtered out and not set. In order to do this you&#39;ll need to create a new PropertyGroup on the HubSpot account&#39;s MarketingEvent object for your specific app and create the Custom Property you want to track on that HubSpot account. Do not create any new default properties on the MarketingEvent object as that will apply to all HubSpot accounts. </value>
        [DataMember(Name = "customProperties", EmitDefaultValue = false)]
        public List<PropertyValue> CustomProperties { get; set; }

        /// <summary>
        /// The accountId that is associated with this marketing event in the external event application.
        /// </summary>
        /// <value>The accountId that is associated with this marketing event in the external event application.</value>
        [DataMember(Name = "externalAccountId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalAccountId { get; set; }

        /// <summary>
        /// The id of the marketing event in the external event application.
        /// </summary>
        /// <value>The id of the marketing event in the external event application.</value>
        [DataMember(Name = "externalEventId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalEventId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketingEventCreateRequestParams {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  EventOrganizer: ").Append(EventOrganizer).Append("\n");
            sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
            sb.Append("  EventUrl: ").Append(EventUrl).Append("\n");
            sb.Append("  EventCancelled: ").Append(EventCancelled).Append("\n");
            sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
            sb.Append("  ExternalAccountId: ").Append(ExternalAccountId).Append("\n");
            sb.Append("  ExternalEventId: ").Append(ExternalEventId).Append("\n");
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
            return this.Equals(input as MarketingEventCreateRequestParams);
        }

        /// <summary>
        /// Returns true if MarketingEventCreateRequestParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketingEventCreateRequestParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketingEventCreateRequestParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.EventOrganizer == input.EventOrganizer ||
                    (this.EventOrganizer != null &&
                    this.EventOrganizer.Equals(input.EventOrganizer))
                ) && 
                (
                    this.EventDescription == input.EventDescription ||
                    (this.EventDescription != null &&
                    this.EventDescription.Equals(input.EventDescription))
                ) && 
                (
                    this.EventUrl == input.EventUrl ||
                    (this.EventUrl != null &&
                    this.EventUrl.Equals(input.EventUrl))
                ) && 
                (
                    this.EventCancelled == input.EventCancelled ||
                    this.EventCancelled.Equals(input.EventCancelled)
                ) && 
                (
                    this.CustomProperties == input.CustomProperties ||
                    this.CustomProperties != null &&
                    input.CustomProperties != null &&
                    this.CustomProperties.SequenceEqual(input.CustomProperties)
                ) && 
                (
                    this.ExternalAccountId == input.ExternalAccountId ||
                    (this.ExternalAccountId != null &&
                    this.ExternalAccountId.Equals(input.ExternalAccountId))
                ) && 
                (
                    this.ExternalEventId == input.ExternalEventId ||
                    (this.ExternalEventId != null &&
                    this.ExternalEventId.Equals(input.ExternalEventId))
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
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                if (this.EventOrganizer != null)
                {
                    hashCode = (hashCode * 59) + this.EventOrganizer.GetHashCode();
                }
                if (this.EventDescription != null)
                {
                    hashCode = (hashCode * 59) + this.EventDescription.GetHashCode();
                }
                if (this.EventUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EventUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventCancelled.GetHashCode();
                if (this.CustomProperties != null)
                {
                    hashCode = (hashCode * 59) + this.CustomProperties.GetHashCode();
                }
                if (this.ExternalAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalAccountId.GetHashCode();
                }
                if (this.ExternalEventId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalEventId.GetHashCode();
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
