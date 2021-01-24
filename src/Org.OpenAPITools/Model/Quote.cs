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
    /// Quote
    /// </summary>
    [DataContract(Name = "Quote")]
    public partial class Quote : IEquatable<Quote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="pairId">pairId.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="open">open.</param>
        /// <param name="high">high.</param>
        /// <param name="low">low.</param>
        /// <param name="close">close.</param>
        /// <param name="volume">volume.</param>
        /// <param name="pairVolume">pairVolume.</param>
        public Quote(string id = default(string), string pairId = default(string), long timestamp = default(long), double open = default(double), double high = default(double), double low = default(double), double close = default(double), double volume = default(double), double pairVolume = default(double))
        {
            this.Id = id;
            this.PairId = pairId;
            this.Timestamp = timestamp;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
            this.PairVolume = pairVolume;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PairId
        /// </summary>
        [DataMember(Name = "pairId", EmitDefaultValue = true)]
        public string PairId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public long Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public double Open { get; set; }

        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public double High { get; set; }

        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public double Low { get; set; }

        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public double Close { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public double Volume { get; set; }

        /// <summary>
        /// Gets or Sets PairVolume
        /// </summary>
        [DataMember(Name = "pairVolume", EmitDefaultValue = false)]
        public double PairVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PairId: ").Append(PairId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  PairVolume: ").Append(PairVolume).Append("\n");
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
            return this.Equals(input as Quote);
        }

        /// <summary>
        /// Returns true if Quote instances are equal
        /// </summary>
        /// <param name="input">Instance of Quote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quote input)
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
                    this.PairId == input.PairId ||
                    (this.PairId != null &&
                    this.PairId.Equals(input.PairId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.Open == input.Open ||
                    this.Open.Equals(input.Open)
                ) && 
                (
                    this.High == input.High ||
                    this.High.Equals(input.High)
                ) && 
                (
                    this.Low == input.Low ||
                    this.Low.Equals(input.Low)
                ) && 
                (
                    this.Close == input.Close ||
                    this.Close.Equals(input.Close)
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
                ) && 
                (
                    this.PairVolume == input.PairVolume ||
                    this.PairVolume.Equals(input.PairVolume)
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
                if (this.PairId != null)
                    hashCode = hashCode * 59 + this.PairId.GetHashCode();
                hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                hashCode = hashCode * 59 + this.Open.GetHashCode();
                hashCode = hashCode * 59 + this.High.GetHashCode();
                hashCode = hashCode * 59 + this.Low.GetHashCode();
                hashCode = hashCode * 59 + this.Close.GetHashCode();
                hashCode = hashCode * 59 + this.Volume.GetHashCode();
                hashCode = hashCode * 59 + this.PairVolume.GetHashCode();
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
