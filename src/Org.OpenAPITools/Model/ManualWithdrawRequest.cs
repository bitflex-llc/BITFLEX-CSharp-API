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
    /// ManualWithdrawRequest
    /// </summary>
    [DataContract(Name = "ManualWithdrawRequest")]
    public partial class ManualWithdrawRequest : IEquatable<ManualWithdrawRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualWithdrawRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="amount">amount.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="paid">paid.</param>
        /// <param name="datePaid">datePaid.</param>
        /// <param name="information">information.</param>
        public ManualWithdrawRequest(string id = default(string), string currencyId = default(string), string userId = default(string), double amount = default(double), long dateCreated = default(long), bool paid = default(bool), long? datePaid = default(long?), string information = default(string))
        {
            this.Id = id;
            this.CurrencyId = currencyId;
            this.UserId = userId;
            this.Amount = amount;
            this.DateCreated = dateCreated;
            this.Paid = paid;
            this.DatePaid = datePaid;
            this.Information = information;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "currencyId", EmitDefaultValue = true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        public long DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name = "paid", EmitDefaultValue = false)]
        public bool Paid { get; set; }

        /// <summary>
        /// Gets or Sets DatePaid
        /// </summary>
        [DataMember(Name = "datePaid", EmitDefaultValue = true)]
        public long? DatePaid { get; set; }

        /// <summary>
        /// Gets or Sets Information
        /// </summary>
        [DataMember(Name = "information", EmitDefaultValue = true)]
        public string Information { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualWithdrawRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  DatePaid: ").Append(DatePaid).Append("\n");
            sb.Append("  Information: ").Append(Information).Append("\n");
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
            return this.Equals(input as ManualWithdrawRequest);
        }

        /// <summary>
        /// Returns true if ManualWithdrawRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualWithdrawRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualWithdrawRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    this.DateCreated.Equals(input.DateCreated)
                ) && 
                (
                    this.Paid == input.Paid ||
                    this.Paid.Equals(input.Paid)
                ) && 
                (
                    this.DatePaid == input.DatePaid ||
                    (this.DatePaid != null &&
                    this.DatePaid.Equals(input.DatePaid))
                ) && 
                (
                    this.Information == input.Information ||
                    (this.Information != null &&
                    this.Information.Equals(input.Information))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                hashCode = hashCode * 59 + this.Paid.GetHashCode();
                if (this.DatePaid != null)
                    hashCode = hashCode * 59 + this.DatePaid.GetHashCode();
                if (this.Information != null)
                    hashCode = hashCode * 59 + this.Information.GetHashCode();
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