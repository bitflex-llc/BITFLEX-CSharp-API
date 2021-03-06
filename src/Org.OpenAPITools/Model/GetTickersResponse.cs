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
    /// GetTickersResponse
    /// </summary>
    [DataContract(Name = "GetTickersResponse")]
    public partial class GetTickersResponse : IEquatable<GetTickersResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public StatusCodeEnum? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTickersResponse" /> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="code">code.</param>
        /// <param name="tickers">tickers.</param>
        public GetTickersResponse(bool result = default(bool), StatusCodeEnum? code = default(StatusCodeEnum?), List<ApiTickers> tickers = default(List<ApiTickers>))
        {
            this.Result = result;
            this.Code = code;
            this.Tickers = tickers;
        }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or Sets Tickers
        /// </summary>
        [DataMember(Name = "tickers", EmitDefaultValue = true)]
        public List<ApiTickers> Tickers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTickersResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Tickers: ").Append(Tickers).Append("\n");
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
            return this.Equals(input as GetTickersResponse);
        }

        /// <summary>
        /// Returns true if GetTickersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTickersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTickersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Tickers == input.Tickers ||
                    this.Tickers != null &&
                    input.Tickers != null &&
                    this.Tickers.SequenceEqual(input.Tickers)
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
                hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Tickers != null)
                    hashCode = hashCode * 59 + this.Tickers.GetHashCode();
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
