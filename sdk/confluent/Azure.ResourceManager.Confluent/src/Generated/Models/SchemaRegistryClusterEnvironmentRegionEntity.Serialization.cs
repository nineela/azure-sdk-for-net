// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class SchemaRegistryClusterEnvironmentRegionEntity : IUtf8JsonSerializable, IJsonModel<SchemaRegistryClusterEnvironmentRegionEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SchemaRegistryClusterEnvironmentRegionEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SchemaRegistryClusterEnvironmentRegionEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SchemaRegistryClusterEnvironmentRegionEntity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Related))
            {
                writer.WritePropertyName("related"u8);
                writer.WriteStringValue(Related);
            }
            if (Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
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

        SchemaRegistryClusterEnvironmentRegionEntity IJsonModel<SchemaRegistryClusterEnvironmentRegionEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SchemaRegistryClusterEnvironmentRegionEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSchemaRegistryClusterEnvironmentRegionEntity(document.RootElement, options);
        }

        internal static SchemaRegistryClusterEnvironmentRegionEntity DeserializeSchemaRegistryClusterEnvironmentRegionEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string related = default;
            string resourceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("related"u8))
                {
                    related = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SchemaRegistryClusterEnvironmentRegionEntity(id, related, resourceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SchemaRegistryClusterEnvironmentRegionEntity)} does not support writing '{options.Format}' format.");
            }
        }

        SchemaRegistryClusterEnvironmentRegionEntity IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSchemaRegistryClusterEnvironmentRegionEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SchemaRegistryClusterEnvironmentRegionEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SchemaRegistryClusterEnvironmentRegionEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
