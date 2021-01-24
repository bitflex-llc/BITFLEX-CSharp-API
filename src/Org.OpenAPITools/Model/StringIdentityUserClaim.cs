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
    /// StringIdentityUserClaim
    /// </summary>
    [DataContract(Name = "StringIdentityUserClaim")]
    public partial class StringIdentityUserClaim : IEquatable<StringIdentityUserClaim>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringIdentityUserClaim" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="claimType">claimType.</param>
        /// <param name="claimValue">claimValue.</param>
        public StringIdentityUserClaim(int id = default(int), string userId = default(string), string claimType = default(string), string claimValue = default(string))
        {
            this.Id = id;
            this.UserId = userId;
            this.ClaimType = claimType;
            this.ClaimValue = claimValue;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets ClaimType
        /// </summary>
        [DataMember(Name = "claimType", EmitDefaultValue = true)]
        public string ClaimType { get; set; }

        /// <summary>
        /// Gets or Sets ClaimValue
        /// </summary>
        [DataMember(Name = "claimValue", EmitDefaultValue = true)]
        public string ClaimValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StringIdentityUserClaim {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ClaimType: ").Append(ClaimType).Append("\n");
            sb.Append("  ClaimValue: ").Append(ClaimValue).Append("\n");
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
            return this.Equals(input as StringIdentityUserClaim);
        }

        /// <summary>
        /// Returns true if StringIdentityUserClaim instances are equal
        /// </summary>
        /// <param name="input">Instance of StringIdentityUserClaim to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringIdentityUserClaim input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ClaimType == input.ClaimType ||
                    (this.ClaimType != null &&
                    this.ClaimType.Equals(input.ClaimType))
                ) && 
                (
                    this.ClaimValue == input.ClaimValue ||
                    (this.ClaimValue != null &&
                    this.ClaimValue.Equals(input.ClaimValue))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ClaimType != null)
                    hashCode = hashCode * 59 + this.ClaimType.GetHashCode();
                if (this.ClaimValue != null)
                    hashCode = hashCode * 59 + this.ClaimValue.GetHashCode();
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