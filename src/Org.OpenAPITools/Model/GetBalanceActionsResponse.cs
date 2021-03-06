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
    /// GetBalanceActionsResponse
    /// </summary>
    [DataContract(Name = "GetBalanceActionsResponse")]
    public partial class GetBalanceActionsResponse : IEquatable<GetBalanceActionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceActionsResponse" /> class.
        /// </summary>
        /// <param name="actions">actions.</param>
        /// <param name="pages">pages.</param>
        public GetBalanceActionsResponse(List<ApiGetBalanceActions> actions = default(List<ApiGetBalanceActions>), int pages = default(int))
        {
            this.Actions = actions;
            this.Pages = pages;
        }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name = "actions", EmitDefaultValue = true)]
        public List<ApiGetBalanceActions> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name = "pages", EmitDefaultValue = false)]
        public int Pages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBalanceActionsResponse {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
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
            return this.Equals(input as GetBalanceActionsResponse);
        }

        /// <summary>
        /// Returns true if GetBalanceActionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBalanceActionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBalanceActionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Pages == input.Pages ||
                    this.Pages.Equals(input.Pages)
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                hashCode = hashCode * 59 + this.Pages.GetHashCode();
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
