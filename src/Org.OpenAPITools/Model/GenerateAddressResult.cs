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
    /// GenerateAddressResult
    /// </summary>
    [DataContract(Name = "GenerateAddressResult")]
    public partial class GenerateAddressResult : IEquatable<GenerateAddressResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateAddressResult" /> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="depositParam">depositParam.</param>
        /// <param name="errorCode">errorCode.</param>
        public GenerateAddressResult(bool result = default(bool), GetAddressResponse depositParam = default(GetAddressResponse), BalanceErrorCode errorCode = default(BalanceErrorCode))
        {
            this.Result = result;
            this.DepositParam = depositParam;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or Sets DepositParam
        /// </summary>
        [DataMember(Name = "depositParam", EmitDefaultValue = false)]
        public GetAddressResponse DepositParam { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public BalanceErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateAddressResult {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DepositParam: ").Append(DepositParam).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(input as GenerateAddressResult);
        }

        /// <summary>
        /// Returns true if GenerateAddressResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateAddressResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateAddressResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.DepositParam == input.DepositParam ||
                    (this.DepositParam != null &&
                    this.DepositParam.Equals(input.DepositParam))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.DepositParam != null)
                    hashCode = hashCode * 59 + this.DepositParam.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
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
