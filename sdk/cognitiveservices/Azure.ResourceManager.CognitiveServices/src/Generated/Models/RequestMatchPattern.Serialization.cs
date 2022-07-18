// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class RequestMatchPattern
    {
        internal static RequestMatchPattern DeserializeRequestMatchPattern(JsonElement element)
        {
            Optional<string> path = default;
            Optional<string> method = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"))
                {
                    method = property.Value.GetString();
                    continue;
                }
            }
            return new RequestMatchPattern(path.Value, method.Value);
        }
    }
}
