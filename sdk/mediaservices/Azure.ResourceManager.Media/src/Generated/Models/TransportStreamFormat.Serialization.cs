// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class TransportStreamFormat : IUtf8JsonSerializable, IJsonModel<TransportStreamFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransportStreamFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransportStreamFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportStreamFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransportStreamFormat)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(OutputFiles))
            {
                writer.WritePropertyName("outputFiles"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("filenamePattern"u8);
            writer.WriteStringValue(FilenamePattern);
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

        TransportStreamFormat IJsonModel<TransportStreamFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportStreamFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransportStreamFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransportStreamFormat(document.RootElement, options);
        }

        internal static TransportStreamFormat DeserializeTransportStreamFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MediaOutputFile> outputFiles = default;
            string odataType = default;
            string filenamePattern = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaOutputFile> array = new List<MediaOutputFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaOutputFile.DeserializeMediaOutputFile(item, options));
                    }
                    outputFiles = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filenamePattern"u8))
                {
                    filenamePattern = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransportStreamFormat(odataType, filenamePattern, serializedAdditionalRawData, outputFiles ?? new ChangeTrackingList<MediaOutputFile>());
        }

        BinaryData IPersistableModel<TransportStreamFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportStreamFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransportStreamFormat)} does not support writing '{options.Format}' format.");
            }
        }

        TransportStreamFormat IPersistableModel<TransportStreamFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransportStreamFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransportStreamFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransportStreamFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransportStreamFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
