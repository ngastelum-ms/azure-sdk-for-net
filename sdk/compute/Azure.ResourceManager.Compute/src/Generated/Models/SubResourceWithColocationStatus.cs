// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The SubResourceWithColocationStatus. </summary>
    public partial class SubResourceWithColocationStatus : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of SubResourceWithColocationStatus. </summary>
        public SubResourceWithColocationStatus()
        {
        }

        /// <summary> Initializes a new instance of SubResourceWithColocationStatus. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="colocationStatus"> Describes colocation status of a resource in the Proximity Placement Group. </param>
        internal SubResourceWithColocationStatus(string id, InstanceViewStatus colocationStatus) : base(id)
        {
            ColocationStatus = colocationStatus;
        }

        /// <summary> Describes colocation status of a resource in the Proximity Placement Group. </summary>
        public InstanceViewStatus ColocationStatus { get; set; }
    }
}
