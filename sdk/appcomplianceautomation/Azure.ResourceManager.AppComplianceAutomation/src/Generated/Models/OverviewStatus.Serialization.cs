// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class OverviewStatus : IUtf8JsonSerializable, IJsonModel<OverviewStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OverviewStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OverviewStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OverviewStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PassedCount))
            {
                writer.WritePropertyName("passedCount"u8);
                writer.WriteNumberValue(PassedCount.Value);
            }
            if (Optional.IsDefined(FailedCount))
            {
                writer.WritePropertyName("failedCount"u8);
                writer.WriteNumberValue(FailedCount.Value);
            }
            if (Optional.IsDefined(ManualCount))
            {
                writer.WritePropertyName("manualCount"u8);
                writer.WriteNumberValue(ManualCount.Value);
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

        OverviewStatus IJsonModel<OverviewStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OverviewStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOverviewStatus(document.RootElement, options);
        }

        internal static OverviewStatus DeserializeOverviewStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? passedCount = default;
            int? failedCount = default;
            int? manualCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("passedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    passedCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("manualCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manualCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OverviewStatus(passedCount, failedCount, manualCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OverviewStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OverviewStatus)} does not support writing '{options.Format}' format.");
            }
        }

        OverviewStatus IPersistableModel<OverviewStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOverviewStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OverviewStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OverviewStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
