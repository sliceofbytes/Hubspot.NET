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
    /// A color defined by RGB values.
    /// </summary>
    [DataContract(Name = "RGBAColor")]
    public partial class RGBAColor : IEquatable<RGBAColor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RGBAColor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RGBAColor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RGBAColor" /> class.
        /// </summary>
        /// <param name="r">Red. (required).</param>
        /// <param name="g">Green. (required).</param>
        /// <param name="b">Blue. (required).</param>
        /// <param name="a">Alpha. (required).</param>
        public RGBAColor(int r = default(int), int g = default(int), int b = default(int), decimal a = default(decimal))
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }

        /// <summary>
        /// Red.
        /// </summary>
        /// <value>Red.</value>
        [DataMember(Name = "r", IsRequired = true, EmitDefaultValue = false)]
        public int R { get; set; }

        /// <summary>
        /// Green.
        /// </summary>
        /// <value>Green.</value>
        [DataMember(Name = "g", IsRequired = true, EmitDefaultValue = false)]
        public int G { get; set; }

        /// <summary>
        /// Blue.
        /// </summary>
        /// <value>Blue.</value>
        [DataMember(Name = "b", IsRequired = true, EmitDefaultValue = false)]
        public int B { get; set; }

        /// <summary>
        /// Alpha.
        /// </summary>
        /// <value>Alpha.</value>
        [DataMember(Name = "a", IsRequired = true, EmitDefaultValue = false)]
        public decimal A { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RGBAColor {\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  G: ").Append(G).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  A: ").Append(A).Append("\n");
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
            return this.Equals(input as RGBAColor);
        }

        /// <summary>
        /// Returns true if RGBAColor instances are equal
        /// </summary>
        /// <param name="input">Instance of RGBAColor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RGBAColor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.R == input.R ||
                    this.R.Equals(input.R)
                ) && 
                (
                    this.G == input.G ||
                    this.G.Equals(input.G)
                ) && 
                (
                    this.B == input.B ||
                    this.B.Equals(input.B)
                ) && 
                (
                    this.A == input.A ||
                    this.A.Equals(input.A)
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
                hashCode = (hashCode * 59) + this.R.GetHashCode();
                hashCode = (hashCode * 59) + this.G.GetHashCode();
                hashCode = (hashCode * 59) + this.B.GetHashCode();
                hashCode = (hashCode * 59) + this.A.GetHashCode();
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
