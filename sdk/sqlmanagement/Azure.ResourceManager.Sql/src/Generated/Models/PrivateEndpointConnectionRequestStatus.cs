// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the private endpoint connection requests status. </summary>
    public partial class PrivateEndpointConnectionRequestStatus
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionRequestStatus. </summary>
        internal PrivateEndpointConnectionRequestStatus()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionRequestStatus. </summary>
        /// <param name="privateLinkServiceId"> Resource id for which the private endpoint is created. </param>
        /// <param name="privateEndpointConnectionName"> The connection name for the private endpoint. </param>
        /// <param name="status"> Status of this private endpoint connection. </param>
        internal PrivateEndpointConnectionRequestStatus(ResourceIdentifier privateLinkServiceId, string privateEndpointConnectionName, string status)
        {
            PrivateLinkServiceId = privateLinkServiceId;
            PrivateEndpointConnectionName = privateEndpointConnectionName;
            Status = status;
        }

        /// <summary> Resource id for which the private endpoint is created. </summary>
        public ResourceIdentifier PrivateLinkServiceId { get; }
        /// <summary> The connection name for the private endpoint. </summary>
        public string PrivateEndpointConnectionName { get; }
        /// <summary> Status of this private endpoint connection. </summary>
        public string Status { get; }
    }
}
