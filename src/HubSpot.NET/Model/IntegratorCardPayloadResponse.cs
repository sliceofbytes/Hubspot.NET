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
    /// The card details payload, sent to HubSpot by an app in response to a data fetch request when a user visits a CRM record page.
    /// </summary>
    [DataContract(Name = "IntegratorCardPayloadResponse")]
    public partial class IntegratorCardPayloadResponse : IEquatable<IntegratorCardPayloadResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines ResponseVersion
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseVersionEnum
        {
            /// <summary>
            /// Enum V1 for value: v1
            /// </summary>
            [EnumMember(Value = "v1")]
            V1 = 1,

            /// <summary>
            /// Enum V3 for value: v3
            /// </summary>
            [EnumMember(Value = "v3")]
            V3 = 2

        }


        /// <summary>
        /// Gets or Sets ResponseVersion
        /// </summary>
        [DataMember(Name = "responseVersion", EmitDefaultValue = false)]
        public ResponseVersionEnum? ResponseVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegratorCardPayloadResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegratorCardPayloadResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegratorCardPayloadResponse" /> class.
        /// </summary>
        /// <param name="totalCount">The total number of card properties that will be sent in this response. (required).</param>
        /// <param name="allItemsLinkUrl">URL to a page the integrator has built that displays all details for this card. This URL will be displayed to users under a &#x60;See more [x]&#x60; link if there are more than five items in your response, where &#x60;[x]&#x60; is the value of &#x60;itemLabel&#x60;..</param>
        /// <param name="cardLabel">The label to be used for the &#x60;allItemsLinkUrl&#x60; link (e.g. &#39;See more tickets&#39;). If not provided, this falls back to the card&#39;s title..</param>
        /// <param name="topLevelActions">topLevelActions.</param>
        /// <param name="sections">A list of up to five valid card sub categories..</param>
        /// <param name="responseVersion">responseVersion.</param>
        public IntegratorCardPayloadResponse(int totalCount = default(int), string allItemsLinkUrl = default(string), string cardLabel = default(string), TopLevelActions topLevelActions = default(TopLevelActions), List<IntegratorObjectResult> sections = default(List<IntegratorObjectResult>), ResponseVersionEnum? responseVersion = default(ResponseVersionEnum?))
        {
            this.TotalCount = totalCount;
            this.AllItemsLinkUrl = allItemsLinkUrl;
            this.CardLabel = cardLabel;
            this.TopLevelActions = topLevelActions;
            this.Sections = sections;
            this.ResponseVersion = responseVersion;
        }

        /// <summary>
        /// The total number of card properties that will be sent in this response.
        /// </summary>
        /// <value>The total number of card properties that will be sent in this response.</value>
        [DataMember(Name = "totalCount", IsRequired = true, EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// URL to a page the integrator has built that displays all details for this card. This URL will be displayed to users under a &#x60;See more [x]&#x60; link if there are more than five items in your response, where &#x60;[x]&#x60; is the value of &#x60;itemLabel&#x60;.
        /// </summary>
        /// <value>URL to a page the integrator has built that displays all details for this card. This URL will be displayed to users under a &#x60;See more [x]&#x60; link if there are more than five items in your response, where &#x60;[x]&#x60; is the value of &#x60;itemLabel&#x60;.</value>
        [DataMember(Name = "allItemsLinkUrl", EmitDefaultValue = false)]
        public string AllItemsLinkUrl { get; set; }

        /// <summary>
        /// The label to be used for the &#x60;allItemsLinkUrl&#x60; link (e.g. &#39;See more tickets&#39;). If not provided, this falls back to the card&#39;s title.
        /// </summary>
        /// <value>The label to be used for the &#x60;allItemsLinkUrl&#x60; link (e.g. &#39;See more tickets&#39;). If not provided, this falls back to the card&#39;s title.</value>
        [DataMember(Name = "cardLabel", EmitDefaultValue = false)]
        public string CardLabel { get; set; }

        /// <summary>
        /// Gets or Sets TopLevelActions
        /// </summary>
        [DataMember(Name = "topLevelActions", EmitDefaultValue = false)]
        public TopLevelActions TopLevelActions { get; set; }

        /// <summary>
        /// A list of up to five valid card sub categories.
        /// </summary>
        /// <value>A list of up to five valid card sub categories.</value>
        [DataMember(Name = "sections", EmitDefaultValue = false)]
        public List<IntegratorObjectResult> Sections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntegratorCardPayloadResponse {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  AllItemsLinkUrl: ").Append(AllItemsLinkUrl).Append("\n");
            sb.Append("  CardLabel: ").Append(CardLabel).Append("\n");
            sb.Append("  TopLevelActions: ").Append(TopLevelActions).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
            sb.Append("  ResponseVersion: ").Append(ResponseVersion).Append("\n");
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
            return this.Equals(input as IntegratorCardPayloadResponse);
        }

        /// <summary>
        /// Returns true if IntegratorCardPayloadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegratorCardPayloadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegratorCardPayloadResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.AllItemsLinkUrl == input.AllItemsLinkUrl ||
                    (this.AllItemsLinkUrl != null &&
                    this.AllItemsLinkUrl.Equals(input.AllItemsLinkUrl))
                ) && 
                (
                    this.CardLabel == input.CardLabel ||
                    (this.CardLabel != null &&
                    this.CardLabel.Equals(input.CardLabel))
                ) && 
                (
                    this.TopLevelActions == input.TopLevelActions ||
                    (this.TopLevelActions != null &&
                    this.TopLevelActions.Equals(input.TopLevelActions))
                ) && 
                (
                    this.Sections == input.Sections ||
                    this.Sections != null &&
                    input.Sections != null &&
                    this.Sections.SequenceEqual(input.Sections)
                ) && 
                (
                    this.ResponseVersion == input.ResponseVersion ||
                    this.ResponseVersion.Equals(input.ResponseVersion)
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
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                if (this.AllItemsLinkUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AllItemsLinkUrl.GetHashCode();
                }
                if (this.CardLabel != null)
                {
                    hashCode = (hashCode * 59) + this.CardLabel.GetHashCode();
                }
                if (this.TopLevelActions != null)
                {
                    hashCode = (hashCode * 59) + this.TopLevelActions.GetHashCode();
                }
                if (this.Sections != null)
                {
                    hashCode = (hashCode * 59) + this.Sections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResponseVersion.GetHashCode();
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
