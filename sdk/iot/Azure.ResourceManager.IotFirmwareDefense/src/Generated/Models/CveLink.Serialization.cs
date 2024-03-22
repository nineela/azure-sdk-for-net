// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CveLink : IUtf8JsonSerializable, IJsonModel<CveLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CveLink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CveLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CveLink)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Href))
            {
                if (Href != null)
                {
                    writer.WritePropertyName("href"u8);
                    writer.WriteStringValue(Href.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("href");
                }
            }
            if (Optional.IsDefined(Label))
            {
                if (Label != null)
                {
                    writer.WritePropertyName("label"u8);
                    writer.WriteStringValue(Label);
                }
                else
                {
                    writer.WriteNull("label");
                }
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

        CveLink IJsonModel<CveLink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CveLink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCveLink(document.RootElement, options);
        }

        internal static CveLink DeserializeCveLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri href = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("href"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        href = null;
                        continue;
                    }
                    href = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        label = null;
                        continue;
                    }
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CveLink(href, label, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CveLink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CveLink)} does not support writing '{options.Format}' format.");
            }
        }

        CveLink IPersistableModel<CveLink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CveLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCveLink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CveLink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CveLink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
