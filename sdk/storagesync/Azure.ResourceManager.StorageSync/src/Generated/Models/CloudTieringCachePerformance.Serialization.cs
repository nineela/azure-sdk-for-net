// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringCachePerformance : IUtf8JsonSerializable, IJsonModel<CloudTieringCachePerformance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudTieringCachePerformance>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudTieringCachePerformance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringCachePerformance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringCachePerformance)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CacheHitBytes))
            {
                writer.WritePropertyName("cacheHitBytes"u8);
                writer.WriteNumberValue(CacheHitBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CacheMissBytes))
            {
                writer.WritePropertyName("cacheMissBytes"u8);
                writer.WriteNumberValue(CacheMissBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CacheHitBytesPercent))
            {
                writer.WritePropertyName("cacheHitBytesPercent"u8);
                writer.WriteNumberValue(CacheHitBytesPercent.Value);
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

        CloudTieringCachePerformance IJsonModel<CloudTieringCachePerformance>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringCachePerformance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringCachePerformance)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringCachePerformance(document.RootElement, options);
        }

        internal static CloudTieringCachePerformance DeserializeCloudTieringCachePerformance(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastUpdatedTimestamp = default;
            long? cacheHitBytes = default;
            long? cacheMissBytes = default;
            int? cacheHitBytesPercent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cacheHitBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheMissBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheMissBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheHitBytesPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitBytesPercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudTieringCachePerformance(lastUpdatedTimestamp, cacheHitBytes, cacheMissBytes, cacheHitBytesPercent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudTieringCachePerformance>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringCachePerformance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudTieringCachePerformance)} does not support writing '{options.Format}' format.");
            }
        }

        CloudTieringCachePerformance IPersistableModel<CloudTieringCachePerformance>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringCachePerformance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudTieringCachePerformance(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudTieringCachePerformance)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudTieringCachePerformance>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
