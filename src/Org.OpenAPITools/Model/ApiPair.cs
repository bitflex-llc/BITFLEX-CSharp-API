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
    /// ApiPair
    /// </summary>
    [DataContract(Name = "ApiPair")]
    public partial class ApiPair : IEquatable<ApiPair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPair" /> class.
        /// </summary>
        /// <param name="pair">pair.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="leverage">leverage.</param>
        /// <param name="id">id.</param>
        public ApiPair(string pair = default(string), string symbol = default(string), int leverage = default(int), string id = default(string))
        {
            this.Pair = pair;
            this.Symbol = symbol;
            this.Leverage = leverage;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Pair
        /// </summary>
        [DataMember(Name = "pair", EmitDefaultValue = true)]
        public string Pair { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Leverage
        /// </summary>
        [DataMember(Name = "leverage", EmitDefaultValue = false)]
        public int Leverage { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiPair {\n");
            sb.Append("  Pair: ").Append(Pair).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ApiPair);
        }

        /// <summary>
        /// Returns true if ApiPair instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pair == input.Pair ||
                    (this.Pair != null &&
                    this.Pair.Equals(input.Pair))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Leverage == input.Leverage ||
                    this.Leverage.Equals(input.Leverage)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Pair != null)
                    hashCode = hashCode * 59 + this.Pair.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                hashCode = hashCode * 59 + this.Leverage.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
