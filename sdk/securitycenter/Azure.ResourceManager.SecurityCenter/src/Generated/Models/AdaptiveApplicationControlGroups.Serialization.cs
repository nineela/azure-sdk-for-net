// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class AdaptiveApplicationControlGroups : IUtf8JsonSerializable, IJsonModel<AdaptiveApplicationControlGroups>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdaptiveApplicationControlGroups>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdaptiveApplicationControlGroups>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroups>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdaptiveApplicationControlGroups)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        AdaptiveApplicationControlGroups IJsonModel<AdaptiveApplicationControlGroups>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroups>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdaptiveApplicationControlGroups)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdaptiveApplicationControlGroups(document.RootElement, options);
        }

        internal static AdaptiveApplicationControlGroups DeserializeAdaptiveApplicationControlGroups(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AdaptiveApplicationControlGroupData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdaptiveApplicationControlGroupData> array = new List<AdaptiveApplicationControlGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdaptiveApplicationControlGroupData.DeserializeAdaptiveApplicationControlGroupData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdaptiveApplicationControlGroups(value ?? new ChangeTrackingList<AdaptiveApplicationControlGroupData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdaptiveApplicationControlGroups>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroups>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdaptiveApplicationControlGroups)} does not support writing '{options.Format}' format.");
            }
        }

        AdaptiveApplicationControlGroups IPersistableModel<AdaptiveApplicationControlGroups>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlGroups>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdaptiveApplicationControlGroups(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdaptiveApplicationControlGroups)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdaptiveApplicationControlGroups>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
