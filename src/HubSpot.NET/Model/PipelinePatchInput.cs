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
    /// An input used to update some properties on a pipeline definition.
    /// </summary>
    [DataContract(Name = "PipelinePatchInput")]
    public partial class PipelinePatchInput : IEquatable<PipelinePatchInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePatchInput" /> class.
        /// </summary>
        /// <param name="label">A unique label used to organize pipelines in HubSpot&#39;s UI.</param>
        /// <param name="displayOrder">The order for displaying this pipeline. If two pipelines have a matching &#x60;displayOrder&#x60;, they will be sorted alphabetically by label..</param>
        /// <param name="archived">Whether the pipeline is archived. This property should only be provided when restoring an archived pipeline. If it&#39;s provided in any other call, the request will fail and a &#x60;400 Bad Request&#x60; will be returned..</param>
        public PipelinePatchInput(string label = default(string), int displayOrder = default(int), bool archived = default(bool))
        {
            this.Label = label;
            this.DisplayOrder = displayOrder;
            this.Archived = archived;
        }

        /// <summary>
        /// A unique label used to organize pipelines in HubSpot&#39;s UI
        /// </summary>
        /// <value>A unique label used to organize pipelines in HubSpot&#39;s UI</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The order for displaying this pipeline. If two pipelines have a matching &#x60;displayOrder&#x60;, they will be sorted alphabetically by label.
        /// </summary>
        /// <value>The order for displaying this pipeline. If two pipelines have a matching &#x60;displayOrder&#x60;, they will be sorted alphabetically by label.</value>
        [DataMember(Name = "displayOrder", EmitDefaultValue = false)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the pipeline is archived. This property should only be provided when restoring an archived pipeline. If it&#39;s provided in any other call, the request will fail and a &#x60;400 Bad Request&#x60; will be returned.
        /// </summary>
        /// <value>Whether the pipeline is archived. This property should only be provided when restoring an archived pipeline. If it&#39;s provided in any other call, the request will fail and a &#x60;400 Bad Request&#x60; will be returned.</value>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PipelinePatchInput {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
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
            return this.Equals(input as PipelinePatchInput);
        }

        /// <summary>
        /// Returns true if PipelinePatchInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PipelinePatchInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PipelinePatchInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    this.DisplayOrder.Equals(input.DisplayOrder)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayOrder.GetHashCode();
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
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