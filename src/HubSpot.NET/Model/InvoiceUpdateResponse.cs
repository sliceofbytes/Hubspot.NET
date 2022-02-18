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
    /// InvoiceUpdateResponse
    /// </summary>
    [DataContract(Name = "InvoiceUpdateResponse")]
    public partial class InvoiceUpdateResponse : IEquatable<InvoiceUpdateResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines InvoiceStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InvoiceStatusEnum
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
            VOIDED = 6,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 7,

            /// <summary>
            /// Enum UNPAID for value: UNPAID
            /// </summary>
            [EnumMember(Value = "UNPAID")]
            UNPAID = 8

        }


        /// <summary>
        /// Gets or Sets InvoiceStatus
        /// </summary>
        [DataMember(Name = "invoiceStatus", IsRequired = true, EmitDefaultValue = false)]
        public InvoiceStatusEnum InvoiceStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceUpdateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceUpdateResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceUpdateResponse" /> class.
        /// </summary>
        /// <param name="externalInvoiceNumber">externalInvoiceNumber.</param>
        /// <param name="totalAmountBilled">totalAmountBilled (required).</param>
        /// <param name="balanceDue">balanceDue (required).</param>
        /// <param name="currencyCode">currencyCode (required).</param>
        /// <param name="dueDate">dueDate (required).</param>
        /// <param name="externalRecipientId">externalRecipientId (required).</param>
        /// <param name="receivedByRecipientDate">receivedByRecipientDate.</param>
        /// <param name="externalCreateDateTime">externalCreateDateTime.</param>
        /// <param name="isVoided">isVoided (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="archivedAt">archivedAt.</param>
        /// <param name="archived">archived (required).</param>
        /// <param name="externalAccountId">externalAccountId (required).</param>
        /// <param name="invoiceStatus">invoiceStatus (required).</param>
        /// <param name="id">id (required).</param>
        public InvoiceUpdateResponse(string externalInvoiceNumber = default(string), decimal totalAmountBilled = default(decimal), decimal balanceDue = default(decimal), string currencyCode = default(string), DateTimeOffset dueDate = default(DateTimeOffset), string externalRecipientId = default(string), long receivedByRecipientDate = default(long), long externalCreateDateTime = default(long), bool isVoided = default(bool), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), DateTimeOffset archivedAt = default(DateTimeOffset), bool archived = default(bool), string externalAccountId = default(string), InvoiceStatusEnum invoiceStatus = default(InvoiceStatusEnum), string id = default(string))
        {
            this.TotalAmountBilled = totalAmountBilled;
            this.BalanceDue = balanceDue;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null) {
                throw new ArgumentNullException("currencyCode is a required property for InvoiceUpdateResponse and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            this.DueDate = dueDate;
            // to ensure "externalRecipientId" is required (not null)
            if (externalRecipientId == null) {
                throw new ArgumentNullException("externalRecipientId is a required property for InvoiceUpdateResponse and cannot be null");
            }
            this.ExternalRecipientId = externalRecipientId;
            this.IsVoided = isVoided;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Archived = archived;
            // to ensure "externalAccountId" is required (not null)
            if (externalAccountId == null) {
                throw new ArgumentNullException("externalAccountId is a required property for InvoiceUpdateResponse and cannot be null");
            }
            this.ExternalAccountId = externalAccountId;
            this.InvoiceStatus = invoiceStatus;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for InvoiceUpdateResponse and cannot be null");
            }
            this.Id = id;
            this.ExternalInvoiceNumber = externalInvoiceNumber;
            this.ReceivedByRecipientDate = receivedByRecipientDate;
            this.ExternalCreateDateTime = externalCreateDateTime;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Gets or Sets ExternalInvoiceNumber
        /// </summary>
        [DataMember(Name = "externalInvoiceNumber", EmitDefaultValue = false)]
        public string ExternalInvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountBilled
        /// </summary>
        [DataMember(Name = "totalAmountBilled", IsRequired = true, EmitDefaultValue = false)]
        public decimal TotalAmountBilled { get; set; }

        /// <summary>
        /// Gets or Sets BalanceDue
        /// </summary>
        [DataMember(Name = "balanceDue", IsRequired = true, EmitDefaultValue = false)]
        public decimal BalanceDue { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "currencyCode", IsRequired = true, EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name = "dueDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTimeOffset DueDate { get; set; }

        /// <summary>
        /// Gets or Sets ExternalRecipientId
        /// </summary>
        [DataMember(Name = "externalRecipientId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalRecipientId { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedByRecipientDate
        /// </summary>
        [DataMember(Name = "receivedByRecipientDate", EmitDefaultValue = false)]
        public long ReceivedByRecipientDate { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCreateDateTime
        /// </summary>
        [DataMember(Name = "externalCreateDateTime", EmitDefaultValue = false)]
        public long ExternalCreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsVoided
        /// </summary>
        [DataMember(Name = "isVoided", IsRequired = true, EmitDefaultValue = true)]
        public bool IsVoided { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ArchivedAt
        /// </summary>
        [DataMember(Name = "archivedAt", EmitDefaultValue = false)]
        public DateTimeOffset ArchivedAt { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name = "archived", IsRequired = true, EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets ExternalAccountId
        /// </summary>
        [DataMember(Name = "externalAccountId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalAccountId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceUpdateResponse {\n");
            sb.Append("  ExternalInvoiceNumber: ").Append(ExternalInvoiceNumber).Append("\n");
            sb.Append("  TotalAmountBilled: ").Append(TotalAmountBilled).Append("\n");
            sb.Append("  BalanceDue: ").Append(BalanceDue).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  ExternalRecipientId: ").Append(ExternalRecipientId).Append("\n");
            sb.Append("  ReceivedByRecipientDate: ").Append(ReceivedByRecipientDate).Append("\n");
            sb.Append("  ExternalCreateDateTime: ").Append(ExternalCreateDateTime).Append("\n");
            sb.Append("  IsVoided: ").Append(IsVoided).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ArchivedAt: ").Append(ArchivedAt).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  ExternalAccountId: ").Append(ExternalAccountId).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as InvoiceUpdateResponse);
        }

        /// <summary>
        /// Returns true if InvoiceUpdateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceUpdateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExternalInvoiceNumber == input.ExternalInvoiceNumber ||
                    (this.ExternalInvoiceNumber != null &&
                    this.ExternalInvoiceNumber.Equals(input.ExternalInvoiceNumber))
                ) && 
                (
                    this.TotalAmountBilled == input.TotalAmountBilled ||
                    this.TotalAmountBilled.Equals(input.TotalAmountBilled)
                ) && 
                (
                    this.BalanceDue == input.BalanceDue ||
                    this.BalanceDue.Equals(input.BalanceDue)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.ExternalRecipientId == input.ExternalRecipientId ||
                    (this.ExternalRecipientId != null &&
                    this.ExternalRecipientId.Equals(input.ExternalRecipientId))
                ) && 
                (
                    this.ReceivedByRecipientDate == input.ReceivedByRecipientDate ||
                    this.ReceivedByRecipientDate.Equals(input.ReceivedByRecipientDate)
                ) && 
                (
                    this.ExternalCreateDateTime == input.ExternalCreateDateTime ||
                    this.ExternalCreateDateTime.Equals(input.ExternalCreateDateTime)
                ) && 
                (
                    this.IsVoided == input.IsVoided ||
                    this.IsVoided.Equals(input.IsVoided)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ArchivedAt == input.ArchivedAt ||
                    (this.ArchivedAt != null &&
                    this.ArchivedAt.Equals(input.ArchivedAt))
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
                ) && 
                (
                    this.ExternalAccountId == input.ExternalAccountId ||
                    (this.ExternalAccountId != null &&
                    this.ExternalAccountId.Equals(input.ExternalAccountId))
                ) && 
                (
                    this.InvoiceStatus == input.InvoiceStatus ||
                    this.InvoiceStatus.Equals(input.InvoiceStatus)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ExternalInvoiceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalInvoiceNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalAmountBilled.GetHashCode();
                hashCode = (hashCode * 59) + this.BalanceDue.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.ExternalRecipientId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalRecipientId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReceivedByRecipientDate.GetHashCode();
                hashCode = (hashCode * 59) + this.ExternalCreateDateTime.GetHashCode();
                hashCode = (hashCode * 59) + this.IsVoided.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.ArchivedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ArchivedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
                if (this.ExternalAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalAccountId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceStatus.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
