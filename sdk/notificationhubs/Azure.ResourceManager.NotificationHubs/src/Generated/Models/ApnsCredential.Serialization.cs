// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class ApnsCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ApnsCertificate))
            {
                writer.WritePropertyName("apnsCertificate");
                writer.WriteStringValue(ApnsCertificate);
            }
            if (Optional.IsDefined(CertificateKey))
            {
                writer.WritePropertyName("certificateKey");
                writer.WriteStringValue(CertificateKey);
            }
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint");
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint");
                writer.WriteStringValue(Thumbprint);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId");
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(AppName))
            {
                writer.WritePropertyName("appName");
                writer.WriteStringValue(AppName);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId");
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token");
                writer.WriteStringValue(Token);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApnsCredential DeserializeApnsCredential(JsonElement element)
        {
            Optional<string> apnsCertificate = default;
            Optional<string> certificateKey = default;
            Optional<string> endpoint = default;
            Optional<string> thumbprint = default;
            Optional<string> keyId = default;
            Optional<string> appName = default;
            Optional<string> appId = default;
            Optional<string> token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("apnsCertificate"))
                        {
                            apnsCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certificateKey"))
                        {
                            certificateKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpoint"))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyId"))
                        {
                            keyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appName"))
                        {
                            appName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appId"))
                        {
                            appId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("token"))
                        {
                            token = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApnsCredential(apnsCertificate.Value, certificateKey.Value, endpoint.Value, thumbprint.Value, keyId.Value, appName.Value, appId.Value, token.Value);
        }
    }
}
