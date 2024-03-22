// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceGranularMarkingEntity : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceGranularMarkingEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceGranularMarkingEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreatIntelligenceGranularMarkingEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceGranularMarkingEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceGranularMarkingEntity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(MarkingRef))
            {
                writer.WritePropertyName("markingRef"u8);
                writer.WriteNumberValue(MarkingRef.Value);
            }
            if (Optional.IsCollectionDefined(Selectors))
            {
                writer.WritePropertyName("selectors"u8);
                writer.WriteStartArray();
                foreach (var item in Selectors)
                {
                    writer.WriteStringValue(item);
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

        ThreatIntelligenceGranularMarkingEntity IJsonModel<ThreatIntelligenceGranularMarkingEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceGranularMarkingEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceGranularMarkingEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceGranularMarkingEntity(document.RootElement, options);
        }

        internal static ThreatIntelligenceGranularMarkingEntity DeserializeThreatIntelligenceGranularMarkingEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string language = default;
            int? markingRef = default;
            IList<string> selectors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("markingRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    markingRef = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("selectors"u8))
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
                    selectors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreatIntelligenceGranularMarkingEntity(language, markingRef, selectors ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreatIntelligenceGranularMarkingEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceGranularMarkingEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceGranularMarkingEntity)} does not support writing '{options.Format}' format.");
            }
        }

        ThreatIntelligenceGranularMarkingEntity IPersistableModel<ThreatIntelligenceGranularMarkingEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceGranularMarkingEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreatIntelligenceGranularMarkingEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceGranularMarkingEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceGranularMarkingEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
