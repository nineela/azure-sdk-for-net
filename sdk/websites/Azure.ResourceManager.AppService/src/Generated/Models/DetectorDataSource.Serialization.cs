// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DetectorDataSource : IUtf8JsonSerializable, IJsonModel<DetectorDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DetectorDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DetectorDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectorDataSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Instructions))
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStartArray();
                foreach (var item in Instructions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataSourceUri))
            {
                writer.WritePropertyName("dataSourceUri"u8);
                writer.WriteStartArray();
                foreach (var item in DataSourceUri)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DetectorDataSource IJsonModel<DetectorDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DetectorDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectorDataSource(document.RootElement, options);
        }

        internal static DetectorDataSource DeserializeDetectorDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> instructions = default;
            IList<AppServiceNameValuePair> dataSourceUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    instructions = array;
                    continue;
                }
                if (property.NameEquals("dataSourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppServiceNameValuePair> array = new List<AppServiceNameValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item, options));
                    }
                    dataSourceUri = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DetectorDataSource(instructions ?? new ChangeTrackingList<string>(), dataSourceUri ?? new ChangeTrackingList<AppServiceNameValuePair>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DetectorDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DetectorDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        DetectorDataSource IPersistableModel<DetectorDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DetectorDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDetectorDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DetectorDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DetectorDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
