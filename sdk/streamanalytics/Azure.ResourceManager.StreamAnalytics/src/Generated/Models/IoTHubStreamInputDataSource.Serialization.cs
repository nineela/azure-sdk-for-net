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
    public partial class IoTHubStreamInputDataSource : IUtf8JsonSerializable, IJsonModel<IoTHubStreamInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IoTHubStreamInputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IoTHubStreamInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IoTHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IoTHubStreamInputDataSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IotHubNamespace))
            {
                writer.WritePropertyName("iotHubNamespace"u8);
                writer.WriteStringValue(IotHubNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(ConsumerGroupName))
            {
                writer.WritePropertyName("consumerGroupName"u8);
                writer.WriteStringValue(ConsumerGroupName);
            }
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
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

        IoTHubStreamInputDataSource IJsonModel<IoTHubStreamInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IoTHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IoTHubStreamInputDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIoTHubStreamInputDataSource(document.RootElement, options);
        }

        internal static IoTHubStreamInputDataSource DeserializeIoTHubStreamInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string iotHubNamespace = default;
            string sharedAccessPolicyName = default;
            string sharedAccessPolicyKey = default;
            string consumerGroupName = default;
            string endpoint = default;
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
                        if (property0.NameEquals("iotHubNamespace"u8))
                        {
                            iotHubNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumerGroupName"u8))
                        {
                            consumerGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
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
            return new IoTHubStreamInputDataSource(
                type,
                serializedAdditionalRawData,
                iotHubNamespace,
                sharedAccessPolicyName,
                sharedAccessPolicyKey,
                consumerGroupName,
                endpoint);
        }

        BinaryData IPersistableModel<IoTHubStreamInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IoTHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IoTHubStreamInputDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        IoTHubStreamInputDataSource IPersistableModel<IoTHubStreamInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IoTHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIoTHubStreamInputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IoTHubStreamInputDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IoTHubStreamInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
