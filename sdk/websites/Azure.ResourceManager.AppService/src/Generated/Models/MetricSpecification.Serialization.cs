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
    public partial class MetricSpecification : IUtf8JsonSerializable, IJsonModel<MetricSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricSpecification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MetricSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricSpecification)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DisplayDescription))
            {
                writer.WritePropertyName("displayDescription"u8);
                writer.WriteStringValue(DisplayDescription);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(AggregationType))
            {
                writer.WritePropertyName("aggregationType"u8);
                writer.WriteStringValue(AggregationType);
            }
            if (Optional.IsDefined(IsInstanceLevelAggregationSupported))
            {
                writer.WritePropertyName("supportsInstanceLevelAggregation"u8);
                writer.WriteBooleanValue(IsInstanceLevelAggregationSupported.Value);
            }
            if (Optional.IsDefined(IsRegionalMdmAccountEnabled))
            {
                writer.WritePropertyName("enableRegionalMdmAccount"u8);
                writer.WriteBooleanValue(IsRegionalMdmAccountEnabled.Value);
            }
            if (Optional.IsDefined(SourceMdmAccount))
            {
                writer.WritePropertyName("sourceMdmAccount"u8);
                writer.WriteStringValue(SourceMdmAccount);
            }
            if (Optional.IsDefined(SourceMdmNamespace))
            {
                writer.WritePropertyName("sourceMdmNamespace"u8);
                writer.WriteStringValue(SourceMdmNamespace);
            }
            if (Optional.IsDefined(MetricFilterPattern))
            {
                writer.WritePropertyName("metricFilterPattern"u8);
                writer.WriteStringValue(MetricFilterPattern);
            }
            if (Optional.IsDefined(FillGapWithZero))
            {
                writer.WritePropertyName("fillGapWithZero"u8);
                writer.WriteBooleanValue(FillGapWithZero.Value);
            }
            if (Optional.IsDefined(IsInternal))
            {
                writer.WritePropertyName("isInternal"u8);
                writer.WriteBooleanValue(IsInternal.Value);
            }
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsCollectionDefined(Availabilities))
            {
                writer.WritePropertyName("availabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Availabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedTimeGrainTypes))
            {
                writer.WritePropertyName("supportedTimeGrainTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedTimeGrainTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedAggregationTypes))
            {
                writer.WritePropertyName("supportedAggregationTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedAggregationTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        MetricSpecification IJsonModel<MetricSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricSpecification)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricSpecification(document.RootElement, options);
        }

        internal static MetricSpecification DeserializeMetricSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string displayName = default;
            string displayDescription = default;
            string unit = default;
            string aggregationType = default;
            bool? supportsInstanceLevelAggregation = default;
            bool? enableRegionalMdmAccount = default;
            string sourceMdmAccount = default;
            string sourceMdmNamespace = default;
            string metricFilterPattern = default;
            bool? fillGapWithZero = default;
            bool? isInternal = default;
            IReadOnlyList<MetricDimension> dimensions = default;
            string category = default;
            IReadOnlyList<MetricAvailability> availabilities = default;
            IReadOnlyList<string> supportedTimeGrainTypes = default;
            IReadOnlyList<string> supportedAggregationTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayDescription"u8))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregationType"u8))
                {
                    aggregationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportsInstanceLevelAggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportsInstanceLevelAggregation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableRegionalMdmAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableRegionalMdmAccount = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceMdmAccount"u8))
                {
                    sourceMdmAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceMdmNamespace"u8))
                {
                    sourceMdmNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricFilterPattern"u8))
                {
                    metricFilterPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fillGapWithZero"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fillGapWithZero = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isInternal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isInternal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricDimension> array = new List<MetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricDimension.DeserializeMetricDimension(item, options));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricAvailability> array = new List<MetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAvailability.DeserializeMetricAvailability(item, options));
                    }
                    availabilities = array;
                    continue;
                }
                if (property.NameEquals("supportedTimeGrainTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedTimeGrainTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedAggregationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedAggregationTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricSpecification(
                name,
                displayName,
                displayDescription,
                unit,
                aggregationType,
                supportsInstanceLevelAggregation,
                enableRegionalMdmAccount,
                sourceMdmAccount,
                sourceMdmNamespace,
                metricFilterPattern,
                fillGapWithZero,
                isInternal,
                dimensions ?? new ChangeTrackingList<MetricDimension>(),
                category,
                availabilities ?? new ChangeTrackingList<MetricAvailability>(),
                supportedTimeGrainTypes ?? new ChangeTrackingList<string>(),
                supportedAggregationTypes ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricSpecification)} does not support writing '{options.Format}' format.");
            }
        }

        MetricSpecification IPersistableModel<MetricSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMetricSpecification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricSpecification)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
