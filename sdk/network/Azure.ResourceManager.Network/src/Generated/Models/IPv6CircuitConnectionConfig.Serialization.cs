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
    public partial class IPv6CircuitConnectionConfig : IUtf8JsonSerializable, IJsonModel<IPv6CircuitConnectionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPv6CircuitConnectionConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPv6CircuitConnectionConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6CircuitConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPv6CircuitConnectionConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (options.Format != "W" && Optional.IsDefined(CircuitConnectionStatus))
            {
                writer.WritePropertyName("circuitConnectionStatus"u8);
                writer.WriteStringValue(CircuitConnectionStatus.Value.ToString());
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

        IPv6CircuitConnectionConfig IJsonModel<IPv6CircuitConnectionConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6CircuitConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPv6CircuitConnectionConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPv6CircuitConnectionConfig(document.RootElement, options);
        }

        internal static IPv6CircuitConnectionConfig DeserializeIPv6CircuitConnectionConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string addressPrefix = default;
            CircuitConnectionStatus? circuitConnectionStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("circuitConnectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    circuitConnectionStatus = new CircuitConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPv6CircuitConnectionConfig(addressPrefix, circuitConnectionStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPv6CircuitConnectionConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6CircuitConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IPv6CircuitConnectionConfig)} does not support writing '{options.Format}' format.");
            }
        }

        IPv6CircuitConnectionConfig IPersistableModel<IPv6CircuitConnectionConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPv6CircuitConnectionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPv6CircuitConnectionConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IPv6CircuitConnectionConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPv6CircuitConnectionConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
