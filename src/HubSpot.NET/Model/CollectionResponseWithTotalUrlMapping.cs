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
    /// CollectionResponseWithTotalUrlMapping
    /// </summary>
    [DataContract(Name = "CollectionResponseWithTotalUrlMapping")]
    public partial class CollectionResponseWithTotalUrlMapping : IEquatable<CollectionResponseWithTotalUrlMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseWithTotalUrlMapping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionResponseWithTotalUrlMapping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseWithTotalUrlMapping" /> class.
        /// </summary>
        /// <param name="total">The number of available results. (required).</param>
        /// <param name="results">Matched URLs. (required).</param>
        /// <param name="paging">paging.</param>
        public CollectionResponseWithTotalUrlMapping(int total = default(int), List<UrlMapping> results = default(List<UrlMapping>), Paging paging = default(Paging))
        {
            this.Total = total;
            // to ensure "results" is required (not null)
            if (results == null) {
                throw new ArgumentNullException("results is a required property for CollectionResponseWithTotalUrlMapping and cannot be null");
            }
            this.Results = results;
            this.Paging = paging;
        }

        /// <summary>
        /// The number of available results.
        /// </summary>
        /// <value>The number of available results.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Matched URLs.
        /// </summary>
        /// <value>Matched URLs.</value>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = false)]
        public List<UrlMapping> Results { get; set; }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name = "paging", EmitDefaultValue = false)]
        public Paging Paging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionResponseWithTotalUrlMapping {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
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
            return this.Equals(input as CollectionResponseWithTotalUrlMapping);
        }

        /// <summary>
        /// Returns true if CollectionResponseWithTotalUrlMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionResponseWithTotalUrlMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionResponseWithTotalUrlMapping input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Paging == input.Paging ||
                    (this.Paging != null &&
                    this.Paging.Equals(input.Paging))
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.Paging != null)
                {
                    hashCode = (hashCode * 59) + this.Paging.GetHashCode();
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