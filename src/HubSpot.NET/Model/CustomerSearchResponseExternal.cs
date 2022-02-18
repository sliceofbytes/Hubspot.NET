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
    /// A response to a search for customers.
    /// </summary>
    [DataContract(Name = "CustomerSearchResponseExternal")]
    public partial class CustomerSearchResponseExternal : IEquatable<CustomerSearchResponseExternal>, IValidatableObject
    {
        /// <summary>
        /// Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).
        /// </summary>
        /// <value>Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,

            /// <summary>
            /// Enum ERR for value: ERR
            /// </summary>
            [EnumMember(Value = "ERR")]
            ERR = 2

        }


        /// <summary>
        /// Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).
        /// </summary>
        /// <value>Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;).</value>
        [DataMember(Name = "@result", IsRequired = true, EmitDefaultValue = false)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSearchResponseExternal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerSearchResponseExternal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSearchResponseExternal" /> class.
        /// </summary>
        /// <param name="result">Designates if the response is a success (&#39;OK&#39;) or failure (&#39;ERR&#39;). (required).</param>
        /// <param name="customers">The list of customers that matched the search criteria. (required).</param>
        public CustomerSearchResponseExternal(ResultEnum result = default(ResultEnum), List<AccountingExtensionCustomer> customers = default(List<AccountingExtensionCustomer>))
        {
            this.Result = result;
            // to ensure "customers" is required (not null)
            if (customers == null) {
                throw new ArgumentNullException("customers is a required property for CustomerSearchResponseExternal and cannot be null");
            }
            this.Customers = customers;
        }

        /// <summary>
        /// The list of customers that matched the search criteria.
        /// </summary>
        /// <value>The list of customers that matched the search criteria.</value>
        [DataMember(Name = "customers", IsRequired = true, EmitDefaultValue = false)]
        public List<AccountingExtensionCustomer> Customers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerSearchResponseExternal {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Customers: ").Append(Customers).Append("\n");
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
            return this.Equals(input as CustomerSearchResponseExternal);
        }

        /// <summary>
        /// Returns true if CustomerSearchResponseExternal instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerSearchResponseExternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerSearchResponseExternal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.Customers == input.Customers ||
                    this.Customers != null &&
                    input.Customers != null &&
                    this.Customers.SequenceEqual(input.Customers)
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
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
                if (this.Customers != null)
                {
                    hashCode = (hashCode * 59) + this.Customers.GetHashCode();
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
