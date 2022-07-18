// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Security.ConfidentialLedger.Certificate
{
    /// <summary> Client options for ConfidentialLedger library clients. </summary>
    public partial class ConfidentialLedgerCertificateClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_05_13;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-05-13". </summary>
            V2022_05_13 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of ConfidentialLedgerClientOptions. </summary>
        public ConfidentialLedgerCertificateClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_05_13 => "2022-05-13",
                _ => throw new NotSupportedException()
            };
        }
    }
}
