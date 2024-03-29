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
    /// Representation of an invoice in the external accounting system.
    /// </summary>
    [DataContract(Name = "AccountingExtensionInvoice")]
    public partial class AccountingExtensionInvoice : IEquatable<AccountingExtensionInvoice>, IValidatableObject
    {
        /// <summary>
        /// The currency status of the invoice.
        /// </summary>
        /// <value>The currency status of the invoice.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED = 1,

            /// <summary>
            /// Enum SENT for value: SENT
            /// </summary>
            [EnumMember(Value = "SENT")]
            SENT = 2,

            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 3,

            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED = 4,

            /// <summary>
            /// Enum OVERDUE for value: OVERDUE
            /// </summary>
            [EnumMember(Value = "OVERDUE")]
            OVERDUE = 5,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 6

        }


        /// <summary>
        /// The currency status of the invoice.
        /// </summary>
        /// <value>The currency status of the invoice.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingExtensionInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountingExtensionInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingExtensionInvoice" /> class.
        /// </summary>
        /// <param name="amountDue">The total amount due. (required).</param>
        /// <param name="balance">The remaining outstanding balance due..</param>
        /// <param name="dueDate">The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd) (required).</param>
        /// <param name="invoiceNumber">The invoice number.</param>
        /// <param name="customerId">The ID of the customer that this invoice is for..</param>
        /// <param name="currency">The ISO 4217 currency code that represents the currency of this invoice. (required).</param>
        /// <param name="invoiceLink">A link to the invoice in the external accounting system. (required).</param>
        /// <param name="customerName">The name of the customer that this invoice is for. (required).</param>
        /// <param name="status">The currency status of the invoice. (required).</param>
        public AccountingExtensionInvoice(decimal amountDue = default(decimal), decimal balance = default(decimal), DateTimeOffset dueDate = default(DateTimeOffset), string invoiceNumber = default(string), string customerId = default(string), string currency = default(string), string invoiceLink = default(string), string customerName = default(string), StatusEnum status = default(StatusEnum))
        {
            this.AmountDue = amountDue;
            this.DueDate = dueDate;
            // to ensure "currency" is required (not null)
            if (currency == null) {
                throw new ArgumentNullException("currency is a required property for AccountingExtensionInvoice and cannot be null");
            }
            this.Currency = currency;
            // to ensure "invoiceLink" is required (not null)
            if (invoiceLink == null) {
                throw new ArgumentNullException("invoiceLink is a required property for AccountingExtensionInvoice and cannot be null");
            }
            this.InvoiceLink = invoiceLink;
            // to ensure "customerName" is required (not null)
            if (customerName == null) {
                throw new ArgumentNullException("customerName is a required property for AccountingExtensionInvoice and cannot be null");
            }
            this.CustomerName = customerName;
            this.Status = status;
            this.Balance = balance;
            this.InvoiceNumber = invoiceNumber;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// The total amount due.
        /// </summary>
        /// <value>The total amount due.</value>
        [DataMember(Name = "amountDue", IsRequired = true, EmitDefaultValue = false)]
        public decimal AmountDue { get; set; }

        /// <summary>
        /// The remaining outstanding balance due.
        /// </summary>
        /// <value>The remaining outstanding balance due.</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public decimal Balance { get; set; }

        /// <summary>
        /// The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd)
        /// </summary>
        /// <value>The due date for payment of the invoice, in ISO-8601 date format (yyyy-MM-dd)</value>
        [DataMember(Name = "dueDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset DueDate { get; set; }

        /// <summary>
        /// The invoice number
        /// </summary>
        /// <value>The invoice number</value>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The ID of the customer that this invoice is for.
        /// </summary>
        /// <value>The ID of the customer that this invoice is for.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The ISO 4217 currency code that represents the currency of this invoice.
        /// </summary>
        /// <value>The ISO 4217 currency code that represents the currency of this invoice.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// A link to the invoice in the external accounting system.
        /// </summary>
        /// <value>A link to the invoice in the external accounting system.</value>
        [DataMember(Name = "invoiceLink", IsRequired = true, EmitDefaultValue = false)]
        public string InvoiceLink { get; set; }

        /// <summary>
        /// The name of the customer that this invoice is for.
        /// </summary>
        /// <value>The name of the customer that this invoice is for.</value>
        [DataMember(Name = "customerName", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountingExtensionInvoice {\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  InvoiceLink: ").Append(InvoiceLink).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AccountingExtensionInvoice);
        }

        /// <summary>
        /// Returns true if AccountingExtensionInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountingExtensionInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountingExtensionInvoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountDue == input.AmountDue ||
                    this.AmountDue.Equals(input.AmountDue)
                ) && 
                (
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.InvoiceLink == input.InvoiceLink ||
                    (this.InvoiceLink != null &&
                    this.InvoiceLink.Equals(input.InvoiceLink))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = (hashCode * 59) + this.AmountDue.GetHashCode();
                hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.InvoiceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNumber.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.InvoiceLink != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceLink.GetHashCode();
                }
                if (this.CustomerName != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
