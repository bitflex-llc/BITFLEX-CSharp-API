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
    /// Defines UserAdminCommand
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserAdminCommand
    {
        /// <summary>
        /// Enum BlockUser for value: BlockUser
        /// </summary>
        [EnumMember(Value = "BlockUser")]
        BlockUser = 1,

        /// <summary>
        /// Enum UnblockUser for value: UnblockUser
        /// </summary>
        [EnumMember(Value = "UnblockUser")]
        UnblockUser = 2,

        /// <summary>
        /// Enum VerifyEmail for value: VerifyEmail
        /// </summary>
        [EnumMember(Value = "VerifyEmail")]
        VerifyEmail = 3,

        /// <summary>
        /// Enum TwoFactorDisable for value: TwoFactorDisable
        /// </summary>
        [EnumMember(Value = "TwoFactorDisable")]
        TwoFactorDisable = 4,

        /// <summary>
        /// Enum ResetPassword for value: ResetPassword
        /// </summary>
        [EnumMember(Value = "ResetPassword")]
        ResetPassword = 5

    }

}
