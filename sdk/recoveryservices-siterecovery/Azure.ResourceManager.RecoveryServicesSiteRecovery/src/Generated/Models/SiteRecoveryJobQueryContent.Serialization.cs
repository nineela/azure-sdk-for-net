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
    public partial class SiteRecoveryJobQueryContent : IUtf8JsonSerializable, IJsonModel<SiteRecoveryJobQueryContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryJobQueryContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryJobQueryContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobQueryContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn);
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn);
            }
            if (Optional.IsDefined(FabricId))
            {
                writer.WritePropertyName("fabricId"u8);
                writer.WriteStringValue(FabricId);
            }
            if (Optional.IsDefined(AffectedObjectTypes))
            {
                writer.WritePropertyName("affectedObjectTypes"u8);
                writer.WriteStringValue(AffectedObjectTypes);
            }
            if (Optional.IsDefined(JobStatus))
            {
                writer.WritePropertyName("jobStatus"u8);
                writer.WriteStringValue(JobStatus);
            }
            if (Optional.IsDefined(JobOutputType))
            {
                writer.WritePropertyName("jobOutputType"u8);
                writer.WriteStringValue(JobOutputType.Value.ToString());
            }
            if (Optional.IsDefined(JobName))
            {
                writer.WritePropertyName("jobName"u8);
                writer.WriteStringValue(JobName);
            }
            if (Optional.IsDefined(TimezoneOffset))
            {
                writer.WritePropertyName("timezoneOffset"u8);
                writer.WriteNumberValue(TimezoneOffset.Value);
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

        SiteRecoveryJobQueryContent IJsonModel<SiteRecoveryJobQueryContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobQueryContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobQueryContent(document.RootElement, options);
        }

        internal static SiteRecoveryJobQueryContent DeserializeSiteRecoveryJobQueryContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string startTime = default;
            string endTime = default;
            ResourceIdentifier fabricId = default;
            string affectedObjectTypes = default;
            string jobStatus = default;
            ExportJobOutputSerializationType? jobOutputType = default;
            string jobName = default;
            double? timezoneOffset = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("affectedObjectTypes"u8))
                {
                    affectedObjectTypes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobStatus"u8))
                {
                    jobStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobOutputType = new ExportJobOutputSerializationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobName"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timezoneOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timezoneOffset = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryJobQueryContent(
                startTime,
                endTime,
                fabricId,
                affectedObjectTypes,
                jobStatus,
                jobOutputType,
                jobName,
                timezoneOffset,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryJobQueryContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobQueryContent)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryJobQueryContent IPersistableModel<SiteRecoveryJobQueryContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryJobQueryContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobQueryContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryJobQueryContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
