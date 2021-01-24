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
    /// VerifyResult
    /// </summary>
    [DataContract(Name = "VerifyResult")]
    public partial class VerifyResult : IEquatable<VerifyResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyResult" /> class.
        /// </summary>
        /// <param name="isIdentical">isIdentical.</param>
        /// <param name="confidence">confidence.</param>
        public VerifyResult(bool isIdentical = default(bool), double confidence = default(double))
        {
            this.IsIdentical = isIdentical;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Gets or Sets IsIdentical
        /// </summary>
        [DataMember(Name = "isIdentical", EmitDefaultValue = false)]
        public bool IsIdentical { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        public double Confidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyResult {\n");
            sb.Append("  IsIdentical: ").Append(IsIdentical).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return this.Equals(input as VerifyResult);
        }

        /// <summary>
        /// Returns true if VerifyResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsIdentical == input.IsIdentical ||
                    this.IsIdentical.Equals(input.IsIdentical)
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    this.Confidence.Equals(input.Confidence)
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
                hashCode = hashCode * 59 + this.IsIdentical.GetHashCode();
                hashCode = hashCode * 59 + this.Confidence.GetHashCode();
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