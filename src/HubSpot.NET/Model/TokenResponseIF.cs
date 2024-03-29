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
    /// TokenResponseIF
    /// </summary>
    [DataContract(Name = "TokenResponseIF")]
    public partial class TokenResponseIF : IEquatable<TokenResponseIF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseIF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenResponseIF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseIF" /> class.
        /// </summary>
        /// <param name="refreshToken">refreshToken (required).</param>
        /// <param name="expiresIn">expiresIn (required).</param>
        /// <param name="accessToken">accessToken (required).</param>
        /// <param name="idToken">idToken.</param>
        /// <param name="tokenType">tokenType (required).</param>
        public TokenResponseIF(string refreshToken = default(string), int expiresIn = default(int), string accessToken = default(string), string idToken = default(string), string tokenType = default(string))
        {
            // to ensure "refreshToken" is required (not null)
            if (refreshToken == null) {
                throw new ArgumentNullException("refreshToken is a required property for TokenResponseIF and cannot be null");
            }
            this.RefreshToken = refreshToken;
            this.ExpiresIn = expiresIn;
            // to ensure "accessToken" is required (not null)
            if (accessToken == null) {
                throw new ArgumentNullException("accessToken is a required property for TokenResponseIF and cannot be null");
            }
            this.AccessToken = accessToken;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null) {
                throw new ArgumentNullException("tokenType is a required property for TokenResponseIF and cannot be null");
            }
            this.TokenType = tokenType;
            this.IdToken = idToken;
        }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", IsRequired = true, EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", IsRequired = true, EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", IsRequired = true, EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name = "id_token", EmitDefaultValue = false)]
        public string IdToken { get; set; }

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
            sb.Append("class TokenResponseIF {\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
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
            return this.Equals(input as TokenResponseIF);
        }

        /// <summary>
        /// Returns true if TokenResponseIF instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenResponseIF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenResponseIF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
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
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.IdToken != null)
                {
                    hashCode = (hashCode * 59) + this.IdToken.GetHashCode();
                }
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
