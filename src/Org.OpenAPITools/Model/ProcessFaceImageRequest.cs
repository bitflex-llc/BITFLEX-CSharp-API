/*
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ProcessFaceImageRequest
    /// </summary>
    [DataContract(Name = "ProcessFaceImageRequest")]
    public partial class ProcessFaceImageRequest : IEquatable<ProcessFaceImageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessFaceImageRequest" /> class.
        /// </summary>
        /// <param name="containerUUID">containerUUID.</param>
        public ProcessFaceImageRequest(string containerUUID = default(string))
        {
            this.ContainerUUID = containerUUID;
        }

        /// <summary>
        /// Gets or Sets ContainerUUID
        /// </summary>
        [DataMember(Name = "containerUUID", EmitDefaultValue = true)]
        public string ContainerUUID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessFaceImageRequest {\n");
            sb.Append("  ContainerUUID: ").Append(ContainerUUID).Append("\n");
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
            return this.Equals(input as ProcessFaceImageRequest);
        }

        /// <summary>
        /// Returns true if ProcessFaceImageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessFaceImageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessFaceImageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerUUID == input.ContainerUUID ||
                    (this.ContainerUUID != null &&
                    this.ContainerUUID.Equals(input.ContainerUUID))
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
                if (this.ContainerUUID != null)
                    hashCode = hashCode * 59 + this.ContainerUUID.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
