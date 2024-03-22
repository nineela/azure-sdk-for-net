// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise
{
    public partial class RedisEnterpriseDatabaseData : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseDatabaseData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseDatabaseData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisEnterpriseDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientProtocol))
            {
                writer.WritePropertyName("clientProtocol"u8);
                writer.WriteStringValue(ClientProtocol.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (Optional.IsDefined(ClusteringPolicy))
            {
                writer.WritePropertyName("clusteringPolicy"u8);
                writer.WriteStringValue(ClusteringPolicy.Value.ToString());
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy"u8);
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(Persistence))
            {
                writer.WritePropertyName("persistence"u8);
                writer.WriteObjectValue(Persistence);
            }
            if (Optional.IsCollectionDefined(Modules))
            {
                writer.WritePropertyName("modules"u8);
                writer.WriteStartArray();
                foreach (var item in Modules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GeoReplication))
            {
                writer.WritePropertyName("geoReplication"u8);
                writer.WriteObjectValue(GeoReplication);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RedisEnterpriseDatabaseData IJsonModel<RedisEnterpriseDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseDatabaseData(document.RootElement, options);
        }

        internal static RedisEnterpriseDatabaseData DeserializeRedisEnterpriseDatabaseData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            RedisEnterpriseClientProtocol? clientProtocol = default;
            int? port = default;
            RedisEnterpriseProvisioningStatus? provisioningState = default;
            RedisEnterpriseClusterResourceState? resourceState = default;
            RedisEnterpriseClusteringPolicy? clusteringPolicy = default;
            RedisEnterpriseEvictionPolicy? evictionPolicy = default;
            RedisPersistenceSettings persistence = default;
            IList<RedisEnterpriseModule> modules = default;
            RedisEnterpriseDatabaseGeoReplication geoReplication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clientProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientProtocol = new RedisEnterpriseClientProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new RedisEnterpriseProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new RedisEnterpriseClusterResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusteringPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusteringPolicy = new RedisEnterpriseClusteringPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("evictionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            evictionPolicy = new RedisEnterpriseEvictionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("persistence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            persistence = RedisPersistenceSettings.DeserializeRedisPersistenceSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("modules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RedisEnterpriseModule> array = new List<RedisEnterpriseModule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisEnterpriseModule.DeserializeRedisEnterpriseModule(item, options));
                            }
                            modules = array;
                            continue;
                        }
                        if (property0.NameEquals("geoReplication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            geoReplication = RedisEnterpriseDatabaseGeoReplication.DeserializeRedisEnterpriseDatabaseGeoReplication(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisEnterpriseDatabaseData(
                id,
                name,
                type,
                systemData,
                clientProtocol,
                port,
                provisioningState,
                resourceState,
                clusteringPolicy,
                evictionPolicy,
                persistence,
                modules ?? new ChangeTrackingList<RedisEnterpriseModule>(),
                geoReplication,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisEnterpriseDatabaseData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseData)} does not support writing '{options.Format}' format.");
            }
        }

        RedisEnterpriseDatabaseData IPersistableModel<RedisEnterpriseDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabaseData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisEnterpriseDatabaseData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseDatabaseData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
