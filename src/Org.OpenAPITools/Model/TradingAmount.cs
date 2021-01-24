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
    /// TradingAmount
    /// </summary>
    [DataContract(Name = "TradingAmount")]
    public partial class TradingAmount : IEquatable<TradingAmount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingAmount" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="totalBtc">totalBtc.</param>
        /// <param name="monthBtc">monthBtc.</param>
        /// <param name="promoPeriodBtc">promoPeriodBtc.</param>
        public TradingAmount(string id = default(string), string userId = default(string), double? totalBtc = default(double?), double monthBtc = default(double), double promoPeriodBtc = default(double))
        {
            this.Id = id;
            this.UserId = userId;
            this.TotalBtc = totalBtc;
            this.MonthBtc = monthBtc;
            this.PromoPeriodBtc = promoPeriodBtc;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets TotalBtc
        /// </summary>
        [DataMember(Name = "totalBtc", EmitDefaultValue = true)]
        public double? TotalBtc { get; set; }

        /// <summary>
        /// Gets or Sets MonthBtc
        /// </summary>
        [DataMember(Name = "monthBtc", EmitDefaultValue = false)]
        public double MonthBtc { get; set; }

        /// <summary>
        /// Gets or Sets PromoPeriodBtc
        /// </summary>
        [DataMember(Name = "promoPeriodBtc", EmitDefaultValue = false)]
        public double PromoPeriodBtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradingAmount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TotalBtc: ").Append(TotalBtc).Append("\n");
            sb.Append("  MonthBtc: ").Append(MonthBtc).Append("\n");
            sb.Append("  PromoPeriodBtc: ").Append(PromoPeriodBtc).Append("\n");
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
            return this.Equals(input as TradingAmount);
        }

        /// <summary>
        /// Returns true if TradingAmount instances are equal
        /// </summary>
        /// <param name="input">Instance of TradingAmount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradingAmount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.TotalBtc == input.TotalBtc ||
                    (this.TotalBtc != null &&
                    this.TotalBtc.Equals(input.TotalBtc))
                ) && 
                (
                    this.MonthBtc == input.MonthBtc ||
                    this.MonthBtc.Equals(input.MonthBtc)
                ) && 
                (
                    this.PromoPeriodBtc == input.PromoPeriodBtc ||
                    this.PromoPeriodBtc.Equals(input.PromoPeriodBtc)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TotalBtc != null)
                    hashCode = hashCode * 59 + this.TotalBtc.GetHashCode();
                hashCode = hashCode * 59 + this.MonthBtc.GetHashCode();
                hashCode = hashCode * 59 + this.PromoPeriodBtc.GetHashCode();
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
