// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraSchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns");
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PartitionKeys))
            {
                writer.WritePropertyName("partitionKeys");
                writer.WriteStartArray();
                foreach (var item in PartitionKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClusterKeys))
            {
                writer.WritePropertyName("clusterKeys");
                writer.WriteStartArray();
                foreach (var item in ClusterKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CassandraSchema DeserializeCassandraSchema(JsonElement element)
        {
            Optional<IList<CassandraColumn>> columns = default;
            Optional<IList<CassandraPartitionKey>> partitionKeys = default;
            Optional<IList<CassandraClusterKey>> clusterKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraColumn> array = new List<CassandraColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraColumn.DeserializeCassandraColumn(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("partitionKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraPartitionKey> array = new List<CassandraPartitionKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraPartitionKey.DeserializeCassandraPartitionKey(item));
                    }
                    partitionKeys = array;
                    continue;
                }
                if (property.NameEquals("clusterKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraClusterKey> array = new List<CassandraClusterKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraClusterKey.DeserializeCassandraClusterKey(item));
                    }
                    clusterKeys = array;
                    continue;
                }
            }
            return new CassandraSchema(Optional.ToList(columns), Optional.ToList(partitionKeys), Optional.ToList(clusterKeys));
        }
    }
}
