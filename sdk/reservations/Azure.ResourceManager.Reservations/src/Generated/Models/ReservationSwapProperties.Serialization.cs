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
    public partial class ReservationSwapProperties : IUtf8JsonSerializable, IJsonModel<ReservationSwapProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationSwapProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationSwapProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSwapProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationSwapProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SwapSource))
            {
                writer.WritePropertyName("swapSource"u8);
                writer.WriteStringValue(SwapSource);
            }
            if (Optional.IsDefined(SwapDestination))
            {
                writer.WritePropertyName("swapDestination"u8);
                writer.WriteStringValue(SwapDestination);
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

        ReservationSwapProperties IJsonModel<ReservationSwapProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSwapProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationSwapProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationSwapProperties(document.RootElement, options);
        }

        internal static ReservationSwapProperties DeserializeReservationSwapProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string swapSource = default;
            string swapDestination = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("swapSource"u8))
                {
                    swapSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("swapDestination"u8))
                {
                    swapDestination = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationSwapProperties(swapSource, swapDestination, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationSwapProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSwapProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationSwapProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ReservationSwapProperties IPersistableModel<ReservationSwapProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSwapProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationSwapProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationSwapProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationSwapProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
