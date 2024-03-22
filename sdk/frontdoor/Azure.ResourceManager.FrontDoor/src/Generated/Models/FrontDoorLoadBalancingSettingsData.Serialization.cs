// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorLoadBalancingSettingsData : IUtf8JsonSerializable, IJsonModel<FrontDoorLoadBalancingSettingsData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorLoadBalancingSettingsData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorLoadBalancingSettingsData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorLoadBalancingSettingsData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorLoadBalancingSettingsData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SampleSize))
            {
                writer.WritePropertyName("sampleSize"u8);
                writer.WriteNumberValue(SampleSize.Value);
            }
            if (Optional.IsDefined(SuccessfulSamplesRequired))
            {
                writer.WritePropertyName("successfulSamplesRequired"u8);
                writer.WriteNumberValue(SuccessfulSamplesRequired.Value);
            }
            if (Optional.IsDefined(AdditionalLatencyMilliseconds))
            {
                writer.WritePropertyName("additionalLatencyMilliseconds"u8);
                writer.WriteNumberValue(AdditionalLatencyMilliseconds.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
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

        FrontDoorLoadBalancingSettingsData IJsonModel<FrontDoorLoadBalancingSettingsData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorLoadBalancingSettingsData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorLoadBalancingSettingsData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorLoadBalancingSettingsData(document.RootElement, options);
        }

        internal static FrontDoorLoadBalancingSettingsData DeserializeFrontDoorLoadBalancingSettingsData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            int? sampleSize = default;
            int? successfulSamplesRequired = default;
            int? additionalLatencyMilliseconds = default;
            FrontDoorResourceState? resourceState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("sampleSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sampleSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("successfulSamplesRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            successfulSamplesRequired = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("additionalLatencyMilliseconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalLatencyMilliseconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
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
            return new FrontDoorLoadBalancingSettingsData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                sampleSize,
                successfulSamplesRequired,
                additionalLatencyMilliseconds,
                resourceState);
        }

        BinaryData IPersistableModel<FrontDoorLoadBalancingSettingsData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorLoadBalancingSettingsData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorLoadBalancingSettingsData)} does not support writing '{options.Format}' format.");
            }
        }

        FrontDoorLoadBalancingSettingsData IPersistableModel<FrontDoorLoadBalancingSettingsData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorLoadBalancingSettingsData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorLoadBalancingSettingsData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorLoadBalancingSettingsData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorLoadBalancingSettingsData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
