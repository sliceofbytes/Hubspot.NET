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
    /// Outlines the features that are supported by the external accounting system.
    /// </summary>
    [DataContract(Name = "AccountingFeatures")]
    public partial class AccountingFeatures : IEquatable<AccountingFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingFeatures" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountingFeatures() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingFeatures" /> class.
        /// </summary>
        /// <param name="createInvoice">createInvoice (required).</param>
        /// <param name="importInvoice">importInvoice (required).</param>
        /// <param name="sync">Indicates if syncing objects from the external account system into HubSpot is supported for the integration. This is a map, where the key is one of &#x60;CONTACT&#x60; or &#x60;PRODUCT&#x60;, to indicate which type of object you do or don&#39;t support syncing. For example: &#x60;&#x60;&#x60;   \&quot;sync\&quot;: {     \&quot;CONTACT\&quot;: {       \&quot;toHubSpot\&quot;: true     },     \&quot;PRODUCT\&quot;: {       \&quot;toHubSpot\&quot;: true     }   } &#x60;&#x60;&#x60;  (required).</param>
        public AccountingFeatures(CreateInvoiceFeature createInvoice = default(CreateInvoiceFeature), ImportInvoiceFeature importInvoice = default(ImportInvoiceFeature), Dictionary<string, ObjectSyncFeature> sync = default(Dictionary<string, ObjectSyncFeature>))
        {
            // to ensure "createInvoice" is required (not null)
            if (createInvoice == null) {
                throw new ArgumentNullException("createInvoice is a required property for AccountingFeatures and cannot be null");
            }
            this.CreateInvoice = createInvoice;
            // to ensure "importInvoice" is required (not null)
            if (importInvoice == null) {
                throw new ArgumentNullException("importInvoice is a required property for AccountingFeatures and cannot be null");
            }
            this.ImportInvoice = importInvoice;
            // to ensure "sync" is required (not null)
            if (sync == null) {
                throw new ArgumentNullException("sync is a required property for AccountingFeatures and cannot be null");
            }
            this.Sync = sync;
        }

        /// <summary>
        /// Gets or Sets CreateInvoice
        /// </summary>
        [DataMember(Name = "createInvoice", IsRequired = true, EmitDefaultValue = false)]
        public CreateInvoiceFeature CreateInvoice { get; set; }

        /// <summary>
        /// Gets or Sets ImportInvoice
        /// </summary>
        [DataMember(Name = "importInvoice", IsRequired = true, EmitDefaultValue = false)]
        public ImportInvoiceFeature ImportInvoice { get; set; }

        /// <summary>
        /// Indicates if syncing objects from the external account system into HubSpot is supported for the integration. This is a map, where the key is one of &#x60;CONTACT&#x60; or &#x60;PRODUCT&#x60;, to indicate which type of object you do or don&#39;t support syncing. For example: &#x60;&#x60;&#x60;   \&quot;sync\&quot;: {     \&quot;CONTACT\&quot;: {       \&quot;toHubSpot\&quot;: true     },     \&quot;PRODUCT\&quot;: {       \&quot;toHubSpot\&quot;: true     }   } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <value>Indicates if syncing objects from the external account system into HubSpot is supported for the integration. This is a map, where the key is one of &#x60;CONTACT&#x60; or &#x60;PRODUCT&#x60;, to indicate which type of object you do or don&#39;t support syncing. For example: &#x60;&#x60;&#x60;   \&quot;sync\&quot;: {     \&quot;CONTACT\&quot;: {       \&quot;toHubSpot\&quot;: true     },     \&quot;PRODUCT\&quot;: {       \&quot;toHubSpot\&quot;: true     }   } &#x60;&#x60;&#x60; </value>
        [DataMember(Name = "sync", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, ObjectSyncFeature> Sync { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountingFeatures {\n");
            sb.Append("  CreateInvoice: ").Append(CreateInvoice).Append("\n");
            sb.Append("  ImportInvoice: ").Append(ImportInvoice).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
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
            return this.Equals(input as AccountingFeatures);
        }

        /// <summary>
        /// Returns true if AccountingFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountingFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountingFeatures input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreateInvoice == input.CreateInvoice ||
                    (this.CreateInvoice != null &&
                    this.CreateInvoice.Equals(input.CreateInvoice))
                ) && 
                (
                    this.ImportInvoice == input.ImportInvoice ||
                    (this.ImportInvoice != null &&
                    this.ImportInvoice.Equals(input.ImportInvoice))
                ) && 
                (
                    this.Sync == input.Sync ||
                    this.Sync != null &&
                    input.Sync != null &&
                    this.Sync.SequenceEqual(input.Sync)
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
                if (this.CreateInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.CreateInvoice.GetHashCode();
                }
                if (this.ImportInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.ImportInvoice.GetHashCode();
                }
                if (this.Sync != null)
                {
                    hashCode = (hashCode * 59) + this.Sync.GetHashCode();
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