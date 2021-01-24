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
    /// IDbContextTransaction
    /// </summary>
    [DataContract(Name = "IDbContextTransaction")]
    public partial class IDbContextTransaction : IEquatable<IDbContextTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IDbContextTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public IDbContextTransaction()
        {
        }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public Guid TransactionId { get; private set; }

        /// <summary>
        /// Returns false as TransactionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionId()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets SupportsSavepoints
        /// </summary>
        [DataMember(Name = "supportsSavepoints", EmitDefaultValue = false)]
        public bool SupportsSavepoints { get; private set; }

        /// <summary>
        /// Returns false as SupportsSavepoints should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSupportsSavepoints()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IDbContextTransaction {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  SupportsSavepoints: ").Append(SupportsSavepoints).Append("\n");
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
            return this.Equals(input as IDbContextTransaction);
        }

        /// <summary>
        /// Returns true if IDbContextTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of IDbContextTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IDbContextTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.SupportsSavepoints == input.SupportsSavepoints ||
                    this.SupportsSavepoints.Equals(input.SupportsSavepoints)
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.SupportsSavepoints.GetHashCode();
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