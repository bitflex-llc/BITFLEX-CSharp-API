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
    /// ApiMarket
    /// </summary>
    [DataContract(Name = "ApiMarket")]
    public partial class ApiMarket : IEquatable<ApiMarket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMarket" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="pairs">pairs.</param>
        public ApiMarket(string symbol = default(string), List<ApiPair> pairs = default(List<ApiPair>))
        {
            this.Symbol = symbol;
            this.Pairs = pairs;
        }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Pairs
        /// </summary>
        [DataMember(Name = "pairs", EmitDefaultValue = true)]
        public List<ApiPair> Pairs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiMarket {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Pairs: ").Append(Pairs).Append("\n");
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
            return this.Equals(input as ApiMarket);
        }

        /// <summary>
        /// Returns true if ApiMarket instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiMarket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiMarket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Pairs == input.Pairs ||
                    this.Pairs != null &&
                    input.Pairs != null &&
                    this.Pairs.SequenceEqual(input.Pairs)
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Pairs != null)
                    hashCode = hashCode * 59 + this.Pairs.GetHashCode();
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
