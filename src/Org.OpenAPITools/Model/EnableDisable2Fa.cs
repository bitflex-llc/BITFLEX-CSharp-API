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
    /// EnableDisable2Fa
    /// </summary>
    [DataContract(Name = "EnableDisable2Fa")]
    public partial class EnableDisable2Fa : IEquatable<EnableDisable2Fa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnableDisable2Fa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnableDisable2Fa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnableDisable2Fa" /> class.
        /// </summary>
        /// <param name="clientCode">clientCode (required).</param>
        /// <param name="pincode">pincode (required).</param>
        /// <param name="backupCode">backupCode (required).</param>
        public EnableDisable2Fa(string clientCode = default(string), string pincode = default(string), string backupCode = default(string))
        {
            // to ensure "clientCode" is required (not null)
            this.ClientCode = clientCode ?? throw new ArgumentNullException("clientCode is a required property for EnableDisable2Fa and cannot be null");
            // to ensure "pincode" is required (not null)
            this.Pincode = pincode ?? throw new ArgumentNullException("pincode is a required property for EnableDisable2Fa and cannot be null");
            // to ensure "backupCode" is required (not null)
            this.BackupCode = backupCode ?? throw new ArgumentNullException("backupCode is a required property for EnableDisable2Fa and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ClientCode
        /// </summary>
        [DataMember(Name = "clientCode", IsRequired = true, EmitDefaultValue = false)]
        public string ClientCode { get; set; }

        /// <summary>
        /// Gets or Sets Pincode
        /// </summary>
        [DataMember(Name = "pincode", IsRequired = true, EmitDefaultValue = false)]
        public string Pincode { get; set; }

        /// <summary>
        /// Gets or Sets BackupCode
        /// </summary>
        [DataMember(Name = "backupCode", IsRequired = true, EmitDefaultValue = false)]
        public string BackupCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableDisable2Fa {\n");
            sb.Append("  ClientCode: ").Append(ClientCode).Append("\n");
            sb.Append("  Pincode: ").Append(Pincode).Append("\n");
            sb.Append("  BackupCode: ").Append(BackupCode).Append("\n");
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
            return this.Equals(input as EnableDisable2Fa);
        }

        /// <summary>
        /// Returns true if EnableDisable2Fa instances are equal
        /// </summary>
        /// <param name="input">Instance of EnableDisable2Fa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnableDisable2Fa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientCode == input.ClientCode ||
                    (this.ClientCode != null &&
                    this.ClientCode.Equals(input.ClientCode))
                ) && 
                (
                    this.Pincode == input.Pincode ||
                    (this.Pincode != null &&
                    this.Pincode.Equals(input.Pincode))
                ) && 
                (
                    this.BackupCode == input.BackupCode ||
                    (this.BackupCode != null &&
                    this.BackupCode.Equals(input.BackupCode))
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
                if (this.ClientCode != null)
                    hashCode = hashCode * 59 + this.ClientCode.GetHashCode();
                if (this.Pincode != null)
                    hashCode = hashCode * 59 + this.Pincode.GetHashCode();
                if (this.BackupCode != null)
                    hashCode = hashCode * 59 + this.BackupCode.GetHashCode();
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
