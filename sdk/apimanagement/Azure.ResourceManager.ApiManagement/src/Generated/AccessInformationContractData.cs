// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the AccessInformationContract data model. </summary>
    public partial class AccessInformationContractData : ResourceData
    {
        /// <summary> Initializes a new instance of AccessInformationContractData. </summary>
        public AccessInformationContractData()
        {
        }

        /// <summary> Initializes a new instance of AccessInformationContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="idPropertiesId"> Access Information type (&apos;access&apos; or &apos;gitAccess&apos;). </param>
        /// <param name="principalId"> Principal (User) Identifier. </param>
        /// <param name="enabled"> Determines whether direct access is enabled. </param>
        internal AccessInformationContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string idPropertiesId, string principalId, bool? enabled) : base(id, name, resourceType, systemData)
        {
            IdPropertiesId = idPropertiesId;
            PrincipalId = principalId;
            Enabled = enabled;
        }

        /// <summary> Access Information type (&apos;access&apos; or &apos;gitAccess&apos;). </summary>
        public string IdPropertiesId { get; set; }
        /// <summary> Principal (User) Identifier. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Determines whether direct access is enabled. </summary>
        public bool? Enabled { get; set; }
    }
}
