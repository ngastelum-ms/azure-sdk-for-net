// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RegistryStatistics
    {
        internal static RegistryStatistics DeserializeRegistryStatistics(JsonElement element)
        {
            Optional<long> totalDeviceCount = default;
            Optional<long> enabledDeviceCount = default;
            Optional<long> disabledDeviceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeviceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enabledDeviceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("disabledDeviceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new RegistryStatistics(Optional.ToNullable(totalDeviceCount), Optional.ToNullable(enabledDeviceCount), Optional.ToNullable(disabledDeviceCount));
        }
    }
}
