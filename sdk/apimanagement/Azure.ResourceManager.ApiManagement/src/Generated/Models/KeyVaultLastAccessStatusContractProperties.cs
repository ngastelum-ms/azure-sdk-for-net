// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Issue contract Update Properties. </summary>
    public partial class KeyVaultLastAccessStatusContractProperties
    {
        /// <summary> Initializes a new instance of KeyVaultLastAccessStatusContractProperties. </summary>
        public KeyVaultLastAccessStatusContractProperties()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultLastAccessStatusContractProperties. </summary>
        /// <param name="code"> Last status code for sync and refresh of secret from key vault. </param>
        /// <param name="message"> Details of the error else empty. </param>
        /// <param name="timeStampUtc">
        /// Last time secret was accessed. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </param>
        internal KeyVaultLastAccessStatusContractProperties(string code, string message, DateTimeOffset? timeStampUtc)
        {
            Code = code;
            Message = message;
            TimeStampUtc = timeStampUtc;
        }

        /// <summary> Last status code for sync and refresh of secret from key vault. </summary>
        public string Code { get; set; }
        /// <summary> Details of the error else empty. </summary>
        public string Message { get; set; }
        /// <summary>
        /// Last time secret was accessed. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </summary>
        public DateTimeOffset? TimeStampUtc { get; set; }
    }
}
