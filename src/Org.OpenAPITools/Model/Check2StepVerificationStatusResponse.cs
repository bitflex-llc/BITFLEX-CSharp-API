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
    /// Check2StepVerificationStatusResponse
    /// </summary>
    [DataContract(Name = "Check2StepVerificationStatusResponse")]
    public partial class Check2StepVerificationStatusResponse : IEquatable<Check2StepVerificationStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets VerificationType
        /// </summary>
        [DataMember(Name = "verificationType", EmitDefaultValue = false)]
        public TwoStepVerificationTypes? VerificationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Check2StepVerificationStatusResponse" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="isThisDeviceLegit">isThisDeviceLegit.</param>
        /// <param name="verificationType">verificationType.</param>
        public Check2StepVerificationStatusResponse(bool enabled = default(bool), bool isThisDeviceLegit = default(bool), TwoStepVerificationTypes? verificationType = default(TwoStepVerificationTypes?))
        {
            this.Enabled = enabled;
            this.IsThisDeviceLegit = isThisDeviceLegit;
            this.VerificationType = verificationType;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets IsThisDeviceLegit
        /// </summary>
        [DataMember(Name = "isThisDeviceLegit", EmitDefaultValue = false)]
        public bool IsThisDeviceLegit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Check2StepVerificationStatusResponse {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsThisDeviceLegit: ").Append(IsThisDeviceLegit).Append("\n");
            sb.Append("  VerificationType: ").Append(VerificationType).Append("\n");
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
            return this.Equals(input as Check2StepVerificationStatusResponse);
        }

        /// <summary>
        /// Returns true if Check2StepVerificationStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of Check2StepVerificationStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Check2StepVerificationStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.IsThisDeviceLegit == input.IsThisDeviceLegit ||
                    this.IsThisDeviceLegit.Equals(input.IsThisDeviceLegit)
                ) && 
                (
                    this.VerificationType == input.VerificationType ||
                    this.VerificationType.Equals(input.VerificationType)
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.IsThisDeviceLegit.GetHashCode();
                hashCode = hashCode * 59 + this.VerificationType.GetHashCode();
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
