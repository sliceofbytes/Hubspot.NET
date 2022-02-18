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
    /// RefreshTokenInfoResponse
    /// </summary>
    [DataContract(Name = "RefreshTokenInfoResponse")]
    public partial class RefreshTokenInfoResponse : IEquatable<RefreshTokenInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenInfoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefreshTokenInfoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenInfoResponse" /> class.
        /// </summary>
        /// <param name="token">token (required).</param>
        /// <param name="user">user.</param>
        /// <param name="hubDomain">hubDomain.</param>
        /// <param name="scopes">scopes (required).</param>
        /// <param name="hubId">hubId (required).</param>
        /// <param name="clientId">clientId (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="tokenType">tokenType (required).</param>
        public RefreshTokenInfoResponse(string token = default(string), string user = default(string), string hubDomain = default(string), List<string> scopes = default(List<string>), int hubId = default(int), string clientId = default(string), int userId = default(int), string tokenType = default(string))
        {
            // to ensure "token" is required (not null)
            if (token == null) {
                throw new ArgumentNullException("token is a required property for RefreshTokenInfoResponse and cannot be null");
            }
            this.Token = token;
            // to ensure "scopes" is required (not null)
            if (scopes == null) {
                throw new ArgumentNullException("scopes is a required property for RefreshTokenInfoResponse and cannot be null");
            }
            this.Scopes = scopes;
            this.HubId = hubId;
            // to ensure "clientId" is required (not null)
            if (clientId == null) {
                throw new ArgumentNullException("clientId is a required property for RefreshTokenInfoResponse and cannot be null");
            }
            this.ClientId = clientId;
            this.UserId = userId;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null) {
                throw new ArgumentNullException("tokenType is a required property for RefreshTokenInfoResponse and cannot be null");
            }
            this.TokenType = tokenType;
            this.User = user;
            this.HubDomain = hubDomain;
        }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets HubDomain
        /// </summary>
        [DataMember(Name = "hub_domain", EmitDefaultValue = false)]
        public string HubDomain { get; set; }

        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name = "scopes", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Gets or Sets HubId
        /// </summary>
        [DataMember(Name = "hub_id", IsRequired = true, EmitDefaultValue = false)]
        public int HubId { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", IsRequired = true, EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "token_type", IsRequired = true, EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefreshTokenInfoResponse {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  HubDomain: ").Append(HubDomain).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  HubId: ").Append(HubId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
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
            return this.Equals(input as RefreshTokenInfoResponse);
        }

        /// <summary>
        /// Returns true if RefreshTokenInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshTokenInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshTokenInfoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.HubDomain == input.HubDomain ||
                    (this.HubDomain != null &&
                    this.HubDomain.Equals(input.HubDomain))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes != null &&
                    input.Scopes != null &&
                    this.Scopes.SequenceEqual(input.Scopes)
                ) && 
                (
                    this.HubId == input.HubId ||
                    this.HubId.Equals(input.HubId)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.HubDomain != null)
                {
                    hashCode = (hashCode * 59) + this.HubDomain.GetHashCode();
                }
                if (this.Scopes != null)
                {
                    hashCode = (hashCode * 59) + this.Scopes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HubId.GetHashCode();
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
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