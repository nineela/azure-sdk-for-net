// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TroubleshootingDetails : IUtf8JsonSerializable, IJsonModel<TroubleshootingDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TroubleshootingDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TroubleshootingDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshootingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TroubleshootingDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(ReasonType))
            {
                writer.WritePropertyName("reasonType"u8);
                writer.WriteStringValue(ReasonType);
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(Detail))
            {
                writer.WritePropertyName("detail"u8);
                writer.WriteStringValue(Detail);
            }
            if (Optional.IsCollectionDefined(RecommendedActions))
            {
                writer.WritePropertyName("recommendedActions"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendedActions)
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

        TroubleshootingDetails IJsonModel<TroubleshootingDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshootingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TroubleshootingDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTroubleshootingDetails(document.RootElement, options);
        }

        internal static TroubleshootingDetails DeserializeTroubleshootingDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string reasonType = default;
            string summary = default;
            string detail = default;
            IReadOnlyList<TroubleshootingRecommendedActions> recommendedActions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reasonType"u8))
                {
                    reasonType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detail"u8))
                {
                    detail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TroubleshootingRecommendedActions> array = new List<TroubleshootingRecommendedActions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TroubleshootingRecommendedActions.DeserializeTroubleshootingRecommendedActions(item, options));
                    }
                    recommendedActions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TroubleshootingDetails(
                id,
                reasonType,
                summary,
                detail,
                recommendedActions ?? new ChangeTrackingList<TroubleshootingRecommendedActions>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TroubleshootingDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshootingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TroubleshootingDetails)} does not support writing '{options.Format}' format.");
            }
        }

        TroubleshootingDetails IPersistableModel<TroubleshootingDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshootingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTroubleshootingDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TroubleshootingDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TroubleshootingDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
