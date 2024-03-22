// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentFeatureCapabilities : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentFeatureCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentFeatureCapabilities>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationInsightsComponentFeatureCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeatureCapabilities)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SupportExportData))
            {
                writer.WritePropertyName("SupportExportData"u8);
                writer.WriteBooleanValue(SupportExportData.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BurstThrottlePolicy))
            {
                writer.WritePropertyName("BurstThrottlePolicy"u8);
                writer.WriteStringValue(BurstThrottlePolicy);
            }
            if (options.Format != "W" && Optional.IsDefined(MetadataClass))
            {
                writer.WritePropertyName("MetadataClass"u8);
                writer.WriteStringValue(MetadataClass);
            }
            if (options.Format != "W" && Optional.IsDefined(LiveStreamMetrics))
            {
                writer.WritePropertyName("LiveStreamMetrics"u8);
                writer.WriteBooleanValue(LiveStreamMetrics.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ApplicationMap))
            {
                writer.WritePropertyName("ApplicationMap"u8);
                writer.WriteBooleanValue(ApplicationMap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(WorkItemIntegration))
            {
                writer.WritePropertyName("WorkItemIntegration"u8);
                writer.WriteBooleanValue(WorkItemIntegration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PowerBIIntegration))
            {
                writer.WritePropertyName("PowerBIIntegration"u8);
                writer.WriteBooleanValue(PowerBIIntegration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(OpenSchema))
            {
                writer.WritePropertyName("OpenSchema"u8);
                writer.WriteBooleanValue(OpenSchema.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProactiveDetection))
            {
                writer.WritePropertyName("ProactiveDetection"u8);
                writer.WriteBooleanValue(ProactiveDetection.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AnalyticsIntegration))
            {
                writer.WritePropertyName("AnalyticsIntegration"u8);
                writer.WriteBooleanValue(AnalyticsIntegration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MultipleStepWebTest))
            {
                writer.WritePropertyName("MultipleStepWebTest"u8);
                writer.WriteBooleanValue(MultipleStepWebTest.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ApiAccessLevel))
            {
                writer.WritePropertyName("ApiAccessLevel"u8);
                writer.WriteStringValue(ApiAccessLevel);
            }
            if (options.Format != "W" && Optional.IsDefined(TrackingType))
            {
                writer.WritePropertyName("TrackingType"u8);
                writer.WriteStringValue(TrackingType);
            }
            if (options.Format != "W" && Optional.IsDefined(DailyCap))
            {
                writer.WritePropertyName("DailyCap"u8);
                writer.WriteNumberValue(DailyCap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DailyCapResetTime))
            {
                writer.WritePropertyName("DailyCapResetTime"u8);
                writer.WriteNumberValue(DailyCapResetTime.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ThrottleRate))
            {
                writer.WritePropertyName("ThrottleRate"u8);
                writer.WriteNumberValue(ThrottleRate.Value);
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

        ApplicationInsightsComponentFeatureCapabilities IJsonModel<ApplicationInsightsComponentFeatureCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeatureCapabilities)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentFeatureCapabilities(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentFeatureCapabilities DeserializeApplicationInsightsComponentFeatureCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? supportExportData = default;
            string burstThrottlePolicy = default;
            string metadataClass = default;
            bool? liveStreamMetrics = default;
            bool? applicationMap = default;
            bool? workItemIntegration = default;
            bool? powerBIIntegration = default;
            bool? openSchema = default;
            bool? proactiveDetection = default;
            bool? analyticsIntegration = default;
            bool? multipleStepWebTest = default;
            string apiAccessLevel = default;
            string trackingType = default;
            float? dailyCap = default;
            float? dailyCapResetTime = default;
            float? throttleRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("SupportExportData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportExportData = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("BurstThrottlePolicy"u8))
                {
                    burstThrottlePolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MetadataClass"u8))
                {
                    metadataClass = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("LiveStreamMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liveStreamMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ApplicationMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationMap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("WorkItemIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workItemIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("PowerBIIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    powerBIIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("OpenSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ProactiveDetection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    proactiveDetection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("AnalyticsIntegration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticsIntegration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("MultipleStepWebTest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multipleStepWebTest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ApiAccessLevel"u8))
                {
                    apiAccessLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TrackingType"u8))
                {
                    trackingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DailyCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailyCap = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("DailyCapResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailyCapResetTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ThrottleRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttleRate = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentFeatureCapabilities(
                supportExportData,
                burstThrottlePolicy,
                metadataClass,
                liveStreamMetrics,
                applicationMap,
                workItemIntegration,
                powerBIIntegration,
                openSchema,
                proactiveDetection,
                analyticsIntegration,
                multipleStepWebTest,
                apiAccessLevel,
                trackingType,
                dailyCap,
                dailyCapResetTime,
                throttleRate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeatureCapabilities)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentFeatureCapabilities IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentFeatureCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeatureCapabilities)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentFeatureCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
