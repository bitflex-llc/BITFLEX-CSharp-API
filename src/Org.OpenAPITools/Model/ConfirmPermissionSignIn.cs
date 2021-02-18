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
    /// ConfirmPermissionSignIn
    /// </summary>
    [DataContract(Name = "ConfirmPermissionSignIn")]
    public partial class ConfirmPermissionSignIn : IEquatable<ConfirmPermissionSignIn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmPermissionSignIn" /> class.
        /// </summary>
        /// <param name="confirmStatus">confirmStatus.</param>
        /// <param name="id">id.</param>
        public ConfirmPermissionSignIn(bool confirmStatus = default(bool), string id = default(string))
        {
            this.ConfirmStatus = confirmStatus;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets ConfirmStatus
        /// </summary>
        [DataMember(Name = "confirmStatus", EmitDefaultValue = false)]
        public bool ConfirmStatus { get; set; }

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
            sb.Append("class ConfirmPermissionSignIn {\n");
            sb.Append("  ConfirmStatus: ").Append(ConfirmStatus).Append("\n");
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
            return this.Equals(input as ConfirmPermissionSignIn);
        }

        /// <summary>
        /// Returns true if ConfirmPermissionSignIn instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfirmPermissionSignIn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmPermissionSignIn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfirmStatus == input.ConfirmStatus ||
                    this.ConfirmStatus.Equals(input.ConfirmStatus)
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
                hashCode = hashCode * 59 + this.ConfirmStatus.GetHashCode();
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
