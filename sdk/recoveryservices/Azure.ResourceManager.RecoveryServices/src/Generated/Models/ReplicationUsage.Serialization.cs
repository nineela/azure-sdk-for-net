// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class ReplicationUsage : IUtf8JsonSerializable, IJsonModel<ReplicationUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationUsage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MonitoringSummary))
            {
                writer.WritePropertyName("monitoringSummary"u8);
                writer.WriteObjectValue(MonitoringSummary);
            }
            if (Optional.IsDefined(JobsSummary))
            {
                writer.WritePropertyName("jobsSummary"u8);
                writer.WriteObjectValue(JobsSummary);
            }
            if (Optional.IsDefined(ProtectedItemCount))
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (Optional.IsDefined(RecoveryPlanCount))
            {
                writer.WritePropertyName("recoveryPlanCount"u8);
                writer.WriteNumberValue(RecoveryPlanCount.Value);
            }
            if (Optional.IsDefined(RegisteredServersCount))
            {
                writer.WritePropertyName("registeredServersCount"u8);
                writer.WriteNumberValue(RegisteredServersCount.Value);
            }
            if (Optional.IsDefined(RecoveryServicesProviderAuthType))
            {
                writer.WritePropertyName("recoveryServicesProviderAuthType"u8);
                writer.WriteNumberValue(RecoveryServicesProviderAuthType.Value);
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

        ReplicationUsage IJsonModel<ReplicationUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationUsage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationUsage(document.RootElement, options);
        }

        internal static ReplicationUsage DeserializeReplicationUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VaultMonitoringSummary monitoringSummary = default;
            ReplicationJobSummary jobsSummary = default;
            int? protectedItemCount = default;
            int? recoveryPlanCount = default;
            int? registeredServersCount = default;
            int? recoveryServicesProviderAuthType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monitoringSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSummary = VaultMonitoringSummary.DeserializeVaultMonitoringSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("jobsSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobsSummary = ReplicationJobSummary.DeserializeReplicationJobSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryPlanCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPlanCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("registeredServersCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registeredServersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderAuthType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryServicesProviderAuthType = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplicationUsage(
                monitoringSummary,
                jobsSummary,
                protectedItemCount,
                recoveryPlanCount,
                registeredServersCount,
                recoveryServicesProviderAuthType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReplicationUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationUsage)} does not support writing '{options.Format}' format.");
            }
        }

        ReplicationUsage IPersistableModel<ReplicationUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
