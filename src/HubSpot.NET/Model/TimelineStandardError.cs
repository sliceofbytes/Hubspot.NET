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
    /// TimelineStandardError
    /// </summary>
    [DataContract(Name = "TimelineStandardError")]
    public partial class TimelineStandardError : IEquatable<TimelineStandardError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineStandardError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimelineStandardError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineStandardError" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="id">id.</param>
        /// <param name="category">category (required).</param>
        /// <param name="subCategory">subCategory.</param>
        /// <param name="message">message (required).</param>
        /// <param name="errors">errors (required).</param>
        /// <param name="context">context (required).</param>
        /// <param name="links">links (required).</param>
        public TimelineStandardError(string status = default(string), string id = default(string), TimelineErrorCategory category = default(TimelineErrorCategory), Object subCategory = default(Object), string message = default(string), List<ErrorDetail> errors = default(List<ErrorDetail>), Dictionary<string, List<string>> context = default(Dictionary<string, List<string>>), Dictionary<string, string> links = default(Dictionary<string, string>))
        {
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for TimelineStandardError and cannot be null");
            }
            this.Status = status;
            // to ensure "category" is required (not null)
            if (category == null) {
                throw new ArgumentNullException("category is a required property for TimelineStandardError and cannot be null");
            }
            this.Category = category;
            // to ensure "message" is required (not null)
            if (message == null) {
                throw new ArgumentNullException("message is a required property for TimelineStandardError and cannot be null");
            }
            this.Message = message;
            // to ensure "errors" is required (not null)
            if (errors == null) {
                throw new ArgumentNullException("errors is a required property for TimelineStandardError and cannot be null");
            }
            this.Errors = errors;
            // to ensure "context" is required (not null)
            if (context == null) {
                throw new ArgumentNullException("context is a required property for TimelineStandardError and cannot be null");
            }
            this.Context = context;
            // to ensure "links" is required (not null)
            if (links == null) {
                throw new ArgumentNullException("links is a required property for TimelineStandardError and cannot be null");
            }
            this.Links = links;
            this.Id = id;
            this.SubCategory = subCategory;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public TimelineErrorCategory Category { get; set; }

        /// <summary>
        /// Gets or Sets SubCategory
        /// </summary>
        [DataMember(Name = "subCategory", EmitDefaultValue = false)]
        public Object SubCategory { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        public List<ErrorDetail> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, List<string>> Context { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimelineStandardError {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  SubCategory: ").Append(SubCategory).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as TimelineStandardError);
        }

        /// <summary>
        /// Returns true if TimelineStandardError instances are equal
        /// </summary>
        /// <param name="input">Instance of TimelineStandardError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimelineStandardError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.SubCategory == input.SubCategory ||
                    (this.SubCategory != null &&
                    this.SubCategory.Equals(input.SubCategory))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Context == input.Context ||
                    this.Context != null &&
                    input.Context != null &&
                    this.Context.SequenceEqual(input.Context)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.SubCategory != null)
                {
                    hashCode = (hashCode * 59) + this.SubCategory.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
