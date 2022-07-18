// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class JobStatus
    {
        internal static JobStatus DeserializeJobStatus(JsonElement element)
        {
            Optional<JobName> jobName = default;
            Optional<string> jobProgress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobName = new JobName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobProgress"))
                {
                    jobProgress = property.Value.GetString();
                    continue;
                }
            }
            return new JobStatus(Optional.ToNullable(jobName), jobProgress.Value);
        }
    }
}
