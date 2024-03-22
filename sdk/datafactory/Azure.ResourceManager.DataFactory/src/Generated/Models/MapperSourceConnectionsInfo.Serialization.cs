// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class MapperSourceConnectionsInfo : IUtf8JsonSerializable, IJsonModel<MapperSourceConnectionsInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapperSourceConnectionsInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MapperSourceConnectionsInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperSourceConnectionsInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapperSourceConnectionsInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SourceEntities))
            {
                writer.WritePropertyName("sourceEntities"u8);
                writer.WriteStartArray();
                foreach (var item in SourceEntities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Connection))
            {
                writer.WritePropertyName("connection"u8);
                writer.WriteObjectValue(Connection);
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

        MapperSourceConnectionsInfo IJsonModel<MapperSourceConnectionsInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperSourceConnectionsInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapperSourceConnectionsInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapperSourceConnectionsInfo(document.RootElement, options);
        }

        internal static MapperSourceConnectionsInfo DeserializeMapperSourceConnectionsInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MapperTable> sourceEntities = default;
            MapperConnection connection = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceEntities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapperTable> array = new List<MapperTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapperTable.DeserializeMapperTable(item, options));
                    }
                    sourceEntities = array;
                    continue;
                }
                if (property.NameEquals("connection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connection = MapperConnection.DeserializeMapperConnection(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MapperSourceConnectionsInfo(sourceEntities ?? new ChangeTrackingList<MapperTable>(), connection, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapperSourceConnectionsInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperSourceConnectionsInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapperSourceConnectionsInfo)} does not support writing '{options.Format}' format.");
            }
        }

        MapperSourceConnectionsInfo IPersistableModel<MapperSourceConnectionsInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapperSourceConnectionsInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMapperSourceConnectionsInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapperSourceConnectionsInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapperSourceConnectionsInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
