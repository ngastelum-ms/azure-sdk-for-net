// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Network access profile for Batch endpoint. </summary>
    public partial class EndpointAccessProfile
    {
        /// <summary> Initializes a new instance of EndpointAccessProfile. </summary>
        /// <param name="defaultAction"> Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled. </param>
        public EndpointAccessProfile(EndpointAccessDefaultAction defaultAction)
        {
            DefaultAction = defaultAction;
            IPRules = new ChangeTrackingList<IPRule>();
        }

        /// <summary> Initializes a new instance of EndpointAccessProfile. </summary>
        /// <param name="defaultAction"> Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled. </param>
        /// <param name="ipRules"> Array of IP ranges to filter client IP address. </param>
        internal EndpointAccessProfile(EndpointAccessDefaultAction defaultAction, IList<IPRule> ipRules)
        {
            DefaultAction = defaultAction;
            IPRules = ipRules;
        }

        /// <summary> Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled. </summary>
        public EndpointAccessDefaultAction DefaultAction { get; set; }
        /// <summary> Array of IP ranges to filter client IP address. </summary>
        public IList<IPRule> IPRules { get; }
    }
}
