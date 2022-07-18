// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class VirtualMachineFamilyCoreQuota
    {
        internal static VirtualMachineFamilyCoreQuota DeserializeVirtualMachineFamilyCoreQuota(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> coreQuota = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreQuota"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    coreQuota = property.Value.GetInt32();
                    continue;
                }
            }
            return new VirtualMachineFamilyCoreQuota(name.Value, Optional.ToNullable(coreQuota));
        }
    }
}
