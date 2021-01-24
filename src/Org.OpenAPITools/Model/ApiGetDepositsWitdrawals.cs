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
    /// ApiGetDepositsWitdrawals
    /// </summary>
    [DataContract(Name = "ApiGetDepositsWitdrawals")]
    public partial class ApiGetDepositsWitdrawals : IEquatable<ApiGetDepositsWitdrawals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiGetDepositsWitdrawals" /> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="amount">amount.</param>
        /// <param name="blockExURL">blockExURL.</param>
        /// <param name="txId">txId.</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="pending">pending.</param>
        public ApiGetDepositsWitdrawals(string currency = default(string), double amount = default(double), string blockExURL = default(string), string txId = default(string), long dateTime = default(long), bool pending = default(bool))
        {
            this.Currency = currency;
            this.Amount = amount;
            this.BlockExURL = blockExURL;
            this.TxId = txId;
            this.DateTime = dateTime;
            this.Pending = pending;
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets BlockExURL
        /// </summary>
        [DataMember(Name = "blockExURL", EmitDefaultValue = true)]
        public string BlockExURL { get; set; }

        /// <summary>
        /// Gets or Sets TxId
        /// </summary>
        [DataMember(Name = "txId", EmitDefaultValue = true)]
        public string TxId { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public long DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Pending
        /// </summary>
        [DataMember(Name = "pending", EmitDefaultValue = false)]
        public bool Pending { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiGetDepositsWitdrawals {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BlockExURL: ").Append(BlockExURL).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
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
            return this.Equals(input as ApiGetDepositsWitdrawals);
        }

        /// <summary>
        /// Returns true if ApiGetDepositsWitdrawals instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiGetDepositsWitdrawals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiGetDepositsWitdrawals input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.BlockExURL == input.BlockExURL ||
                    (this.BlockExURL != null &&
                    this.BlockExURL.Equals(input.BlockExURL))
                ) && 
                (
                    this.TxId == input.TxId ||
                    (this.TxId != null &&
                    this.TxId.Equals(input.TxId))
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    this.DateTime.Equals(input.DateTime)
                ) && 
                (
                    this.Pending == input.Pending ||
                    this.Pending.Equals(input.Pending)
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BlockExURL != null)
                    hashCode = hashCode * 59 + this.BlockExURL.GetHashCode();
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                hashCode = hashCode * 59 + this.Pending.GetHashCode();
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
