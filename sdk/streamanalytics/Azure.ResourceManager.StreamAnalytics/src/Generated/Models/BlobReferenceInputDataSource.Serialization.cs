// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class BlobReferenceInputDataSource : IUtf8JsonSerializable, IJsonModel<BlobReferenceInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobReferenceInputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BlobReferenceInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobReferenceInputDataSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container"u8);
                writer.WriteStringValue(Container);
            }
            if (Optional.IsDefined(PathPattern))
            {
                writer.WritePropertyName("pathPattern"u8);
                writer.WriteStringValue(PathPattern);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat"u8);
                writer.WriteStringValue(TimeFormat);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(BlobName))
            {
                writer.WritePropertyName("blobName"u8);
                writer.WriteStringValue(BlobName);
            }
            if (Optional.IsDefined(DeltaPathPattern))
            {
                writer.WritePropertyName("deltaPathPattern"u8);
                writer.WriteStringValue(DeltaPathPattern);
            }
            if (Optional.IsDefined(SourcePartitionCount))
            {
                writer.WritePropertyName("sourcePartitionCount"u8);
                writer.WriteNumberValue(SourcePartitionCount.Value);
            }
            if (Optional.IsDefined(FullSnapshotRefreshInterval))
            {
                writer.WritePropertyName("fullSnapshotRefreshRate"u8);
                writer.WriteStringValue(FullSnapshotRefreshInterval.Value, "T");
            }
            if (Optional.IsDefined(DeltaSnapshotRefreshInterval))
            {
                writer.WritePropertyName("deltaSnapshotRefreshRate"u8);
                writer.WriteStringValue(DeltaSnapshotRefreshInterval.Value, "T");
            }
            writer.WriteEndObject();
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

        BlobReferenceInputDataSource IJsonModel<BlobReferenceInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobReferenceInputDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobReferenceInputDataSource(document.RootElement, options);
        }

        internal static BlobReferenceInputDataSource DeserializeBlobReferenceInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IList<StreamAnalyticsStorageAccount> storageAccounts = default;
            string container = default;
            string pathPattern = default;
            string dateFormat = default;
            string timeFormat = default;
            StreamAnalyticsAuthenticationMode? authenticationMode = default;
            string blobName = default;
            string deltaPathPattern = default;
            int? sourcePartitionCount = default;
            TimeSpan? fullSnapshotRefreshRate = default;
            TimeSpan? deltaSnapshotRefreshRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamAnalyticsStorageAccount> array = new List<StreamAnalyticsStorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamAnalyticsStorageAccount.DeserializeStreamAnalyticsStorageAccount(item, options));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("container"u8))
                        {
                            container = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pathPattern"u8))
                        {
                            pathPattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dateFormat"u8))
                        {
                            dateFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFormat"u8))
                        {
                            timeFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobName"u8))
                        {
                            blobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deltaPathPattern"u8))
                        {
                            deltaPathPattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourcePartitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourcePartitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("fullSnapshotRefreshRate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            fullSnapshotRefreshRate = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                        if (property0.NameEquals("deltaSnapshotRefreshRate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deltaSnapshotRefreshRate = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlobReferenceInputDataSource(
                type,
                serializedAdditionalRawData,
                storageAccounts ?? new ChangeTrackingList<StreamAnalyticsStorageAccount>(),
                container,
                pathPattern,
                dateFormat,
                timeFormat,
                authenticationMode,
                blobName,
                deltaPathPattern,
                sourcePartitionCount,
                fullSnapshotRefreshRate,
                deltaSnapshotRefreshRate);
        }

        BinaryData IPersistableModel<BlobReferenceInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BlobReferenceInputDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        BlobReferenceInputDataSource IPersistableModel<BlobReferenceInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlobReferenceInputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobReferenceInputDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobReferenceInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
