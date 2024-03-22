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
    public partial class ContentKeyPolicyFairPlayOfflineRentalConfiguration : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayOfflineRentalConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("playbackDurationSeconds"u8);
            writer.WriteNumberValue(PlaybackDurationInSeconds);
            writer.WritePropertyName("storageDurationSeconds"u8);
            writer.WriteNumberValue(StorageDurationInSeconds);
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

        ContentKeyPolicyFairPlayOfflineRentalConfiguration IJsonModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayOfflineRentalConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(document.RootElement, options);
        }

        internal static ContentKeyPolicyFairPlayOfflineRentalConfiguration DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long playbackDurationSeconds = default;
            long storageDurationSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playbackDurationSeconds"u8))
                {
                    playbackDurationSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageDurationSeconds"u8))
                {
                    storageDurationSeconds = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyFairPlayOfflineRentalConfiguration(playbackDurationSeconds, storageDurationSeconds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayOfflineRentalConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyFairPlayOfflineRentalConfiguration IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyFairPlayOfflineRentalConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyFairPlayOfflineRentalConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyFairPlayOfflineRentalConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
