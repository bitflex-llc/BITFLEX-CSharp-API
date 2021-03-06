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
    /// PostGetReferrerEmailRequest
    /// </summary>
    [DataContract(Name = "PostGetReferrerEmailRequest")]
    public partial class PostGetReferrerEmailRequest : IEquatable<PostGetReferrerEmailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostGetReferrerEmailRequest" /> class.
        /// </summary>
        /// <param name="refId">refId.</param>
        public PostGetReferrerEmailRequest(string refId = default(string))
        {
            this.RefId = refId;
        }

        /// <summary>
        /// Gets or Sets RefId
        /// </summary>
        [DataMember(Name = "refId", EmitDefaultValue = true)]
        public string RefId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostGetReferrerEmailRequest {\n");
            sb.Append("  RefId: ").Append(RefId).Append("\n");
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
            return this.Equals(input as PostGetReferrerEmailRequest);
        }

        /// <summary>
        /// Returns true if PostGetReferrerEmailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostGetReferrerEmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostGetReferrerEmailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefId == input.RefId ||
                    (this.RefId != null &&
                    this.RefId.Equals(input.RefId))
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
                if (this.RefId != null)
                    hashCode = hashCode * 59 + this.RefId.GetHashCode();
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
