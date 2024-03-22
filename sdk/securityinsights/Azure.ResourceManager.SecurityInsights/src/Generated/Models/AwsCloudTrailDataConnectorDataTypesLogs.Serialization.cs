// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class AwsCloudTrailDataConnectorDataTypesLogs : IUtf8JsonSerializable, IJsonModel<AwsCloudTrailDataConnectorDataTypesLogs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AwsCloudTrailDataConnectorDataTypesLogs>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AwsCloudTrailDataConnectorDataTypesLogs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsCloudTrailDataConnectorDataTypesLogs)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        AwsCloudTrailDataConnectorDataTypesLogs IJsonModel<AwsCloudTrailDataConnectorDataTypesLogs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsCloudTrailDataConnectorDataTypesLogs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsCloudTrailDataConnectorDataTypesLogs(document.RootElement, options);
        }

        internal static AwsCloudTrailDataConnectorDataTypesLogs DeserializeAwsCloudTrailDataConnectorDataTypesLogs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsDataTypeConnectionState? state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SecurityInsightsDataTypeConnectionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AwsCloudTrailDataConnectorDataTypesLogs(state, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AwsCloudTrailDataConnectorDataTypesLogs)} does not support writing '{options.Format}' format.");
            }
        }

        AwsCloudTrailDataConnectorDataTypesLogs IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAwsCloudTrailDataConnectorDataTypesLogs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AwsCloudTrailDataConnectorDataTypesLogs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AwsCloudTrailDataConnectorDataTypesLogs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
