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
    /// QuotesCollectionResponseAssociatedIdForwardPaging
    /// </summary>
    [DataContract(Name = "QuotesCollectionResponseAssociatedIdForwardPaging")]
    public partial class QuotesCollectionResponseAssociatedIdForwardPaging : IEquatable<QuotesCollectionResponseAssociatedIdForwardPaging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesCollectionResponseAssociatedIdForwardPaging" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotesCollectionResponseAssociatedIdForwardPaging() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesCollectionResponseAssociatedIdForwardPaging" /> class.
        /// </summary>
        /// <param name="results">results (required).</param>
        /// <param name="paging">paging.</param>
        public QuotesCollectionResponseAssociatedIdForwardPaging(List<AssociatedId> results = default(List<AssociatedId>), QuotesForwardPaging paging = default(QuotesForwardPaging))
        {
            // to ensure "results" is required (not null)
            if (results == null) {
                throw new ArgumentNullException("results is a required property for QuotesCollectionResponseAssociatedIdForwardPaging and cannot be null");
            }
            this.Results = results;
            this.Paging = paging;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = false)]
        public List<AssociatedId> Results { get; set; }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name = "paging", EmitDefaultValue = false)]
        public QuotesForwardPaging Paging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotesCollectionResponseAssociatedIdForwardPaging {\n");
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
            return this.Equals(input as QuotesCollectionResponseAssociatedIdForwardPaging);
        }

        /// <summary>
        /// Returns true if QuotesCollectionResponseAssociatedIdForwardPaging instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotesCollectionResponseAssociatedIdForwardPaging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotesCollectionResponseAssociatedIdForwardPaging input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
