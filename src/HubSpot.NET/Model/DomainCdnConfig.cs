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
    /// DomainCdnConfig
    /// </summary>
    [DataContract(Name = "DomainCdnConfig")]
    public partial class DomainCdnConfig : IEquatable<DomainCdnConfig>, IValidatableObject
    {
        /// <summary>
        /// Defines SslStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SslStatusEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 2,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 3,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 4,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 5,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 6,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 7,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 8,

            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 9,

            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 10,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 11,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 12

        }


        /// <summary>
        /// Gets or Sets SslStatus
        /// </summary>
        [DataMember(Name = "sslStatus", IsRequired = true, EmitDefaultValue = false)]
        public SslStatusEnum SslStatus { get; set; }
        /// <summary>
        /// Defines ValidationMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationMethodEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 2,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 3

        }


        /// <summary>
        /// Gets or Sets ValidationMethod
        /// </summary>
        [DataMember(Name = "validationMethod", IsRequired = true, EmitDefaultValue = false)]
        public ValidationMethodEnum ValidationMethod { get; set; }
        /// <summary>
        /// Defines MinimumTlsVersion
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MinimumTlsVersionEnum
        {
            /// <summary>
            /// Enum _10 for value: 1.0
            /// </summary>
            [EnumMember(Value = "1.0")]
            _10 = 1,

            /// <summary>
            /// Enum _11 for value: 1.1
            /// </summary>
            [EnumMember(Value = "1.1")]
            _11 = 2,

            /// <summary>
            /// Enum _12 for value: 1.2
            /// </summary>
            [EnumMember(Value = "1.2")]
            _12 = 3,

            /// <summary>
            /// Enum _13 for value: 1.3
            /// </summary>
            [EnumMember(Value = "1.3")]
            _13 = 4,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 5,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 6

        }


        /// <summary>
        /// Gets or Sets MinimumTlsVersion
        /// </summary>
        [DataMember(Name = "minimumTlsVersion", IsRequired = true, EmitDefaultValue = false)]
        public MinimumTlsVersionEnum MinimumTlsVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCdnConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainCdnConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCdnConfig" /> class.
        /// </summary>
        /// <param name="portalId">portalId (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="domainId">domainId (required).</param>
        /// <param name="certId">certId (required).</param>
        /// <param name="certExpirationDate">certExpirationDate (required).</param>
        /// <param name="cdnId">cdnId (required).</param>
        /// <param name="cdnGroupId">cdnGroupId (required).</param>
        /// <param name="sslStatus">sslStatus (required).</param>
        /// <param name="validationMethod">validationMethod (required).</param>
        /// <param name="httpBody">httpBody (required).</param>
        /// <param name="httpUrlPath">httpUrlPath (required).</param>
        /// <param name="cname">cname (required).</param>
        /// <param name="cnameTarget">cnameTarget (required).</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion (required).</param>
        /// <param name="alternateOriginHostname">alternateOriginHostname (required).</param>
        /// <param name="id">id (required).</param>
        public DomainCdnConfig(int portalId = default(int), long created = default(long), long updated = default(long), long domainId = default(long), long certId = default(long), long certExpirationDate = default(long), string cdnId = default(string), string cdnGroupId = default(string), SslStatusEnum sslStatus = default(SslStatusEnum), ValidationMethodEnum validationMethod = default(ValidationMethodEnum), string httpBody = default(string), string httpUrlPath = default(string), string cname = default(string), string cnameTarget = default(string), MinimumTlsVersionEnum minimumTlsVersion = default(MinimumTlsVersionEnum), string alternateOriginHostname = default(string), long id = default(long))
        {
            this.PortalId = portalId;
            this.Created = created;
            this.Updated = updated;
            this.DomainId = domainId;
            this.CertId = certId;
            this.CertExpirationDate = certExpirationDate;
            // to ensure "cdnId" is required (not null)
            if (cdnId == null) {
                throw new ArgumentNullException("cdnId is a required property for DomainCdnConfig and cannot be null");
            }
            this.CdnId = cdnId;
            // to ensure "cdnGroupId" is required (not null)
            if (cdnGroupId == null) {
                throw new ArgumentNullException("cdnGroupId is a required property for DomainCdnConfig and cannot be null");
            }
            this.CdnGroupId = cdnGroupId;
            this.SslStatus = sslStatus;
            this.ValidationMethod = validationMethod;
            // to ensure "httpBody" is required (not null)
            if (httpBody == null) {
                throw new ArgumentNullException("httpBody is a required property for DomainCdnConfig and cannot be null");
            }
            this.HttpBody = httpBody;
            // to ensure "httpUrlPath" is required (not null)
            if (httpUrlPath == null) {
                throw new ArgumentNullException("httpUrlPath is a required property for DomainCdnConfig and cannot be null");
            }
            this.HttpUrlPath = httpUrlPath;
            // to ensure "cname" is required (not null)
            if (cname == null) {
                throw new ArgumentNullException("cname is a required property for DomainCdnConfig and cannot be null");
            }
            this.Cname = cname;
            // to ensure "cnameTarget" is required (not null)
            if (cnameTarget == null) {
                throw new ArgumentNullException("cnameTarget is a required property for DomainCdnConfig and cannot be null");
            }
            this.CnameTarget = cnameTarget;
            this.MinimumTlsVersion = minimumTlsVersion;
            // to ensure "alternateOriginHostname" is required (not null)
            if (alternateOriginHostname == null) {
                throw new ArgumentNullException("alternateOriginHostname is a required property for DomainCdnConfig and cannot be null");
            }
            this.AlternateOriginHostname = alternateOriginHostname;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name = "portalId", IsRequired = true, EmitDefaultValue = false)]
        public int PortalId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public long Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = false)]
        public long Updated { get; set; }

        /// <summary>
        /// Gets or Sets DomainId
        /// </summary>
        [DataMember(Name = "domainId", IsRequired = true, EmitDefaultValue = false)]
        public long DomainId { get; set; }

        /// <summary>
        /// Gets or Sets CertId
        /// </summary>
        [DataMember(Name = "certId", IsRequired = true, EmitDefaultValue = false)]
        public long CertId { get; set; }

        /// <summary>
        /// Gets or Sets CertExpirationDate
        /// </summary>
        [DataMember(Name = "certExpirationDate", IsRequired = true, EmitDefaultValue = false)]
        public long CertExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets CdnId
        /// </summary>
        [DataMember(Name = "cdnId", IsRequired = true, EmitDefaultValue = false)]
        public string CdnId { get; set; }

        /// <summary>
        /// Gets or Sets CdnGroupId
        /// </summary>
        [DataMember(Name = "cdnGroupId", IsRequired = true, EmitDefaultValue = false)]
        public string CdnGroupId { get; set; }

        /// <summary>
        /// Gets or Sets HttpBody
        /// </summary>
        [DataMember(Name = "httpBody", IsRequired = true, EmitDefaultValue = false)]
        public string HttpBody { get; set; }

        /// <summary>
        /// Gets or Sets HttpUrlPath
        /// </summary>
        [DataMember(Name = "httpUrlPath", IsRequired = true, EmitDefaultValue = false)]
        public string HttpUrlPath { get; set; }

        /// <summary>
        /// Gets or Sets Cname
        /// </summary>
        [DataMember(Name = "cname", IsRequired = true, EmitDefaultValue = false)]
        public string Cname { get; set; }

        /// <summary>
        /// Gets or Sets CnameTarget
        /// </summary>
        [DataMember(Name = "cnameTarget", IsRequired = true, EmitDefaultValue = false)]
        public string CnameTarget { get; set; }

        /// <summary>
        /// Gets or Sets AlternateOriginHostname
        /// </summary>
        [DataMember(Name = "alternateOriginHostname", IsRequired = true, EmitDefaultValue = false)]
        public string AlternateOriginHostname { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainCdnConfig {\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  CertId: ").Append(CertId).Append("\n");
            sb.Append("  CertExpirationDate: ").Append(CertExpirationDate).Append("\n");
            sb.Append("  CdnId: ").Append(CdnId).Append("\n");
            sb.Append("  CdnGroupId: ").Append(CdnGroupId).Append("\n");
            sb.Append("  SslStatus: ").Append(SslStatus).Append("\n");
            sb.Append("  ValidationMethod: ").Append(ValidationMethod).Append("\n");
            sb.Append("  HttpBody: ").Append(HttpBody).Append("\n");
            sb.Append("  HttpUrlPath: ").Append(HttpUrlPath).Append("\n");
            sb.Append("  Cname: ").Append(Cname).Append("\n");
            sb.Append("  CnameTarget: ").Append(CnameTarget).Append("\n");
            sb.Append("  MinimumTlsVersion: ").Append(MinimumTlsVersion).Append("\n");
            sb.Append("  AlternateOriginHostname: ").Append(AlternateOriginHostname).Append("\n");
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
            return this.Equals(input as DomainCdnConfig);
        }

        /// <summary>
        /// Returns true if DomainCdnConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainCdnConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainCdnConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PortalId == input.PortalId ||
                    this.PortalId.Equals(input.PortalId)
                ) && 
                (
                    this.Created == input.Created ||
                    this.Created.Equals(input.Created)
                ) && 
                (
                    this.Updated == input.Updated ||
                    this.Updated.Equals(input.Updated)
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    this.DomainId.Equals(input.DomainId)
                ) && 
                (
                    this.CertId == input.CertId ||
                    this.CertId.Equals(input.CertId)
                ) && 
                (
                    this.CertExpirationDate == input.CertExpirationDate ||
                    this.CertExpirationDate.Equals(input.CertExpirationDate)
                ) && 
                (
                    this.CdnId == input.CdnId ||
                    (this.CdnId != null &&
                    this.CdnId.Equals(input.CdnId))
                ) && 
                (
                    this.CdnGroupId == input.CdnGroupId ||
                    (this.CdnGroupId != null &&
                    this.CdnGroupId.Equals(input.CdnGroupId))
                ) && 
                (
                    this.SslStatus == input.SslStatus ||
                    this.SslStatus.Equals(input.SslStatus)
                ) && 
                (
                    this.ValidationMethod == input.ValidationMethod ||
                    this.ValidationMethod.Equals(input.ValidationMethod)
                ) && 
                (
                    this.HttpBody == input.HttpBody ||
                    (this.HttpBody != null &&
                    this.HttpBody.Equals(input.HttpBody))
                ) && 
                (
                    this.HttpUrlPath == input.HttpUrlPath ||
                    (this.HttpUrlPath != null &&
                    this.HttpUrlPath.Equals(input.HttpUrlPath))
                ) && 
                (
                    this.Cname == input.Cname ||
                    (this.Cname != null &&
                    this.Cname.Equals(input.Cname))
                ) && 
                (
                    this.CnameTarget == input.CnameTarget ||
                    (this.CnameTarget != null &&
                    this.CnameTarget.Equals(input.CnameTarget))
                ) && 
                (
                    this.MinimumTlsVersion == input.MinimumTlsVersion ||
                    this.MinimumTlsVersion.Equals(input.MinimumTlsVersion)
                ) && 
                (
                    this.AlternateOriginHostname == input.AlternateOriginHostname ||
                    (this.AlternateOriginHostname != null &&
                    this.AlternateOriginHostname.Equals(input.AlternateOriginHostname))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
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
                hashCode = (hashCode * 59) + this.PortalId.GetHashCode();
                hashCode = (hashCode * 59) + this.Created.GetHashCode();
                hashCode = (hashCode * 59) + this.Updated.GetHashCode();
                hashCode = (hashCode * 59) + this.DomainId.GetHashCode();
                hashCode = (hashCode * 59) + this.CertId.GetHashCode();
                hashCode = (hashCode * 59) + this.CertExpirationDate.GetHashCode();
                if (this.CdnId != null)
                {
                    hashCode = (hashCode * 59) + this.CdnId.GetHashCode();
                }
                if (this.CdnGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.CdnGroupId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SslStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidationMethod.GetHashCode();
                if (this.HttpBody != null)
                {
                    hashCode = (hashCode * 59) + this.HttpBody.GetHashCode();
                }
                if (this.HttpUrlPath != null)
                {
                    hashCode = (hashCode * 59) + this.HttpUrlPath.GetHashCode();
                }
                if (this.Cname != null)
                {
                    hashCode = (hashCode * 59) + this.Cname.GetHashCode();
                }
                if (this.CnameTarget != null)
                {
                    hashCode = (hashCode * 59) + this.CnameTarget.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinimumTlsVersion.GetHashCode();
                if (this.AlternateOriginHostname != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateOriginHostname.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
