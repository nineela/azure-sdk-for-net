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
    internal partial class PurchaseRequestPropertiesReservedResourceProperties : IUtf8JsonSerializable, IJsonModel<PurchaseRequestPropertiesReservedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurchaseRequestPropertiesReservedResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PurchaseRequestPropertiesReservedResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurchaseRequestPropertiesReservedResourceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
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

        PurchaseRequestPropertiesReservedResourceProperties IJsonModel<PurchaseRequestPropertiesReservedResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurchaseRequestPropertiesReservedResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurchaseRequestPropertiesReservedResourceProperties(document.RootElement, options);
        }

        internal static PurchaseRequestPropertiesReservedResourceProperties DeserializePurchaseRequestPropertiesReservedResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InstanceFlexibility? instanceFlexibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceFlexibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceFlexibility = new InstanceFlexibility(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PurchaseRequestPropertiesReservedResourceProperties(instanceFlexibility, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PurchaseRequestPropertiesReservedResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PurchaseRequestPropertiesReservedResourceProperties IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePurchaseRequestPropertiesReservedResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurchaseRequestPropertiesReservedResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurchaseRequestPropertiesReservedResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
