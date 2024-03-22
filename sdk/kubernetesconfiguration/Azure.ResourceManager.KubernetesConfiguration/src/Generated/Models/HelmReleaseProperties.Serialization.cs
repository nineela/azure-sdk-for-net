// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class HelmReleaseProperties : IUtf8JsonSerializable, IJsonModel<HelmReleaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmReleaseProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HelmReleaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmReleaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LastRevisionApplied))
            {
                if (LastRevisionApplied != null)
                {
                    writer.WritePropertyName("lastRevisionApplied"u8);
                    writer.WriteNumberValue(LastRevisionApplied.Value);
                }
                else
                {
                    writer.WriteNull("lastRevisionApplied");
                }
            }
            if (Optional.IsDefined(HelmChartRef))
            {
                if (HelmChartRef != null)
                {
                    writer.WritePropertyName("helmChartRef"u8);
                    writer.WriteObjectValue(HelmChartRef);
                }
                else
                {
                    writer.WriteNull("helmChartRef");
                }
            }
            if (Optional.IsDefined(FailureCount))
            {
                if (FailureCount != null)
                {
                    writer.WritePropertyName("failureCount"u8);
                    writer.WriteNumberValue(FailureCount.Value);
                }
                else
                {
                    writer.WriteNull("failureCount");
                }
            }
            if (Optional.IsDefined(InstallFailureCount))
            {
                if (InstallFailureCount != null)
                {
                    writer.WritePropertyName("installFailureCount"u8);
                    writer.WriteNumberValue(InstallFailureCount.Value);
                }
                else
                {
                    writer.WriteNull("installFailureCount");
                }
            }
            if (Optional.IsDefined(UpgradeFailureCount))
            {
                if (UpgradeFailureCount != null)
                {
                    writer.WritePropertyName("upgradeFailureCount"u8);
                    writer.WriteNumberValue(UpgradeFailureCount.Value);
                }
                else
                {
                    writer.WriteNull("upgradeFailureCount");
                }
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

        HelmReleaseProperties IJsonModel<HelmReleaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmReleaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmReleaseProperties(document.RootElement, options);
        }

        internal static HelmReleaseProperties DeserializeHelmReleaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? lastRevisionApplied = default;
            KubernetesObjectReference helmChartRef = default;
            long? failureCount = default;
            long? installFailureCount = default;
            long? upgradeFailureCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastRevisionApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastRevisionApplied = null;
                        continue;
                    }
                    lastRevisionApplied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("helmChartRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        helmChartRef = null;
                        continue;
                    }
                    helmChartRef = KubernetesObjectReference.DeserializeKubernetesObjectReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("failureCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        failureCount = null;
                        continue;
                    }
                    failureCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("installFailureCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        installFailureCount = null;
                        continue;
                    }
                    installFailureCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("upgradeFailureCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        upgradeFailureCount = null;
                        continue;
                    }
                    upgradeFailureCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmReleaseProperties(
                lastRevisionApplied,
                helmChartRef,
                failureCount,
                installFailureCount,
                upgradeFailureCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmReleaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmReleaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HelmReleaseProperties IPersistableModel<HelmReleaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmReleaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHelmReleaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HelmReleaseProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HelmReleaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
