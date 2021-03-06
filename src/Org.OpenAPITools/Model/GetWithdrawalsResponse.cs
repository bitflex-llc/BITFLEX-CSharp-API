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
    /// GetWithdrawalsResponse
    /// </summary>
    [DataContract(Name = "GetWithdrawalsResponse")]
    public partial class GetWithdrawalsResponse : IEquatable<GetWithdrawalsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWithdrawalsResponse" /> class.
        /// </summary>
        /// <param name="withdrawals">withdrawals.</param>
        /// <param name="withdrawRequests">withdrawRequests.</param>
        public GetWithdrawalsResponse(List<ApiGetDepositsWitdrawals> withdrawals = default(List<ApiGetDepositsWitdrawals>), List<WithdrawRequest> withdrawRequests = default(List<WithdrawRequest>))
        {
            this.Withdrawals = withdrawals;
            this.WithdrawRequests = withdrawRequests;
        }

        /// <summary>
        /// Gets or Sets Withdrawals
        /// </summary>
        [DataMember(Name = "withdrawals", EmitDefaultValue = true)]
        public List<ApiGetDepositsWitdrawals> Withdrawals { get; set; }

        /// <summary>
        /// Gets or Sets WithdrawRequests
        /// </summary>
        [DataMember(Name = "withdrawRequests", EmitDefaultValue = true)]
        public List<WithdrawRequest> WithdrawRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWithdrawalsResponse {\n");
            sb.Append("  Withdrawals: ").Append(Withdrawals).Append("\n");
            sb.Append("  WithdrawRequests: ").Append(WithdrawRequests).Append("\n");
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
            return this.Equals(input as GetWithdrawalsResponse);
        }

        /// <summary>
        /// Returns true if GetWithdrawalsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWithdrawalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWithdrawalsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Withdrawals == input.Withdrawals ||
                    this.Withdrawals != null &&
                    input.Withdrawals != null &&
                    this.Withdrawals.SequenceEqual(input.Withdrawals)
                ) && 
                (
                    this.WithdrawRequests == input.WithdrawRequests ||
                    this.WithdrawRequests != null &&
                    input.WithdrawRequests != null &&
                    this.WithdrawRequests.SequenceEqual(input.WithdrawRequests)
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
                if (this.Withdrawals != null)
                    hashCode = hashCode * 59 + this.Withdrawals.GetHashCode();
                if (this.WithdrawRequests != null)
                    hashCode = hashCode * 59 + this.WithdrawRequests.GetHashCode();
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
