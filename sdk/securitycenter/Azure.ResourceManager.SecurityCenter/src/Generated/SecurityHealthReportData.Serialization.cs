// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityHealthReportData : IUtf8JsonSerializable, IJsonModel<SecurityHealthReportData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityHealthReportData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityHealthReportData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityHealthReportData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceDetails))
            {
                writer.WritePropertyName("resourceDetails"u8);
                writer.WriteObjectValue(ResourceDetails);
            }
            if (Optional.IsDefined(EnvironmentDetails))
            {
                writer.WritePropertyName("environmentDetails"u8);
                writer.WriteObjectValue(EnvironmentDetails);
            }
            if (Optional.IsDefined(HealthDataClassification))
            {
                writer.WritePropertyName("healthDataClassification"u8);
                writer.WriteObjectValue(HealthDataClassification);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsCollectionDefined(AffectedDefendersPlans))
            {
                writer.WritePropertyName("affectedDefendersPlans"u8);
                writer.WriteStartArray();
                foreach (var item in AffectedDefendersPlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AffectedDefendersSubPlans))
            {
                writer.WritePropertyName("affectedDefendersSubPlans"u8);
                writer.WriteStartArray();
                foreach (var item in AffectedDefendersSubPlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReportAdditionalData))
            {
                writer.WritePropertyName("reportAdditionalData"u8);
                writer.WriteStartObject();
                foreach (var item in ReportAdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Issues))
            {
                writer.WritePropertyName("issues"u8);
                writer.WriteStartArray();
                foreach (var item in Issues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SecurityHealthReportData IJsonModel<SecurityHealthReportData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityHealthReportData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityHealthReportData(document.RootElement, options);
        }

        internal static SecurityHealthReportData DeserializeSecurityHealthReportData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            HealthReportResourceDetails resourceDetails = default;
            EnvironmentDetails environmentDetails = default;
            HealthDataClassification healthDataClassification = default;
            HealthReportStatus status = default;
            IList<string> affectedDefendersPlans = default;
            IList<string> affectedDefendersSubPlans = default;
            IReadOnlyDictionary<string, string> reportAdditionalData = default;
            IList<SecurityHealthReportIssue> issues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("resourceDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceDetails = HealthReportResourceDetails.DeserializeHealthReportResourceDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("environmentDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentDetails = EnvironmentDetails.DeserializeEnvironmentDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("healthDataClassification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthDataClassification = HealthDataClassification.DeserializeHealthDataClassification(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = HealthReportStatus.DeserializeHealthReportStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("affectedDefendersPlans"u8))
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
                            affectedDefendersPlans = array;
                            continue;
                        }
                        if (property0.NameEquals("affectedDefendersSubPlans"u8))
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
                            affectedDefendersSubPlans = array;
                            continue;
                        }
                        if (property0.NameEquals("reportAdditionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            reportAdditionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("issues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityHealthReportIssue> array = new List<SecurityHealthReportIssue>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityHealthReportIssue.DeserializeSecurityHealthReportIssue(item, options));
                            }
                            issues = array;
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
            return new SecurityHealthReportData(
                id,
                name,
                type,
                systemData,
                resourceDetails,
                environmentDetails,
                healthDataClassification,
                status,
                affectedDefendersPlans ?? new ChangeTrackingList<string>(),
                affectedDefendersSubPlans ?? new ChangeTrackingList<string>(),
                reportAdditionalData ?? new ChangeTrackingDictionary<string, string>(),
                issues ?? new ChangeTrackingList<SecurityHealthReportIssue>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityHealthReportData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityHealthReportData)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityHealthReportData IPersistableModel<SecurityHealthReportData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityHealthReportData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityHealthReportData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityHealthReportData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityHealthReportData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
