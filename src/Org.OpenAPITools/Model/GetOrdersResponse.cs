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
    /// GetOrdersResponse
    /// </summary>
    [DataContract(Name = "GetOrdersResponse")]
    public partial class GetOrdersResponse : IEquatable<GetOrdersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrdersResponse" /> class.
        /// </summary>
        /// <param name="openOrders">openOrders.</param>
        /// <param name="closedOrders">closedOrders.</param>
        public GetOrdersResponse(List<ApiGetOrders> openOrders = default(List<ApiGetOrders>), List<ApiGetOrders> closedOrders = default(List<ApiGetOrders>))
        {
            this.OpenOrders = openOrders;
            this.ClosedOrders = closedOrders;
        }

        /// <summary>
        /// Gets or Sets OpenOrders
        /// </summary>
        [DataMember(Name = "openOrders", EmitDefaultValue = true)]
        public List<ApiGetOrders> OpenOrders { get; set; }

        /// <summary>
        /// Gets or Sets ClosedOrders
        /// </summary>
        [DataMember(Name = "closedOrders", EmitDefaultValue = true)]
        public List<ApiGetOrders> ClosedOrders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrdersResponse {\n");
            sb.Append("  OpenOrders: ").Append(OpenOrders).Append("\n");
            sb.Append("  ClosedOrders: ").Append(ClosedOrders).Append("\n");
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
            return this.Equals(input as GetOrdersResponse);
        }

        /// <summary>
        /// Returns true if GetOrdersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrdersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrdersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpenOrders == input.OpenOrders ||
                    this.OpenOrders != null &&
                    input.OpenOrders != null &&
                    this.OpenOrders.SequenceEqual(input.OpenOrders)
                ) && 
                (
                    this.ClosedOrders == input.ClosedOrders ||
                    this.ClosedOrders != null &&
                    input.ClosedOrders != null &&
                    this.ClosedOrders.SequenceEqual(input.ClosedOrders)
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
                if (this.OpenOrders != null)
                    hashCode = hashCode * 59 + this.OpenOrders.GetHashCode();
                if (this.ClosedOrders != null)
                    hashCode = hashCode * 59 + this.ClosedOrders.GetHashCode();
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