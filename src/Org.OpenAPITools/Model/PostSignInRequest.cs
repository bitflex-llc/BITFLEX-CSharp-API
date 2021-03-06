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
    /// PostSignInRequest
    /// </summary>
    [DataContract(Name = "PostSignInRequest")]
    public partial class PostSignInRequest : IEquatable<PostSignInRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSignInRequest" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="signalRConnectionId">signalRConnectionId.</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="reCaptchav3Token">reCaptchav3Token.</param>
        public PostSignInRequest(string email = default(string), string password = default(string), string signalRConnectionId = default(string), string publicKey = default(string), string reCaptchav3Token = default(string))
        {
            this.Email = email;
            this.Password = password;
            this.SignalRConnectionId = signalRConnectionId;
            this.PublicKey = publicKey;
            this.ReCaptchav3Token = reCaptchav3Token;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets SignalRConnectionId
        /// </summary>
        [DataMember(Name = "signalRConnectionId", EmitDefaultValue = true)]
        public string SignalRConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name = "publicKey", EmitDefaultValue = true)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets ReCaptchav3Token
        /// </summary>
        [DataMember(Name = "reCaptchav3Token", EmitDefaultValue = true)]
        public string ReCaptchav3Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostSignInRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SignalRConnectionId: ").Append(SignalRConnectionId).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  ReCaptchav3Token: ").Append(ReCaptchav3Token).Append("\n");
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
            return this.Equals(input as PostSignInRequest);
        }

        /// <summary>
        /// Returns true if PostSignInRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostSignInRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSignInRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SignalRConnectionId == input.SignalRConnectionId ||
                    (this.SignalRConnectionId != null &&
                    this.SignalRConnectionId.Equals(input.SignalRConnectionId))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.ReCaptchav3Token == input.ReCaptchav3Token ||
                    (this.ReCaptchav3Token != null &&
                    this.ReCaptchav3Token.Equals(input.ReCaptchav3Token))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SignalRConnectionId != null)
                    hashCode = hashCode * 59 + this.SignalRConnectionId.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.ReCaptchav3Token != null)
                    hashCode = hashCode * 59 + this.ReCaptchav3Token.GetHashCode();
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
