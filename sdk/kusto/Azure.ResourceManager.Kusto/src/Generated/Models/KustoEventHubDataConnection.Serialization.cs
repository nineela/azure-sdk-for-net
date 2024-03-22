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

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoEventHubDataConnection : IUtf8JsonSerializable, IJsonModel<KustoEventHubDataConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoEventHubDataConnection>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KustoEventHubDataConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoEventHubDataConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoEventHubDataConnection)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (Optional.IsDefined(EventHubResourceId))
            {
                writer.WritePropertyName("eventHubResourceId"u8);
                writer.WriteStringValue(EventHubResourceId);
            }
            if (Optional.IsDefined(ConsumerGroup))
            {
                writer.WritePropertyName("consumerGroup"u8);
                writer.WriteStringValue(ConsumerGroup);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(MappingRuleName))
            {
                writer.WritePropertyName("mappingRuleName"u8);
                writer.WriteStringValue(MappingRuleName);
            }
            if (Optional.IsDefined(DataFormat))
            {
                writer.WritePropertyName("dataFormat"u8);
                writer.WriteStringValue(DataFormat.Value.ToString());
            }
            if (Optional.IsCollectionDefined(EventSystemProperties))
            {
                writer.WritePropertyName("eventSystemProperties"u8);
                writer.WriteStartArray();
                foreach (var item in EventSystemProperties)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteStringValue(Compression.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ManagedIdentityResourceId))
            {
                writer.WritePropertyName("managedIdentityResourceId"u8);
                writer.WriteStringValue(ManagedIdentityResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ManagedIdentityObjectId))
            {
                writer.WritePropertyName("managedIdentityObjectId"u8);
                writer.WriteStringValue(ManagedIdentityObjectId.Value);
            }
            if (Optional.IsDefined(DatabaseRouting))
            {
                writer.WritePropertyName("databaseRouting"u8);
                writer.WriteStringValue(DatabaseRouting.Value.ToString());
            }
            if (Optional.IsDefined(RetrievalStartOn))
            {
                writer.WritePropertyName("retrievalStartDate"u8);
                writer.WriteStringValue(RetrievalStartOn.Value, "O");
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

        KustoEventHubDataConnection IJsonModel<KustoEventHubDataConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoEventHubDataConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoEventHubDataConnection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoEventHubDataConnection(document.RootElement, options);
        }

        internal static KustoEventHubDataConnection DeserializeKustoEventHubDataConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            DataConnectionKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier eventHubResourceId = default;
            string consumerGroup = default;
            string tableName = default;
            string mappingRuleName = default;
            KustoEventHubDataFormat? dataFormat = default;
            IList<string> eventSystemProperties = default;
            EventHubMessagesCompressionType? compression = default;
            KustoProvisioningState? provisioningState = default;
            ResourceIdentifier managedIdentityResourceId = default;
            Guid? managedIdentityObjectId = default;
            KustoDatabaseRouting? databaseRouting = default;
            DateTimeOffset? retrievalStartDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataConnectionKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("eventHubResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventHubResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("consumerGroup"u8))
                        {
                            consumerGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mappingRuleName"u8))
                        {
                            mappingRuleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataFormat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataFormat = new KustoEventHubDataFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventSystemProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            eventSystemProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("compression"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compression = new EventHubMessagesCompressionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedIdentityResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedIdentityResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedIdentityObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedIdentityObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("databaseRouting"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseRouting = new KustoDatabaseRouting(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("retrievalStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retrievalStartDate = property0.Value.GetDateTimeOffset("O");
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
            return new KustoEventHubDataConnection(
                id,
                name,
                type,
                systemData,
                location,
                kind,
                serializedAdditionalRawData,
                eventHubResourceId,
                consumerGroup,
                tableName,
                mappingRuleName,
                dataFormat,
                eventSystemProperties ?? new ChangeTrackingList<string>(),
                compression,
                provisioningState,
                managedIdentityResourceId,
                managedIdentityObjectId,
                databaseRouting,
                retrievalStartDate);
        }

        BinaryData IPersistableModel<KustoEventHubDataConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoEventHubDataConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KustoEventHubDataConnection)} does not support writing '{options.Format}' format.");
            }
        }

        KustoEventHubDataConnection IPersistableModel<KustoEventHubDataConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoEventHubDataConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustoEventHubDataConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoEventHubDataConnection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoEventHubDataConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
