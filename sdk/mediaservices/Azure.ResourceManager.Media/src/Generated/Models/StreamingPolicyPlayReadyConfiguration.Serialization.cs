// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class StreamingPolicyPlayReadyConfiguration : IUtf8JsonSerializable, IJsonModel<StreamingPolicyPlayReadyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPolicyPlayReadyConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingPolicyPlayReadyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyPlayReadyConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomLicenseAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customLicenseAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomLicenseAcquisitionUriTemplate);
            }
            if (Optional.IsDefined(PlayReadyCustomAttributes))
            {
                writer.WritePropertyName("playReadyCustomAttributes"u8);
                writer.WriteStringValue(PlayReadyCustomAttributes);
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

        StreamingPolicyPlayReadyConfiguration IJsonModel<StreamingPolicyPlayReadyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyPlayReadyConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyPlayReadyConfiguration(document.RootElement, options);
        }

        internal static StreamingPolicyPlayReadyConfiguration DeserializeStreamingPolicyPlayReadyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customLicenseAcquisitionUriTemplate = default;
            string playReadyCustomAttributes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customLicenseAcquisitionUrlTemplate"u8))
                {
                    customLicenseAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("playReadyCustomAttributes"u8))
                {
                    playReadyCustomAttributes = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingPolicyPlayReadyConfiguration(customLicenseAcquisitionUriTemplate, playReadyCustomAttributes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPolicyPlayReadyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyPlayReadyConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingPolicyPlayReadyConfiguration IPersistableModel<StreamingPolicyPlayReadyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyPlayReadyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingPolicyPlayReadyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyPlayReadyConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingPolicyPlayReadyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
