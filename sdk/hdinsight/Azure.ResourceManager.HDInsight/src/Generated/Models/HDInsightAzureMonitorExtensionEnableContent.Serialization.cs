// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAzureMonitorExtensionEnableContent : IUtf8JsonSerializable, IJsonModel<HDInsightAzureMonitorExtensionEnableContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAzureMonitorExtensionEnableContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightAzureMonitorExtensionEnableContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionEnableContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SelectedConfigurations))
            {
                writer.WritePropertyName("selectedConfigurations"u8);
                writer.WriteObjectValue(SelectedConfigurations);
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

        HDInsightAzureMonitorExtensionEnableContent IJsonModel<HDInsightAzureMonitorExtensionEnableContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionEnableContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAzureMonitorExtensionEnableContent(document.RootElement, options);
        }

        internal static HDInsightAzureMonitorExtensionEnableContent DeserializeHDInsightAzureMonitorExtensionEnableContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string workspaceId = default;
            string primaryKey = default;
            HDInsightAzureMonitorSelectedConfigurations selectedConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedConfigurations = HDInsightAzureMonitorSelectedConfigurations.DeserializeHDInsightAzureMonitorSelectedConfigurations(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightAzureMonitorExtensionEnableContent(workspaceId, primaryKey, selectedConfigurations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionEnableContent)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAzureMonitorExtensionEnableContent IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightAzureMonitorExtensionEnableContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAzureMonitorExtensionEnableContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAzureMonitorExtensionEnableContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
