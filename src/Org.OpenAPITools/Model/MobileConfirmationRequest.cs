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
    /// MobileConfirmationRequest
    /// </summary>
    [DataContract(Name = "MobileConfirmationRequest")]
    public partial class MobileConfirmationRequest : IEquatable<MobileConfirmationRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public RequestType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileConfirmationRequest" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="signalRConnectionId">signalRConnectionId.</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="encryptedToken">encryptedToken.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="clientInfo">clientInfo.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="location">location.</param>
        /// <param name="deviceDescription">deviceDescription.</param>
        /// <param name="requested">requested.</param>
        /// <param name="type">type.</param>
        public MobileConfirmationRequest(string userId = default(string), string signalRConnectionId = default(string), string publicKey = default(string), string encryptedToken = default(string), string ipAddress = default(string), ClientInfo clientInfo = default(ClientInfo), double latitude = default(double), double longitude = default(double), string location = default(string), string deviceDescription = default(string), bool requested = default(bool), RequestType? type = default(RequestType?))
        {
            this.UserId = userId;
            this.SignalRConnectionId = signalRConnectionId;
            this.PublicKey = publicKey;
            this.EncryptedToken = encryptedToken;
            this.IpAddress = ipAddress;
            this.ClientInfo = clientInfo;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Location = location;
            this.DeviceDescription = deviceDescription;
            this.Requested = requested;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

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
        /// Gets or Sets EncryptedToken
        /// </summary>
        [DataMember(Name = "encryptedToken", EmitDefaultValue = true)]
        public string EncryptedToken { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ipAddress", EmitDefaultValue = true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets ClientInfo
        /// </summary>
        [DataMember(Name = "clientInfo", EmitDefaultValue = false)]
        public ClientInfo ClientInfo { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets DeviceDescription
        /// </summary>
        [DataMember(Name = "deviceDescription", EmitDefaultValue = true)]
        public string DeviceDescription { get; set; }

        /// <summary>
        /// Gets or Sets Requested
        /// </summary>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public bool Requested { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileConfirmationRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SignalRConnectionId: ").Append(SignalRConnectionId).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  EncryptedToken: ").Append(EncryptedToken).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ClientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DeviceDescription: ").Append(DeviceDescription).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MobileConfirmationRequest);
        }

        /// <summary>
        /// Returns true if MobileConfirmationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileConfirmationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileConfirmationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                    this.EncryptedToken == input.EncryptedToken ||
                    (this.EncryptedToken != null &&
                    this.EncryptedToken.Equals(input.EncryptedToken))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.ClientInfo == input.ClientInfo ||
                    (this.ClientInfo != null &&
                    this.ClientInfo.Equals(input.ClientInfo))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.DeviceDescription == input.DeviceDescription ||
                    (this.DeviceDescription != null &&
                    this.DeviceDescription.Equals(input.DeviceDescription))
                ) && 
                (
                    this.Requested == input.Requested ||
                    this.Requested.Equals(input.Requested)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.SignalRConnectionId != null)
                    hashCode = hashCode * 59 + this.SignalRConnectionId.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.EncryptedToken != null)
                    hashCode = hashCode * 59 + this.EncryptedToken.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.ClientInfo != null)
                    hashCode = hashCode * 59 + this.ClientInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.DeviceDescription != null)
                    hashCode = hashCode * 59 + this.DeviceDescription.GetHashCode();
                hashCode = hashCode * 59 + this.Requested.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
