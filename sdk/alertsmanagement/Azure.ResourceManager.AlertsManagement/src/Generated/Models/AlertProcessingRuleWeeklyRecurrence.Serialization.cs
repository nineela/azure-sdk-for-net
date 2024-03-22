// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleWeeklyRecurrence : IUtf8JsonSerializable, IJsonModel<AlertProcessingRuleWeeklyRecurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertProcessingRuleWeeklyRecurrence>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AlertProcessingRuleWeeklyRecurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleWeeklyRecurrence)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("daysOfWeek"u8);
            writer.WriteStartArray();
            foreach (var item in DaysOfWeek)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("recurrenceType"u8);
            writer.WriteStringValue(RecurrenceType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "T");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "T");
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

        AlertProcessingRuleWeeklyRecurrence IJsonModel<AlertProcessingRuleWeeklyRecurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleWeeklyRecurrence)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleWeeklyRecurrence(document.RootElement, options);
        }

        internal static AlertProcessingRuleWeeklyRecurrence DeserializeAlertProcessingRuleWeeklyRecurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AlertsManagementDayOfWeek> daysOfWeek = default;
            RecurrenceType recurrenceType = default;
            TimeSpan? startTime = default;
            TimeSpan? endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfWeek"u8))
                {
                    List<AlertsManagementDayOfWeek> array = new List<AlertsManagementDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AlertsManagementDayOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("recurrenceType"u8))
                {
                    recurrenceType = new RecurrenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AlertProcessingRuleWeeklyRecurrence(recurrenceType, startTime, endTime, serializedAdditionalRawData, daysOfWeek);
        }

        BinaryData IPersistableModel<AlertProcessingRuleWeeklyRecurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleWeeklyRecurrence)} does not support writing '{options.Format}' format.");
            }
        }

        AlertProcessingRuleWeeklyRecurrence IPersistableModel<AlertProcessingRuleWeeklyRecurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAlertProcessingRuleWeeklyRecurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleWeeklyRecurrence)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertProcessingRuleWeeklyRecurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
