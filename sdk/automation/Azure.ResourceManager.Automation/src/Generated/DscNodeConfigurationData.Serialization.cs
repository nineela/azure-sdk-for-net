// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class DscNodeConfigurationData : IUtf8JsonSerializable, IJsonModel<DscNodeConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscNodeConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscNodeConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeConfigurationData)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(IsIncrementNodeConfigurationBuildRequired))
            {
                writer.WritePropertyName("incrementNodeConfigurationBuild"u8);
                writer.WriteBooleanValue(IsIncrementNodeConfigurationBuildRequired.Value);
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

        DscNodeConfigurationData IJsonModel<DscNodeConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscNodeConfigurationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscNodeConfigurationData(document.RootElement, options);
        }

        internal static DscNodeConfigurationData DeserializeDscNodeConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DateTimeOffset? lastModifiedTime = default;
            DateTimeOffset? creationTime = default;
            DscConfigurationAssociationProperty configuration = default;
            string source = default;
            long? nodeCount = default;
            bool? incrementNodeConfigurationBuild = default;
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
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configuration = DscConfigurationAssociationProperty.DeserializeDscConfigurationAssociationProperty(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("incrementNodeConfigurationBuild"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            incrementNodeConfigurationBuild = property0.Value.GetBoolean();
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
            return new DscNodeConfigurationData(
                id,
                name,
                type,
                systemData,
                lastModifiedTime,
                creationTime,
                configuration,
                source,
                nodeCount,
                incrementNodeConfigurationBuild,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscNodeConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscNodeConfigurationData)} does not support writing '{options.Format}' format.");
            }
        }

        DscNodeConfigurationData IPersistableModel<DscNodeConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscNodeConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscNodeConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscNodeConfigurationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscNodeConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
