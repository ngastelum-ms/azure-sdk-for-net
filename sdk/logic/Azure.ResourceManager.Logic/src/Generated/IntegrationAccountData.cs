// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class representing the IntegrationAccount data model. </summary>
    public partial class IntegrationAccountData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationAccountData. </summary>
        /// <param name="location"> The location. </param>
        public IntegrationAccountData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of IntegrationAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku. </param>
        /// <param name="integrationServiceEnvironment"> The integration service environment. </param>
        /// <param name="state"> The workflow state. </param>
        internal IntegrationAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IntegrationAccountSku sku, ResourceReference integrationServiceEnvironment, WorkflowState? state) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            IntegrationServiceEnvironment = integrationServiceEnvironment;
            State = state;
        }

        /// <summary> The sku. </summary>
        internal IntegrationAccountSku Sku { get; set; }
        /// <summary> The sku name. </summary>
        public IntegrationAccountSkuName? SkuName
        {
            get => Sku is null ? default(IntegrationAccountSkuName?) : Sku.Name;
            set
            {
                Sku = value.HasValue ? new IntegrationAccountSku(value.Value) : null;
            }
        }

        /// <summary> The integration service environment. </summary>
        public ResourceReference IntegrationServiceEnvironment { get; set; }
        /// <summary> The workflow state. </summary>
        public WorkflowState? State { get; set; }
    }
}
