// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class JobCollection
    {
        internal static JobCollection DeserializeJobCollection(JsonElement element)
        {
            Optional<IReadOnlyList<JobData>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobData> array = new List<JobData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobData.DeserializeJobData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new JobCollection(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
