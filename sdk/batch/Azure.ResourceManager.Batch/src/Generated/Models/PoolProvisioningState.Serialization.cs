// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class PoolProvisioningStateExtensions
    {
        public static string ToSerialString(this PoolProvisioningState value) => value switch
        {
            PoolProvisioningState.Succeeded => "Succeeded",
            PoolProvisioningState.Deleting => "Deleting",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PoolProvisioningState value.")
        };

        public static PoolProvisioningState ToPoolProvisioningState(this string value)
        {
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return PoolProvisioningState.Succeeded;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return PoolProvisioningState.Deleting;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PoolProvisioningState value.");
        }
    }
}
