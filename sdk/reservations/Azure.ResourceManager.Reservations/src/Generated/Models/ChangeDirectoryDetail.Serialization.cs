// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ChangeDirectoryDetail : IUtf8JsonSerializable, IJsonModel<ChangeDirectoryDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChangeDirectoryDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChangeDirectoryDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChangeDirectoryDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChangeDirectoryDetail)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReservationOrder))
            {
                writer.WritePropertyName("reservationOrder"u8);
                writer.WriteObjectValue(ReservationOrder);
            }
            if (Optional.IsCollectionDefined(Reservations))
            {
                writer.WritePropertyName("reservations"u8);
                writer.WriteStartArray();
                foreach (var item in Reservations)
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

        ChangeDirectoryDetail IJsonModel<ChangeDirectoryDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChangeDirectoryDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChangeDirectoryDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChangeDirectoryDetail(document.RootElement, options);
        }

        internal static ChangeDirectoryDetail DeserializeChangeDirectoryDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChangeDirectoryResult reservationOrder = default;
            IReadOnlyList<ChangeDirectoryResult> reservations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservationOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationOrder = ChangeDirectoryResult.DeserializeChangeDirectoryResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reservations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChangeDirectoryResult> array = new List<ChangeDirectoryResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChangeDirectoryResult.DeserializeChangeDirectoryResult(item, options));
                    }
                    reservations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChangeDirectoryDetail(reservationOrder, reservations ?? new ChangeTrackingList<ChangeDirectoryResult>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChangeDirectoryDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChangeDirectoryDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChangeDirectoryDetail)} does not support writing '{options.Format}' format.");
            }
        }

        ChangeDirectoryDetail IPersistableModel<ChangeDirectoryDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChangeDirectoryDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChangeDirectoryDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChangeDirectoryDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChangeDirectoryDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
