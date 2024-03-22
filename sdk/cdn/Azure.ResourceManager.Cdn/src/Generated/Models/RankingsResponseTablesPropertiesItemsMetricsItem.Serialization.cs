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
    public partial class RankingsResponseTablesPropertiesItemsMetricsItem : IUtf8JsonSerializable, IJsonModel<RankingsResponseTablesPropertiesItemsMetricsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RankingsResponseTablesPropertiesItemsMetricsItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RankingsResponseTablesPropertiesItemsMetricsItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RankingsResponseTablesPropertiesItemsMetricsItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (Optional.IsDefined(Percentage))
            {
                writer.WritePropertyName("percentage"u8);
                writer.WriteNumberValue(Percentage.Value);
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

        RankingsResponseTablesPropertiesItemsMetricsItem IJsonModel<RankingsResponseTablesPropertiesItemsMetricsItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RankingsResponseTablesPropertiesItemsMetricsItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRankingsResponseTablesPropertiesItemsMetricsItem(document.RootElement, options);
        }

        internal static RankingsResponseTablesPropertiesItemsMetricsItem DeserializeRankingsResponseTablesPropertiesItemsMetricsItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metric = default;
            long? value = default;
            float? percentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("percentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentage = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RankingsResponseTablesPropertiesItemsMetricsItem(metric, value, percentage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RankingsResponseTablesPropertiesItemsMetricsItem)} does not support writing '{options.Format}' format.");
            }
        }

        RankingsResponseTablesPropertiesItemsMetricsItem IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRankingsResponseTablesPropertiesItemsMetricsItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RankingsResponseTablesPropertiesItemsMetricsItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RankingsResponseTablesPropertiesItemsMetricsItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
