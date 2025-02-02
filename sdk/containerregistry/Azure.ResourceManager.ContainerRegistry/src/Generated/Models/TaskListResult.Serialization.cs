// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    internal partial class TaskListResult
    {
        internal static TaskListResult DeserializeTaskListResult(JsonElement element)
        {
            Optional<IReadOnlyList<TaskData>> value = default;
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
                    List<TaskData> array = new List<TaskData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TaskData.DeserializeTaskData(item));
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
            return new TaskListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
