// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class VolumeGroupVolumeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("creationToken");
            writer.WriteStringValue(CreationToken);
            if (Optional.IsDefined(ServiceLevel))
            {
                writer.WritePropertyName("serviceLevel");
                writer.WriteStringValue(ServiceLevel.Value.ToString());
            }
            writer.WritePropertyName("usageThreshold");
            writer.WriteNumberValue(UsageThreshold);
            if (Optional.IsDefined(ExportPolicy))
            {
                writer.WritePropertyName("exportPolicy");
                writer.WriteObjectValue(ExportPolicy);
            }
            if (Optional.IsCollectionDefined(ProtocolTypes))
            {
                writer.WritePropertyName("protocolTypes");
                writer.WriteStartArray();
                foreach (var item in ProtocolTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SnapshotId))
            {
                if (SnapshotId != null)
                {
                    writer.WritePropertyName("snapshotId");
                    writer.WriteStringValue(SnapshotId);
                }
                else
                {
                    writer.WriteNull("snapshotId");
                }
            }
            if (Optional.IsDefined(BackupId))
            {
                if (BackupId != null)
                {
                    writer.WritePropertyName("backupId");
                    writer.WriteStringValue(BackupId);
                }
                else
                {
                    writer.WriteNull("backupId");
                }
            }
            writer.WritePropertyName("subnetId");
            writer.WriteStringValue(SubnetId);
            if (Optional.IsDefined(NetworkFeatures))
            {
                writer.WritePropertyName("networkFeatures");
                writer.WriteStringValue(NetworkFeatures.Value.ToString());
            }
            if (Optional.IsDefined(VolumeType))
            {
                writer.WritePropertyName("volumeType");
                writer.WriteStringValue(VolumeType);
            }
            if (Optional.IsDefined(DataProtection))
            {
                writer.WritePropertyName("dataProtection");
                writer.WriteObjectValue(DataProtection);
            }
            if (Optional.IsDefined(IsRestoring))
            {
                writer.WritePropertyName("isRestoring");
                writer.WriteBooleanValue(IsRestoring.Value);
            }
            if (Optional.IsDefined(SnapshotDirectoryVisible))
            {
                writer.WritePropertyName("snapshotDirectoryVisible");
                writer.WriteBooleanValue(SnapshotDirectoryVisible.Value);
            }
            if (Optional.IsDefined(KerberosEnabled))
            {
                writer.WritePropertyName("kerberosEnabled");
                writer.WriteBooleanValue(KerberosEnabled.Value);
            }
            if (Optional.IsDefined(SecurityStyle))
            {
                writer.WritePropertyName("securityStyle");
                writer.WriteStringValue(SecurityStyle.Value.ToString());
            }
            if (Optional.IsDefined(SmbEncryption))
            {
                writer.WritePropertyName("smbEncryption");
                writer.WriteBooleanValue(SmbEncryption.Value);
            }
            if (Optional.IsDefined(SmbContinuouslyAvailable))
            {
                writer.WritePropertyName("smbContinuouslyAvailable");
                writer.WriteBooleanValue(SmbContinuouslyAvailable.Value);
            }
            if (Optional.IsDefined(ThroughputMibps))
            {
                writer.WritePropertyName("throughputMibps");
                writer.WriteNumberValue(ThroughputMibps.Value);
            }
            if (Optional.IsDefined(EncryptionKeySource))
            {
                writer.WritePropertyName("encryptionKeySource");
                writer.WriteStringValue(EncryptionKeySource.Value.ToString());
            }
            if (Optional.IsDefined(LdapEnabled))
            {
                writer.WritePropertyName("ldapEnabled");
                writer.WriteBooleanValue(LdapEnabled.Value);
            }
            if (Optional.IsDefined(CoolAccess))
            {
                writer.WritePropertyName("coolAccess");
                writer.WriteBooleanValue(CoolAccess.Value);
            }
            if (Optional.IsDefined(CoolnessPeriod))
            {
                writer.WritePropertyName("coolnessPeriod");
                writer.WriteNumberValue(CoolnessPeriod.Value);
            }
            if (Optional.IsDefined(UnixPermissions))
            {
                if (UnixPermissions != null)
                {
                    writer.WritePropertyName("unixPermissions");
                    writer.WriteStringValue(UnixPermissions);
                }
                else
                {
                    writer.WriteNull("unixPermissions");
                }
            }
            if (Optional.IsDefined(AvsDataStore))
            {
                writer.WritePropertyName("avsDataStore");
                writer.WriteStringValue(AvsDataStore.Value.ToString());
            }
            if (Optional.IsDefined(IsDefaultQuotaEnabled))
            {
                writer.WritePropertyName("isDefaultQuotaEnabled");
                writer.WriteBooleanValue(IsDefaultQuotaEnabled.Value);
            }
            if (Optional.IsDefined(DefaultUserQuotaInKiBs))
            {
                writer.WritePropertyName("defaultUserQuotaInKiBs");
                writer.WriteNumberValue(DefaultUserQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(DefaultGroupQuotaInKiBs))
            {
                writer.WritePropertyName("defaultGroupQuotaInKiBs");
                writer.WriteNumberValue(DefaultGroupQuotaInKiBs.Value);
            }
            if (Optional.IsDefined(CapacityPoolResourceId))
            {
                writer.WritePropertyName("capacityPoolResourceId");
                writer.WriteStringValue(CapacityPoolResourceId);
            }
            if (Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup");
                writer.WriteStringValue(ProximityPlacementGroup);
            }
            if (Optional.IsDefined(VolumeSpecName))
            {
                writer.WritePropertyName("volumeSpecName");
                writer.WriteStringValue(VolumeSpecName);
            }
            if (Optional.IsCollectionDefined(PlacementRules))
            {
                writer.WritePropertyName("placementRules");
                writer.WriteStartArray();
                foreach (var item in PlacementRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableSubvolumes))
            {
                writer.WritePropertyName("enableSubvolumes");
                writer.WriteStringValue(EnableSubvolumes.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VolumeGroupVolumeProperties DeserializeVolumeGroupVolumeProperties(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> fileSystemId = default;
            string creationToken = default;
            Optional<ServiceLevel> serviceLevel = default;
            long usageThreshold = default;
            Optional<VolumePropertiesExportPolicy> exportPolicy = default;
            Optional<IList<string>> protocolTypes = default;
            Optional<string> provisioningState = default;
            Optional<string> snapshotId = default;
            Optional<string> backupId = default;
            Optional<string> baremetalTenantId = default;
            string subnetId = default;
            Optional<NetworkFeature> networkFeatures = default;
            Optional<string> networkSiblingSetId = default;
            Optional<VolumeStorageToNetworkProximity> storageToNetworkProximity = default;
            Optional<IReadOnlyList<MountTargetProperties>> mountTargets = default;
            Optional<string> volumeType = default;
            Optional<VolumePropertiesDataProtection> dataProtection = default;
            Optional<bool> isRestoring = default;
            Optional<bool> snapshotDirectoryVisible = default;
            Optional<bool> kerberosEnabled = default;
            Optional<SecurityStyle> securityStyle = default;
            Optional<bool> smbEncryption = default;
            Optional<bool> smbContinuouslyAvailable = default;
            Optional<float> throughputMibps = default;
            Optional<EncryptionKeySource> encryptionKeySource = default;
            Optional<bool> ldapEnabled = default;
            Optional<bool> coolAccess = default;
            Optional<int> coolnessPeriod = default;
            Optional<string> unixPermissions = default;
            Optional<int?> cloneProgress = default;
            Optional<AvsDataStore> avsDataStore = default;
            Optional<bool> isDefaultQuotaEnabled = default;
            Optional<long> defaultUserQuotaInKiBs = default;
            Optional<long> defaultGroupQuotaInKiBs = default;
            Optional<long> maximumNumberOfFiles = default;
            Optional<string> volumeGroupName = default;
            Optional<string> capacityPoolResourceId = default;
            Optional<string> proximityPlacementGroup = default;
            Optional<string> t2Network = default;
            Optional<string> volumeSpecName = default;
            Optional<bool> encrypted = default;
            Optional<IList<PlacementKeyValuePairs>> placementRules = default;
            Optional<EnableSubvolume> enableSubvolumes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("fileSystemId"))
                        {
                            fileSystemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationToken"))
                        {
                            creationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serviceLevel = new ServiceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usageThreshold"))
                        {
                            usageThreshold = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("exportPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            exportPolicy = VolumePropertiesExportPolicy.DeserializeVolumePropertiesExportPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocolTypes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            protocolTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("snapshotId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                snapshotId = null;
                                continue;
                            }
                            snapshotId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                backupId = null;
                                continue;
                            }
                            backupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baremetalTenantId"))
                        {
                            baremetalTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetId"))
                        {
                            subnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkFeatures"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkFeatures = new NetworkFeature(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkSiblingSetId"))
                        {
                            networkSiblingSetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageToNetworkProximity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageToNetworkProximity = new VolumeStorageToNetworkProximity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mountTargets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<MountTargetProperties> array = new List<MountTargetProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MountTargetProperties.DeserializeMountTargetProperties(item));
                            }
                            mountTargets = array;
                            continue;
                        }
                        if (property0.NameEquals("volumeType"))
                        {
                            volumeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataProtection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataProtection = VolumePropertiesDataProtection.DeserializeVolumePropertiesDataProtection(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isRestoring"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isRestoring = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("snapshotDirectoryVisible"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            snapshotDirectoryVisible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("kerberosEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kerberosEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("securityStyle"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            securityStyle = new SecurityStyle(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbEncryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            smbEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("smbContinuouslyAvailable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            smbContinuouslyAvailable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("throughputMibps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            throughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKeySource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptionKeySource = new EncryptionKeySource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ldapEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ldapEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            coolAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolnessPeriod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            coolnessPeriod = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unixPermissions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                unixPermissions = null;
                                continue;
                            }
                            unixPermissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloneProgress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cloneProgress = null;
                                continue;
                            }
                            cloneProgress = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("avsDataStore"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            avsDataStore = new AvsDataStore(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDefaultQuotaEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDefaultQuotaEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultUserQuotaInKiBs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultUserQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("defaultGroupQuotaInKiBs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultGroupQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfFiles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumNumberOfFiles = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("volumeGroupName"))
                        {
                            volumeGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("capacityPoolResourceId"))
                        {
                            capacityPoolResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"))
                        {
                            proximityPlacementGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("t2Network"))
                        {
                            t2Network = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("volumeSpecName"))
                        {
                            volumeSpecName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encrypted"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encrypted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("placementRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PlacementKeyValuePairs> array = new List<PlacementKeyValuePairs>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PlacementKeyValuePairs.DeserializePlacementKeyValuePairs(item));
                            }
                            placementRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableSubvolumes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableSubvolumes = new EnableSubvolume(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VolumeGroupVolumeProperties(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), fileSystemId.Value, creationToken, Optional.ToNullable(serviceLevel), usageThreshold, exportPolicy.Value, Optional.ToList(protocolTypes), provisioningState.Value, snapshotId.Value, backupId.Value, baremetalTenantId.Value, subnetId, Optional.ToNullable(networkFeatures), networkSiblingSetId.Value, Optional.ToNullable(storageToNetworkProximity), Optional.ToList(mountTargets), volumeType.Value, dataProtection.Value, Optional.ToNullable(isRestoring), Optional.ToNullable(snapshotDirectoryVisible), Optional.ToNullable(kerberosEnabled), Optional.ToNullable(securityStyle), Optional.ToNullable(smbEncryption), Optional.ToNullable(smbContinuouslyAvailable), Optional.ToNullable(throughputMibps), Optional.ToNullable(encryptionKeySource), Optional.ToNullable(ldapEnabled), Optional.ToNullable(coolAccess), Optional.ToNullable(coolnessPeriod), unixPermissions.Value, Optional.ToNullable(cloneProgress), Optional.ToNullable(avsDataStore), Optional.ToNullable(isDefaultQuotaEnabled), Optional.ToNullable(defaultUserQuotaInKiBs), Optional.ToNullable(defaultGroupQuotaInKiBs), Optional.ToNullable(maximumNumberOfFiles), volumeGroupName.Value, capacityPoolResourceId.Value, proximityPlacementGroup.Value, t2Network.Value, volumeSpecName.Value, Optional.ToNullable(encrypted), Optional.ToList(placementRules), Optional.ToNullable(enableSubvolumes));
        }
    }
}
