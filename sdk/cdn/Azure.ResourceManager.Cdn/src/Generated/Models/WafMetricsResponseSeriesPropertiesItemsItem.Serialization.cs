// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafMetricsResponseSeriesPropertiesItemsItem : IUtf8JsonSerializable, IJsonModel<WafMetricsResponseSeriesPropertiesItemsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WafMetricsResponseSeriesPropertiesItemsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WafMetricsResponseSeriesPropertiesItemsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WafMetricsResponseSeriesPropertiesItemsItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        WafMetricsResponseSeriesPropertiesItemsItem IJsonModel<WafMetricsResponseSeriesPropertiesItemsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WafMetricsResponseSeriesPropertiesItemsItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWafMetricsResponseSeriesPropertiesItemsItem(document.RootElement, options);
        }

        internal static WafMetricsResponseSeriesPropertiesItemsItem DeserializeWafMetricsResponseSeriesPropertiesItemsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WafMetricsResponseSeriesPropertiesItemsItem(name, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WafMetricsResponseSeriesPropertiesItemsItem)} does not support writing '{options.Format}' format.");
            }
        }

        WafMetricsResponseSeriesPropertiesItemsItem IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWafMetricsResponseSeriesPropertiesItemsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WafMetricsResponseSeriesPropertiesItemsItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WafMetricsResponseSeriesPropertiesItemsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
