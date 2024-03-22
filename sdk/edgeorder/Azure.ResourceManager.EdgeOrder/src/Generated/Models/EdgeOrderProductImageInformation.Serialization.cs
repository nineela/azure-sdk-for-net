// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderProductImageInformation : IUtf8JsonSerializable, IJsonModel<EdgeOrderProductImageInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderProductImageInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderProductImageInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductImageInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductImageInformation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ImageType))
            {
                writer.WritePropertyName("imageType"u8);
                writer.WriteStringValue(ImageType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ImageUri))
            {
                writer.WritePropertyName("imageUrl"u8);
                writer.WriteStringValue(ImageUri.AbsoluteUri);
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

        EdgeOrderProductImageInformation IJsonModel<EdgeOrderProductImageInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductImageInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderProductImageInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderProductImageInformation(document.RootElement, options);
        }

        internal static EdgeOrderProductImageInformation DeserializeEdgeOrderProductImageInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdgeOrderProductImageType? imageType = default;
            Uri imageUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageType = new EdgeOrderProductImageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("imageUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderProductImageInformation(imageType, imageUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderProductImageInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductImageInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductImageInformation)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeOrderProductImageInformation IPersistableModel<EdgeOrderProductImageInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderProductImageInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderProductImageInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderProductImageInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderProductImageInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
