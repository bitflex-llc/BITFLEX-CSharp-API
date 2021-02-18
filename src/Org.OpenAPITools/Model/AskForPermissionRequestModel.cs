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
    /// AskForPermissionRequestModel
    /// </summary>
    [DataContract(Name = "AskForPermissionRequestModel")]
    public partial class AskForPermissionRequestModel : IEquatable<AskForPermissionRequestModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public DevicePermissionRequestType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AskForPermissionRequestModel" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="bitflexDeviceId">bitflexDeviceId.</param>
        /// <param name="terminalSignalRConnectionId">terminalSignalRConnectionId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="clientInfo">clientInfo.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="location">location.</param>
        /// <param name="deviceDescription">deviceDescription.</param>
        public AskForPermissionRequestModel(DevicePermissionRequestType? type = default(DevicePermissionRequestType?), string bitflexDeviceId = default(string), string terminalSignalRConnectionId = default(string), string userId = default(string), string ipAddress = default(string), ClientInfo clientInfo = default(ClientInfo), double latitude = default(double), double longitude = default(double), string location = default(string), string deviceDescription = default(string))
        {
            this.Type = type;
            this.BitflexDeviceId = bitflexDeviceId;
            this.TerminalSignalRConnectionId = terminalSignalRConnectionId;
            this.UserId = userId;
            this.IpAddress = ipAddress;
            this.ClientInfo = clientInfo;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Location = location;
            this.DeviceDescription = deviceDescription;
        }

        /// <summary>
        /// Gets or Sets BitflexDeviceId
        /// </summary>
        [DataMember(Name = "bitflexDeviceId", EmitDefaultValue = true)]
        public string BitflexDeviceId { get; set; }

        /// <summary>
        /// Gets or Sets TerminalSignalRConnectionId
        /// </summary>
        [DataMember(Name = "terminalSignalRConnectionId", EmitDefaultValue = true)]
        public string TerminalSignalRConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AskForPermissionRequestModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BitflexDeviceId: ").Append(BitflexDeviceId).Append("\n");
            sb.Append("  TerminalSignalRConnectionId: ").Append(TerminalSignalRConnectionId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ClientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DeviceDescription: ").Append(DeviceDescription).Append("\n");
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
            return this.Equals(input as AskForPermissionRequestModel);
        }

        /// <summary>
        /// Returns true if AskForPermissionRequestModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AskForPermissionRequestModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AskForPermissionRequestModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.BitflexDeviceId == input.BitflexDeviceId ||
                    (this.BitflexDeviceId != null &&
                    this.BitflexDeviceId.Equals(input.BitflexDeviceId))
                ) && 
                (
                    this.TerminalSignalRConnectionId == input.TerminalSignalRConnectionId ||
                    (this.TerminalSignalRConnectionId != null &&
                    this.TerminalSignalRConnectionId.Equals(input.TerminalSignalRConnectionId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BitflexDeviceId != null)
                    hashCode = hashCode * 59 + this.BitflexDeviceId.GetHashCode();
                if (this.TerminalSignalRConnectionId != null)
                    hashCode = hashCode * 59 + this.TerminalSignalRConnectionId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
