// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerCpuStatistics : IUtf8JsonSerializable, IJsonModel<ContainerCpuStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerCpuStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerCpuStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CpuUsage))
            {
                writer.WritePropertyName("cpuUsage"u8);
                writer.WriteObjectValue(CpuUsage);
            }
            if (Optional.IsDefined(SystemCpuUsage))
            {
                writer.WritePropertyName("systemCpuUsage"u8);
                writer.WriteNumberValue(SystemCpuUsage.Value);
            }
            if (Optional.IsDefined(OnlineCpuCount))
            {
                writer.WritePropertyName("onlineCpuCount"u8);
                writer.WriteNumberValue(OnlineCpuCount.Value);
            }
            if (Optional.IsDefined(ThrottlingData))
            {
                writer.WritePropertyName("throttlingData"u8);
                writer.WriteObjectValue(ThrottlingData);
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

        ContainerCpuStatistics IJsonModel<ContainerCpuStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCpuStatistics(document.RootElement, options);
        }

        internal static ContainerCpuStatistics DeserializeContainerCpuStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerCpuUsage cpuUsage = default;
            long? systemCpuUsage = default;
            int? onlineCpuCount = default;
            ContainerThrottlingInfo throttlingData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUsage = ContainerCpuUsage.DeserializeContainerCpuUsage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("systemCpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemCpuUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("onlineCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlineCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("throttlingData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttlingData = ContainerThrottlingInfo.DeserializeContainerThrottlingInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerCpuStatistics(cpuUsage, systemCpuUsage, onlineCpuCount, throttlingData, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerCpuStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerCpuStatistics IPersistableModel<ContainerCpuStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerCpuStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerCpuStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
