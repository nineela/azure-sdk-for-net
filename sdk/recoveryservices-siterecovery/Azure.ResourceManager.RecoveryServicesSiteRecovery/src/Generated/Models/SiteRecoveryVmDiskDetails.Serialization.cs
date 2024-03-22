// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryVmDiskDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryVmDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryVmDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryVmDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryVmDiskDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VhdType))
            {
                writer.WritePropertyName("vhdType"u8);
                writer.WriteStringValue(VhdType);
            }
            if (Optional.IsDefined(VhdId))
            {
                writer.WritePropertyName("vhdId"u8);
                writer.WriteStringValue(VhdId);
            }
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(VhdName))
            {
                writer.WritePropertyName("vhdName"u8);
                writer.WriteStringValue(VhdName);
            }
            if (Optional.IsDefined(MaxSizeMB))
            {
                writer.WritePropertyName("maxSizeMB"u8);
                writer.WriteStringValue(MaxSizeMB);
            }
            if (Optional.IsDefined(TargetDiskLocation))
            {
                writer.WritePropertyName("targetDiskLocation"u8);
                writer.WriteStringValue(TargetDiskLocation);
            }
            if (Optional.IsDefined(TargetDiskName))
            {
                writer.WritePropertyName("targetDiskName"u8);
                writer.WriteStringValue(TargetDiskName);
            }
            if (Optional.IsDefined(LunId))
            {
                writer.WritePropertyName("lunId"u8);
                writer.WriteStringValue(LunId);
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsDefined(CustomTargetDiskName))
            {
                writer.WritePropertyName("customTargetDiskName"u8);
                writer.WriteStringValue(CustomTargetDiskName);
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

        SiteRecoveryVmDiskDetails IJsonModel<SiteRecoveryVmDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryVmDiskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryVmDiskDetails(document.RootElement, options);
        }

        internal static SiteRecoveryVmDiskDetails DeserializeSiteRecoveryVmDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vhdType = default;
            string vhdId = default;
            string diskId = default;
            string vhdName = default;
            string maxSizeMB = default;
            string targetDiskLocation = default;
            string targetDiskName = default;
            string lunId = default;
            ResourceIdentifier diskEncryptionSetId = default;
            string customTargetDiskName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdType"u8))
                {
                    vhdType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdId"u8))
                {
                    vhdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdName"u8))
                {
                    vhdName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxSizeMB"u8))
                {
                    maxSizeMB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDiskLocation"u8))
                {
                    targetDiskLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDiskName"u8))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lunId"u8))
                {
                    lunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customTargetDiskName"u8))
                {
                    customTargetDiskName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryVmDiskDetails(
                vhdType,
                vhdId,
                diskId,
                vhdName,
                maxSizeMB,
                targetDiskLocation,
                targetDiskName,
                lunId,
                diskEncryptionSetId,
                customTargetDiskName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryVmDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryVmDiskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryVmDiskDetails IPersistableModel<SiteRecoveryVmDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryVmDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryVmDiskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryVmDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
