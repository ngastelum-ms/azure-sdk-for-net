// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class VmExtension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("publisher");
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("type");
            writer.WriteStringValue(VMExtensionType);
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion");
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(AutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion");
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Settings.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ProtectedSettings))
            {
                writer.WritePropertyName("protectedSettings");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ProtectedSettings.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(ProvisionAfterExtensions))
            {
                writer.WritePropertyName("provisionAfterExtensions");
                writer.WriteStartArray();
                foreach (var item in ProvisionAfterExtensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VmExtension DeserializeVmExtension(JsonElement element)
        {
            string name = default;
            string publisher = default;
            string type = default;
            Optional<string> typeHandlerVersion = default;
            Optional<bool> autoUpgradeMinorVersion = default;
            Optional<BinaryData> settings = default;
            Optional<BinaryData> protectedSettings = default;
            Optional<IList<string>> provisionAfterExtensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoUpgradeMinorVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    autoUpgradeMinorVersion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("settings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    settings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("protectedSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectedSettings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("provisionAfterExtensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    provisionAfterExtensions = array;
                    continue;
                }
            }
            return new VmExtension(name, publisher, type, typeHandlerVersion.Value, Optional.ToNullable(autoUpgradeMinorVersion), settings.Value, protectedSettings.Value, Optional.ToList(provisionAfterExtensions));
        }
    }
}
