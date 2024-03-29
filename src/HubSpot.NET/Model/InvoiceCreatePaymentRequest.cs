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
    /// InvoiceCreatePaymentRequest
    /// </summary>
    [DataContract(Name = "InvoiceCreatePaymentRequest")]
    public partial class InvoiceCreatePaymentRequest : IEquatable<InvoiceCreatePaymentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreatePaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceCreatePaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreatePaymentRequest" /> class.
        /// </summary>
        /// <param name="amountPaid">The amount that this payment is for. (required).</param>
        /// <param name="currencyCode">The ISO 4217 currency code that represents the currency of the payment. (required).</param>
        /// <param name="paymentDateTime">The datetime that this payment was received. (required).</param>
        /// <param name="externalPaymentId">The id of this payment in the external accounting system. (required).</param>
        public InvoiceCreatePaymentRequest(decimal amountPaid = default(decimal), string currencyCode = default(string), DateTimeOffset paymentDateTime = default(DateTimeOffset), string externalPaymentId = default(string))
        {
            this.AmountPaid = amountPaid;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null) {
                throw new ArgumentNullException("currencyCode is a required property for InvoiceCreatePaymentRequest and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            this.PaymentDateTime = paymentDateTime;
            // to ensure "externalPaymentId" is required (not null)
            if (externalPaymentId == null) {
                throw new ArgumentNullException("externalPaymentId is a required property for InvoiceCreatePaymentRequest and cannot be null");
            }
            this.ExternalPaymentId = externalPaymentId;
        }

        /// <summary>
        /// The amount that this payment is for.
        /// </summary>
        /// <value>The amount that this payment is for.</value>
        [DataMember(Name = "amountPaid", IsRequired = true, EmitDefaultValue = false)]
        public decimal AmountPaid { get; set; }

        /// <summary>
        /// The ISO 4217 currency code that represents the currency of the payment.
        /// </summary>
        /// <value>The ISO 4217 currency code that represents the currency of the payment.</value>
        [DataMember(Name = "currencyCode", IsRequired = true, EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The datetime that this payment was received.
        /// </summary>
        /// <value>The datetime that this payment was received.</value>
        [DataMember(Name = "paymentDateTime", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset PaymentDateTime { get; set; }

        /// <summary>
        /// The id of this payment in the external accounting system.
        /// </summary>
        /// <value>The id of this payment in the external accounting system.</value>
        [DataMember(Name = "externalPaymentId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalPaymentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceCreatePaymentRequest {\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  PaymentDateTime: ").Append(PaymentDateTime).Append("\n");
            sb.Append("  ExternalPaymentId: ").Append(ExternalPaymentId).Append("\n");
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
            return this.Equals(input as InvoiceCreatePaymentRequest);
        }

        /// <summary>
        /// Returns true if InvoiceCreatePaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceCreatePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceCreatePaymentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountPaid == input.AmountPaid ||
                    this.AmountPaid.Equals(input.AmountPaid)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.PaymentDateTime == input.PaymentDateTime ||
                    (this.PaymentDateTime != null &&
                    this.PaymentDateTime.Equals(input.PaymentDateTime))
                ) && 
                (
                    this.ExternalPaymentId == input.ExternalPaymentId ||
                    (this.ExternalPaymentId != null &&
                    this.ExternalPaymentId.Equals(input.ExternalPaymentId))
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
                hashCode = (hashCode * 59) + this.AmountPaid.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.PaymentDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDateTime.GetHashCode();
                }
                if (this.ExternalPaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalPaymentId.GetHashCode();
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
