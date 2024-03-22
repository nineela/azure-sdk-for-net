// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MonitorServerlessSparkCompute : IUtf8JsonSerializable, IJsonModel<MonitorServerlessSparkCompute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorServerlessSparkCompute>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorServerlessSparkCompute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServerlessSparkCompute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorServerlessSparkCompute)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("computeIdentity"u8);
            writer.WriteObjectValue(ComputeIdentity);
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WritePropertyName("runtimeVersion"u8);
            writer.WriteStringValue(RuntimeVersion);
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
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

        MonitorServerlessSparkCompute IJsonModel<MonitorServerlessSparkCompute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServerlessSparkCompute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorServerlessSparkCompute)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorServerlessSparkCompute(document.RootElement, options);
        }

        internal static MonitorServerlessSparkCompute DeserializeMonitorServerlessSparkCompute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorComputeIdentityBase computeIdentity = default;
            string instanceType = default;
            string runtimeVersion = default;
            MonitorComputeType computeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeIdentity"u8))
                {
                    computeIdentity = MonitorComputeIdentityBase.DeserializeMonitorComputeIdentityBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("computeType"u8))
                {
                    computeType = new MonitorComputeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorServerlessSparkCompute(computeType, serializedAdditionalRawData, computeIdentity, instanceType, runtimeVersion);
        }

        BinaryData IPersistableModel<MonitorServerlessSparkCompute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServerlessSparkCompute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorServerlessSparkCompute)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorServerlessSparkCompute IPersistableModel<MonitorServerlessSparkCompute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServerlessSparkCompute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorServerlessSparkCompute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorServerlessSparkCompute)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorServerlessSparkCompute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
