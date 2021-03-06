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
    /// UserAgent
    /// </summary>
    [DataContract(Name = "UserAgent")]
    public partial class UserAgent : IEquatable<UserAgent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UserAgent()
        {
        }

        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name = "family", EmitDefaultValue = true)]
        public string Family { get; private set; }

        /// <summary>
        /// Returns false as Family should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFamily()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name = "major", EmitDefaultValue = true)]
        public string Major { get; private set; }

        /// <summary>
        /// Returns false as Major should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMajor()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Minor
        /// </summary>
        [DataMember(Name = "minor", EmitDefaultValue = true)]
        public string Minor { get; private set; }

        /// <summary>
        /// Returns false as Minor should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinor()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Patch
        /// </summary>
        [DataMember(Name = "patch", EmitDefaultValue = true)]
        public string Patch { get; private set; }

        /// <summary>
        /// Returns false as Patch should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePatch()
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
            sb.Append("class UserAgent {\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  Major: ").Append(Major).Append("\n");
            sb.Append("  Minor: ").Append(Minor).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
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
            return this.Equals(input as UserAgent);
        }

        /// <summary>
        /// Returns true if UserAgent instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAgent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Family == input.Family ||
                    (this.Family != null &&
                    this.Family.Equals(input.Family))
                ) && 
                (
                    this.Major == input.Major ||
                    (this.Major != null &&
                    this.Major.Equals(input.Major))
                ) && 
                (
                    this.Minor == input.Minor ||
                    (this.Minor != null &&
                    this.Minor.Equals(input.Minor))
                ) && 
                (
                    this.Patch == input.Patch ||
                    (this.Patch != null &&
                    this.Patch.Equals(input.Patch))
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
                if (this.Family != null)
                    hashCode = hashCode * 59 + this.Family.GetHashCode();
                if (this.Major != null)
                    hashCode = hashCode * 59 + this.Major.GetHashCode();
                if (this.Minor != null)
                    hashCode = hashCode * 59 + this.Minor.GetHashCode();
                if (this.Patch != null)
                    hashCode = hashCode * 59 + this.Patch.GetHashCode();
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
