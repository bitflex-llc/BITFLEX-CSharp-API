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
    /// GetDepositsResponse
    /// </summary>
    [DataContract(Name = "GetDepositsResponse")]
    public partial class GetDepositsResponse : IEquatable<GetDepositsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDepositsResponse" /> class.
        /// </summary>
        /// <param name="deposits">deposits.</param>
        public GetDepositsResponse(List<ApiGetDepositsWitdrawals> deposits = default(List<ApiGetDepositsWitdrawals>))
        {
            this.Deposits = deposits;
        }

        /// <summary>
        /// Gets or Sets Deposits
        /// </summary>
        [DataMember(Name = "deposits", EmitDefaultValue = true)]
        public List<ApiGetDepositsWitdrawals> Deposits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDepositsResponse {\n");
            sb.Append("  Deposits: ").Append(Deposits).Append("\n");
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
            return this.Equals(input as GetDepositsResponse);
        }

        /// <summary>
        /// Returns true if GetDepositsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDepositsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDepositsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Deposits == input.Deposits ||
                    this.Deposits != null &&
                    input.Deposits != null &&
                    this.Deposits.SequenceEqual(input.Deposits)
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
                if (this.Deposits != null)
                    hashCode = hashCode * 59 + this.Deposits.GetHashCode();
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