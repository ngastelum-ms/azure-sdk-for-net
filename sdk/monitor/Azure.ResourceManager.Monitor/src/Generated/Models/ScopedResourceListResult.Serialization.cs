// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class ScopedResourceListResult
    {
        internal static ScopedResourceListResult DeserializeScopedResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateLinkScopedResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrivateLinkScopedResourceData> array = new List<PrivateLinkScopedResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkScopedResourceData.DeserializePrivateLinkScopedResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ScopedResourceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
