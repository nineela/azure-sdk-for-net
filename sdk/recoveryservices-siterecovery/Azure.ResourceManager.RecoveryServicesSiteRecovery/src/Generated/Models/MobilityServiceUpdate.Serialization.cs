// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class MobilityServiceUpdate : IUtf8JsonSerializable, IJsonModel<MobilityServiceUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobilityServiceUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobilityServiceUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobilityServiceUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobilityServiceUpdate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(RebootStatus))
            {
                writer.WritePropertyName("rebootStatus"u8);
                writer.WriteStringValue(RebootStatus);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
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

        MobilityServiceUpdate IJsonModel<MobilityServiceUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobilityServiceUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobilityServiceUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobilityServiceUpdate(document.RootElement, options);
        }

        internal static MobilityServiceUpdate DeserializeMobilityServiceUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string version = default;
            string rebootStatus = default;
            string osType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootStatus"u8))
                {
                    rebootStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobilityServiceUpdate(version, rebootStatus, osType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobilityServiceUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobilityServiceUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobilityServiceUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        MobilityServiceUpdate IPersistableModel<MobilityServiceUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobilityServiceUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobilityServiceUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobilityServiceUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobilityServiceUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
