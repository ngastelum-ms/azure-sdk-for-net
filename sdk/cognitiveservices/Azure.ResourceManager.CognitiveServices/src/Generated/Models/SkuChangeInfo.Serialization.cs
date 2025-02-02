// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class SkuChangeInfo
    {
        internal static SkuChangeInfo DeserializeSkuChangeInfo(JsonElement element)
        {
            Optional<float> countOfDowngrades = default;
            Optional<float> countOfUpgradesAfterDowngrades = default;
            Optional<string> lastChangeDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countOfDowngrades"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    countOfDowngrades = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("countOfUpgradesAfterDowngrades"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    countOfUpgradesAfterDowngrades = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lastChangeDate"))
                {
                    lastChangeDate = property.Value.GetString();
                    continue;
                }
            }
            return new SkuChangeInfo(Optional.ToNullable(countOfDowngrades), Optional.ToNullable(countOfUpgradesAfterDowngrades), lastChangeDate.Value);
        }
    }
}
