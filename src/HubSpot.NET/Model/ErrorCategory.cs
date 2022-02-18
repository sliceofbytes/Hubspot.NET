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
    /// ErrorCategory
    /// </summary>
    [DataContract(Name = "ErrorCategory")]
    public partial class ErrorCategory : IEquatable<ErrorCategory>, IValidatableObject
    {
        /// <summary>
        /// Defines HttpStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpStatusEnum
        {
            /// <summary>
            /// Enum CONTINUE for value: CONTINUE
            /// </summary>
            [EnumMember(Value = "CONTINUE")]
            CONTINUE = 1,

            /// <summary>
            /// Enum SWITCHINGPROTOCOLS for value: SWITCHING_PROTOCOLS
            /// </summary>
            [EnumMember(Value = "SWITCHING_PROTOCOLS")]
            SWITCHINGPROTOCOLS = 2,

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING = 3,

            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 4,

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED = 5,

            /// <summary>
            /// Enum ACCEPTED for value: ACCEPTED
            /// </summary>
            [EnumMember(Value = "ACCEPTED")]
            ACCEPTED = 6,

            /// <summary>
            /// Enum NONAUTHORITATIVEINFORMATION for value: NON_AUTHORITATIVE_INFORMATION
            /// </summary>
            [EnumMember(Value = "NON_AUTHORITATIVE_INFORMATION")]
            NONAUTHORITATIVEINFORMATION = 7,

            /// <summary>
            /// Enum NOCONTENT for value: NO_CONTENT
            /// </summary>
            [EnumMember(Value = "NO_CONTENT")]
            NOCONTENT = 8,

            /// <summary>
            /// Enum RESETCONTENT for value: RESET_CONTENT
            /// </summary>
            [EnumMember(Value = "RESET_CONTENT")]
            RESETCONTENT = 9,

            /// <summary>
            /// Enum PARTIALCONTENT for value: PARTIAL_CONTENT
            /// </summary>
            [EnumMember(Value = "PARTIAL_CONTENT")]
            PARTIALCONTENT = 10,

            /// <summary>
            /// Enum MULTISTATUS for value: MULTI_STATUS
            /// </summary>
            [EnumMember(Value = "MULTI_STATUS")]
            MULTISTATUS = 11,

            /// <summary>
            /// Enum ALREADYREPORTED for value: ALREADY_REPORTED
            /// </summary>
            [EnumMember(Value = "ALREADY_REPORTED")]
            ALREADYREPORTED = 12,

            /// <summary>
            /// Enum IMUSED for value: IM_USED
            /// </summary>
            [EnumMember(Value = "IM_USED")]
            IMUSED = 13,

            /// <summary>
            /// Enum MULTIPLECHOICES for value: MULTIPLE_CHOICES
            /// </summary>
            [EnumMember(Value = "MULTIPLE_CHOICES")]
            MULTIPLECHOICES = 14,

            /// <summary>
            /// Enum MOVEDPERMANENTLY for value: MOVED_PERMANENTLY
            /// </summary>
            [EnumMember(Value = "MOVED_PERMANENTLY")]
            MOVEDPERMANENTLY = 15,

            /// <summary>
            /// Enum FOUND for value: FOUND
            /// </summary>
            [EnumMember(Value = "FOUND")]
            FOUND = 16,

            /// <summary>
            /// Enum SEEOTHER for value: SEE_OTHER
            /// </summary>
            [EnumMember(Value = "SEE_OTHER")]
            SEEOTHER = 17,

            /// <summary>
            /// Enum NOTMODIFIED for value: NOT_MODIFIED
            /// </summary>
            [EnumMember(Value = "NOT_MODIFIED")]
            NOTMODIFIED = 18,

            /// <summary>
            /// Enum USEPROXY for value: USE_PROXY
            /// </summary>
            [EnumMember(Value = "USE_PROXY")]
            USEPROXY = 19,

            /// <summary>
            /// Enum TEMPORARYREDIRECT for value: TEMPORARY_REDIRECT
            /// </summary>
            [EnumMember(Value = "TEMPORARY_REDIRECT")]
            TEMPORARYREDIRECT = 20,

            /// <summary>
            /// Enum PERMANENTREDIRECT for value: PERMANENT_REDIRECT
            /// </summary>
            [EnumMember(Value = "PERMANENT_REDIRECT")]
            PERMANENTREDIRECT = 21,

            /// <summary>
            /// Enum BADREQUEST for value: BAD_REQUEST
            /// </summary>
            [EnumMember(Value = "BAD_REQUEST")]
            BADREQUEST = 22,

            /// <summary>
            /// Enum UNAUTHORIZED for value: UNAUTHORIZED
            /// </summary>
            [EnumMember(Value = "UNAUTHORIZED")]
            UNAUTHORIZED = 23,

            /// <summary>
            /// Enum PAYMENTREQUIRED for value: PAYMENT_REQUIRED
            /// </summary>
            [EnumMember(Value = "PAYMENT_REQUIRED")]
            PAYMENTREQUIRED = 24,

            /// <summary>
            /// Enum FORBIDDEN for value: FORBIDDEN
            /// </summary>
            [EnumMember(Value = "FORBIDDEN")]
            FORBIDDEN = 25,

            /// <summary>
            /// Enum NOTFOUND for value: NOT_FOUND
            /// </summary>
            [EnumMember(Value = "NOT_FOUND")]
            NOTFOUND = 26,

            /// <summary>
            /// Enum METHODNOTALLOWED for value: METHOD_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "METHOD_NOT_ALLOWED")]
            METHODNOTALLOWED = 27,

            /// <summary>
            /// Enum NOTACCEPTABLE for value: NOT_ACCEPTABLE
            /// </summary>
            [EnumMember(Value = "NOT_ACCEPTABLE")]
            NOTACCEPTABLE = 28,

            /// <summary>
            /// Enum PROXYAUTHENTICATIONREQUIRED for value: PROXY_AUTHENTICATION_REQUIRED
            /// </summary>
            [EnumMember(Value = "PROXY_AUTHENTICATION_REQUIRED")]
            PROXYAUTHENTICATIONREQUIRED = 29,

            /// <summary>
            /// Enum REQUESTTIMEOUT for value: REQUEST_TIMEOUT
            /// </summary>
            [EnumMember(Value = "REQUEST_TIMEOUT")]
            REQUESTTIMEOUT = 30,

            /// <summary>
            /// Enum CONFLICT for value: CONFLICT
            /// </summary>
            [EnumMember(Value = "CONFLICT")]
            CONFLICT = 31,

            /// <summary>
            /// Enum GONE for value: GONE
            /// </summary>
            [EnumMember(Value = "GONE")]
            GONE = 32,

            /// <summary>
            /// Enum LENGTHREQUIRED for value: LENGTH_REQUIRED
            /// </summary>
            [EnumMember(Value = "LENGTH_REQUIRED")]
            LENGTHREQUIRED = 33,

            /// <summary>
            /// Enum PRECONDITIONFAILED for value: PRECONDITION_FAILED
            /// </summary>
            [EnumMember(Value = "PRECONDITION_FAILED")]
            PRECONDITIONFAILED = 34,

            /// <summary>
            /// Enum REQUESTENTITYTOOLARGE for value: REQUEST_ENTITY_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "REQUEST_ENTITY_TOO_LARGE")]
            REQUESTENTITYTOOLARGE = 35,

            /// <summary>
            /// Enum REQUESTURITOOLONG for value: REQUEST_URI_TOO_LONG
            /// </summary>
            [EnumMember(Value = "REQUEST_URI_TOO_LONG")]
            REQUESTURITOOLONG = 36,

            /// <summary>
            /// Enum UNSUPPORTEDMEDIATYPE for value: UNSUPPORTED_MEDIA_TYPE
            /// </summary>
            [EnumMember(Value = "UNSUPPORTED_MEDIA_TYPE")]
            UNSUPPORTEDMEDIATYPE = 37,

            /// <summary>
            /// Enum REQUESTEDRANGENOTSATISFIABLE for value: REQUESTED_RANGE_NOT_SATISFIABLE
            /// </summary>
            [EnumMember(Value = "REQUESTED_RANGE_NOT_SATISFIABLE")]
            REQUESTEDRANGENOTSATISFIABLE = 38,

            /// <summary>
            /// Enum EXPECTATIONFAILED for value: EXPECTATION_FAILED
            /// </summary>
            [EnumMember(Value = "EXPECTATION_FAILED")]
            EXPECTATIONFAILED = 39,

            /// <summary>
            /// Enum IMATEAPOT for value: IM_A_TEAPOT
            /// </summary>
            [EnumMember(Value = "IM_A_TEAPOT")]
            IMATEAPOT = 40,

            /// <summary>
            /// Enum MISDIRECTEDREQUEST for value: MISDIRECTED_REQUEST
            /// </summary>
            [EnumMember(Value = "MISDIRECTED_REQUEST")]
            MISDIRECTEDREQUEST = 41,

            /// <summary>
            /// Enum UNPROCESSABLEENTITY for value: UNPROCESSABLE_ENTITY
            /// </summary>
            [EnumMember(Value = "UNPROCESSABLE_ENTITY")]
            UNPROCESSABLEENTITY = 42,

            /// <summary>
            /// Enum LOCKED for value: LOCKED
            /// </summary>
            [EnumMember(Value = "LOCKED")]
            LOCKED = 43,

            /// <summary>
            /// Enum FAILEDDEPENDENCY for value: FAILED_DEPENDENCY
            /// </summary>
            [EnumMember(Value = "FAILED_DEPENDENCY")]
            FAILEDDEPENDENCY = 44,

            /// <summary>
            /// Enum UPGRADEREQUIRED for value: UPGRADE_REQUIRED
            /// </summary>
            [EnumMember(Value = "UPGRADE_REQUIRED")]
            UPGRADEREQUIRED = 45,

            /// <summary>
            /// Enum PRECONDITIONREQUIRED for value: PRECONDITION_REQUIRED
            /// </summary>
            [EnumMember(Value = "PRECONDITION_REQUIRED")]
            PRECONDITIONREQUIRED = 46,

            /// <summary>
            /// Enum TOOMANYREQUESTS for value: TOO_MANY_REQUESTS
            /// </summary>
            [EnumMember(Value = "TOO_MANY_REQUESTS")]
            TOOMANYREQUESTS = 47,

            /// <summary>
            /// Enum REQUESTHEADERSFIELDSTOOLARGE for value: REQUEST_HEADERS_FIELDS_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "REQUEST_HEADERS_FIELDS_TOO_LARGE")]
            REQUESTHEADERSFIELDSTOOLARGE = 48,

            /// <summary>
            /// Enum INTERNALSTALESERVICEDISCOVERY for value: INTERNAL_STALE_SERVICE_DISCOVERY
            /// </summary>
            [EnumMember(Value = "INTERNAL_STALE_SERVICE_DISCOVERY")]
            INTERNALSTALESERVICEDISCOVERY = 49,

            /// <summary>
            /// Enum UNAVAILABLEFORLEGALREASONS for value: UNAVAILABLE_FOR_LEGAL_REASONS
            /// </summary>
            [EnumMember(Value = "UNAVAILABLE_FOR_LEGAL_REASONS")]
            UNAVAILABLEFORLEGALREASONS = 50,

            /// <summary>
            /// Enum MIGRATIONINPROGRESS for value: MIGRATION_IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "MIGRATION_IN_PROGRESS")]
            MIGRATIONINPROGRESS = 51,

            /// <summary>
            /// Enum INTERNALSERVERERROR for value: INTERNAL_SERVER_ERROR
            /// </summary>
            [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
            INTERNALSERVERERROR = 52,

            /// <summary>
            /// Enum NOTIMPLEMENTED for value: NOT_IMPLEMENTED
            /// </summary>
            [EnumMember(Value = "NOT_IMPLEMENTED")]
            NOTIMPLEMENTED = 53,

            /// <summary>
            /// Enum BADGATEWAY for value: BAD_GATEWAY
            /// </summary>
            [EnumMember(Value = "BAD_GATEWAY")]
            BADGATEWAY = 54,

            /// <summary>
            /// Enum SERVICEUNAVAILABLE for value: SERVICE_UNAVAILABLE
            /// </summary>
            [EnumMember(Value = "SERVICE_UNAVAILABLE")]
            SERVICEUNAVAILABLE = 55,

            /// <summary>
            /// Enum GATEWAYTIMEOUT for value: GATEWAY_TIMEOUT
            /// </summary>
            [EnumMember(Value = "GATEWAY_TIMEOUT")]
            GATEWAYTIMEOUT = 56,

            /// <summary>
            /// Enum HTTPVERSIONNOTSUPPORTED for value: HTTP_VERSION_NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "HTTP_VERSION_NOT_SUPPORTED")]
            HTTPVERSIONNOTSUPPORTED = 57,

            /// <summary>
            /// Enum VARIANTALSONEGOTIATES for value: VARIANT_ALSO_NEGOTIATES
            /// </summary>
            [EnumMember(Value = "VARIANT_ALSO_NEGOTIATES")]
            VARIANTALSONEGOTIATES = 58,

            /// <summary>
            /// Enum INSUFFICIENTSTORAGE for value: INSUFFICIENT_STORAGE
            /// </summary>
            [EnumMember(Value = "INSUFFICIENT_STORAGE")]
            INSUFFICIENTSTORAGE = 59,

            /// <summary>
            /// Enum LOOPDETECTED for value: LOOP_DETECTED
            /// </summary>
            [EnumMember(Value = "LOOP_DETECTED")]
            LOOPDETECTED = 60,

            /// <summary>
            /// Enum NOTEXTENDED for value: NOT_EXTENDED
            /// </summary>
            [EnumMember(Value = "NOT_EXTENDED")]
            NOTEXTENDED = 61,

            /// <summary>
            /// Enum NETWORKAUTHENTICATIONREQUIRED for value: NETWORK_AUTHENTICATION_REQUIRED
            /// </summary>
            [EnumMember(Value = "NETWORK_AUTHENTICATION_REQUIRED")]
            NETWORKAUTHENTICATIONREQUIRED = 62

        }


        /// <summary>
        /// Gets or Sets HttpStatus
        /// </summary>
        [DataMember(Name = "httpStatus", IsRequired = true, EmitDefaultValue = false)]
        public HttpStatusEnum HttpStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorCategory" /> class.
        /// </summary>
        /// <param name="httpStatus">httpStatus (required).</param>
        /// <param name="name">name (required).</param>
        public ErrorCategory(HttpStatusEnum httpStatus = default(HttpStatusEnum), string name = default(string))
        {
            this.HttpStatus = httpStatus;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ErrorCategory and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorCategory {\n");
            sb.Append("  HttpStatus: ").Append(HttpStatus).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ErrorCategory);
        }

        /// <summary>
        /// Returns true if ErrorCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HttpStatus == input.HttpStatus ||
                    this.HttpStatus.Equals(input.HttpStatus)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.HttpStatus.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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