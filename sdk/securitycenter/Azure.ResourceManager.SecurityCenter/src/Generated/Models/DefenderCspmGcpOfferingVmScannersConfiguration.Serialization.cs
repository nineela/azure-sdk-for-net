// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmGcpOfferingVmScannersConfiguration : IUtf8JsonSerializable, IJsonModel<DefenderCspmGcpOfferingVmScannersConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmGcpOfferingVmScannersConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderCspmGcpOfferingVmScannersConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingVmScannersConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScanningMode))
            {
                writer.WritePropertyName("scanningMode"u8);
                writer.WriteStringValue(ScanningMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExclusionTags))
            {
                writer.WritePropertyName("exclusionTags"u8);
                writer.WriteStartObject();
                foreach (var item in ExclusionTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        DefenderCspmGcpOfferingVmScannersConfiguration IJsonModel<DefenderCspmGcpOfferingVmScannersConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingVmScannersConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmGcpOfferingVmScannersConfiguration(document.RootElement, options);
        }

        internal static DefenderCspmGcpOfferingVmScannersConfiguration DeserializeDefenderCspmGcpOfferingVmScannersConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderForServersScanningMode? scanningMode = default;
            IDictionary<string, string> exclusionTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scanningMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scanningMode = new DefenderForServersScanningMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusionTags"u8))
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
                    exclusionTags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderCspmGcpOfferingVmScannersConfiguration(scanningMode, exclusionTags ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingVmScannersConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderCspmGcpOfferingVmScannersConfiguration IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmGcpOfferingVmScannersConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOfferingVmScannersConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmGcpOfferingVmScannersConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
