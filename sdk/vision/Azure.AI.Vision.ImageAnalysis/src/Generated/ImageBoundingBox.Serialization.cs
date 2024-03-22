// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class ImageBoundingBox : IUtf8JsonSerializable, IJsonModel<ImageBoundingBox>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageBoundingBox>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageBoundingBox>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageBoundingBox>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageBoundingBox)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("x"u8);
            writer.WriteNumberValue(X);
            writer.WritePropertyName("y"u8);
            writer.WriteNumberValue(Y);
            writer.WritePropertyName("w"u8);
            writer.WriteNumberValue(Width);
            writer.WritePropertyName("h"u8);
            writer.WriteNumberValue(Height);
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

        ImageBoundingBox IJsonModel<ImageBoundingBox>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageBoundingBox>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageBoundingBox)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageBoundingBox(document.RootElement, options);
        }

        internal static ImageBoundingBox DeserializeImageBoundingBox(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int x = default;
            int y = default;
            int w = default;
            int h = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"u8))
                {
                    x = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("y"u8))
                {
                    y = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("w"u8))
                {
                    w = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("h"u8))
                {
                    h = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageBoundingBox(x, y, w, h, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageBoundingBox>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageBoundingBox>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageBoundingBox)} does not support writing '{options.Format}' format.");
            }
        }

        ImageBoundingBox IPersistableModel<ImageBoundingBox>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageBoundingBox>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageBoundingBox(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageBoundingBox)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageBoundingBox>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageBoundingBox FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageBoundingBox(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
