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
    /// QuotesPaging
    /// </summary>
    [DataContract(Name = "QuotesPaging")]
    public partial class QuotesPaging : IEquatable<QuotesPaging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesPaging" /> class.
        /// </summary>
        /// <param name="next">next.</param>
        /// <param name="prev">prev.</param>
        public QuotesPaging(QuotesNextPage next = default(QuotesNextPage), QuotesPreviousPage prev = default(QuotesPreviousPage))
        {
            this.Next = next;
            this.Prev = prev;
        }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public QuotesNextPage Next { get; set; }

        /// <summary>
        /// Gets or Sets Prev
        /// </summary>
        [DataMember(Name = "prev", EmitDefaultValue = false)]
        public QuotesPreviousPage Prev { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotesPaging {\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
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
            return this.Equals(input as QuotesPaging);
        }

        /// <summary>
        /// Returns true if QuotesPaging instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotesPaging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotesPaging input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
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
                if (this.Next != null)
                {
                    hashCode = (hashCode * 59) + this.Next.GetHashCode();
                }
                if (this.Prev != null)
                {
                    hashCode = (hashCode * 59) + this.Prev.GetHashCode();
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
