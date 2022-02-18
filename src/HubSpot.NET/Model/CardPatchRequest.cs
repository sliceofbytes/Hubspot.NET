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
    /// Body for a patch with optional fields
    /// </summary>
    [DataContract(Name = "CardPatchRequest")]
    public partial class CardPatchRequest : IEquatable<CardPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPatchRequest" /> class.
        /// </summary>
        /// <param name="title">The top-level title for this card. Displayed to users in the CRM UI..</param>
        /// <param name="fetch">fetch.</param>
        /// <param name="display">display.</param>
        /// <param name="actions">actions.</param>
        public CardPatchRequest(string title = default(string), CardFetchBodyPatch fetch = default(CardFetchBodyPatch), CardDisplayBody display = default(CardDisplayBody), CardActions actions = default(CardActions))
        {
            this.Title = title;
            this.Fetch = fetch;
            this.Display = display;
            this.Actions = actions;
        }

        /// <summary>
        /// The top-level title for this card. Displayed to users in the CRM UI.
        /// </summary>
        /// <value>The top-level title for this card. Displayed to users in the CRM UI.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Fetch
        /// </summary>
        [DataMember(Name = "fetch", EmitDefaultValue = false)]
        public CardFetchBodyPatch Fetch { get; set; }

        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name = "display", EmitDefaultValue = false)]
        public CardDisplayBody Display { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", EmitDefaultValue = false)]
        public CardActions Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardPatchRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Fetch: ").Append(Fetch).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as CardPatchRequest);
        }

        /// <summary>
        /// Returns true if CardPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CardPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardPatchRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Fetch == input.Fetch ||
                    (this.Fetch != null &&
                    this.Fetch.Equals(input.Fetch))
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
                ) && 
                (
                    this.Actions == input.Actions ||
                    (this.Actions != null &&
                    this.Actions.Equals(input.Actions))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Fetch != null)
                {
                    hashCode = (hashCode * 59) + this.Fetch.GetHashCode();
                }
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
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
