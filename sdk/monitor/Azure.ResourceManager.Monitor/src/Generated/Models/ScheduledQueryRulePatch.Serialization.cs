// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ScheduledQueryRulePatch : IUtf8JsonSerializable, IJsonModel<ScheduledQueryRulePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledQueryRulePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduledQueryRulePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRulePatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreatedWithApiVersion))
            {
                writer.WritePropertyName("createdWithApiVersion"u8);
                writer.WriteStringValue(CreatedWithApiVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(IsLegacyLogAnalyticsRule))
            {
                writer.WritePropertyName("isLegacyLogAnalyticsRule"u8);
                writer.WriteBooleanValue(IsLegacyLogAnalyticsRule.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteNumberValue(Severity.Value.ToSerialInt64());
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                writer.WritePropertyName("evaluationFrequency"u8);
                writer.WriteStringValue(EvaluationFrequency.Value, "P");
            }
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize"u8);
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            if (Optional.IsDefined(OverrideQueryTimeRange))
            {
                writer.WritePropertyName("overrideQueryTimeRange"u8);
                writer.WriteStringValue(OverrideQueryTimeRange.Value, "P");
            }
            if (Optional.IsCollectionDefined(TargetResourceTypes))
            {
                writer.WritePropertyName("targetResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in TargetResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Criteria))
            {
                writer.WritePropertyName("criteria"u8);
                writer.WriteObjectValue(Criteria);
            }
            if (Optional.IsDefined(MuteActionsDuration))
            {
                writer.WritePropertyName("muteActionsDuration"u8);
                writer.WriteStringValue(MuteActionsDuration.Value, "P");
            }
            if (Optional.IsDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteObjectValue(Actions);
            }
            if (options.Format != "W" && Optional.IsDefined(IsWorkspaceAlertsStorageConfigured))
            {
                writer.WritePropertyName("isWorkspaceAlertsStorageConfigured"u8);
                writer.WriteBooleanValue(IsWorkspaceAlertsStorageConfigured.Value);
            }
            if (Optional.IsDefined(CheckWorkspaceAlertsStorageConfigured))
            {
                writer.WritePropertyName("checkWorkspaceAlertsStorageConfigured"u8);
                writer.WriteBooleanValue(CheckWorkspaceAlertsStorageConfigured.Value);
            }
            if (Optional.IsDefined(SkipQueryValidation))
            {
                writer.WritePropertyName("skipQueryValidation"u8);
                writer.WriteBooleanValue(SkipQueryValidation.Value);
            }
            if (Optional.IsDefined(AutoMitigate))
            {
                writer.WritePropertyName("autoMitigate"u8);
                writer.WriteBooleanValue(AutoMitigate.Value);
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

        ScheduledQueryRulePatch IJsonModel<ScheduledQueryRulePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledQueryRulePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledQueryRulePatch(document.RootElement, options);
        }

        internal static ScheduledQueryRulePatch DeserializeScheduledQueryRulePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string createdWithApiVersion = default;
            bool? isLegacyLogAnalyticsRule = default;
            string description = default;
            string displayName = default;
            AlertSeverity? severity = default;
            bool? enabled = default;
            IList<string> scopes = default;
            TimeSpan? evaluationFrequency = default;
            TimeSpan? windowSize = default;
            TimeSpan? overrideQueryTimeRange = default;
            IList<string> targetResourceTypes = default;
            ScheduledQueryRuleCriteria criteria = default;
            TimeSpan? muteActionsDuration = default;
            ScheduledQueryRuleActions actions = default;
            bool? isWorkspaceAlertsStorageConfigured = default;
            bool? checkWorkspaceAlertsStorageConfigured = default;
            bool? skipQueryValidation = default;
            bool? autoMitigate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("createdWithApiVersion"u8))
                        {
                            createdWithApiVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isLegacyLogAnalyticsRule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLegacyLogAnalyticsRule = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new AlertSeverity(property0.Value.GetInt64());
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("scopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            scopes = array;
                            continue;
                        }
                        if (property0.NameEquals("evaluationFrequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            evaluationFrequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("windowSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            windowSize = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("overrideQueryTimeRange"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overrideQueryTimeRange = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("targetResourceTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            targetResourceTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("criteria"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            criteria = ScheduledQueryRuleCriteria.DeserializeScheduledQueryRuleCriteria(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("muteActionsDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            muteActionsDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("actions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            actions = ScheduledQueryRuleActions.DeserializeScheduledQueryRuleActions(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isWorkspaceAlertsStorageConfigured"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isWorkspaceAlertsStorageConfigured = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("checkWorkspaceAlertsStorageConfigured"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            checkWorkspaceAlertsStorageConfigured = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("skipQueryValidation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            skipQueryValidation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoMitigate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoMitigate = property0.Value.GetBoolean();
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
            return new ScheduledQueryRulePatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                createdWithApiVersion,
                isLegacyLogAnalyticsRule,
                description,
                displayName,
                severity,
                enabled,
                scopes ?? new ChangeTrackingList<string>(),
                evaluationFrequency,
                windowSize,
                overrideQueryTimeRange,
                targetResourceTypes ?? new ChangeTrackingList<string>(),
                criteria,
                muteActionsDuration,
                actions,
                isWorkspaceAlertsStorageConfigured,
                checkWorkspaceAlertsStorageConfigured,
                skipQueryValidation,
                autoMitigate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduledQueryRulePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRulePatch)} does not support writing '{options.Format}' format.");
            }
        }

        ScheduledQueryRulePatch IPersistableModel<ScheduledQueryRulePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledQueryRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduledQueryRulePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledQueryRulePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledQueryRulePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
