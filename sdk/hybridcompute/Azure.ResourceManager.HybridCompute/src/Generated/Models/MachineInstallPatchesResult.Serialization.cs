// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineInstallPatchesResult : IUtf8JsonSerializable, IJsonModel<MachineInstallPatchesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineInstallPatchesResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineInstallPatchesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineInstallPatchesResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InstallationActivityId))
            {
                writer.WritePropertyName("installationActivityId"u8);
                writer.WriteStringValue(InstallationActivityId);
            }
            if (options.Format != "W" && Optional.IsDefined(RebootStatus))
            {
                writer.WritePropertyName("rebootStatus"u8);
                writer.WriteStringValue(RebootStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MaintenanceWindowExceeded))
            {
                writer.WritePropertyName("maintenanceWindowExceeded"u8);
                writer.WriteBooleanValue(MaintenanceWindowExceeded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ExcludedPatchCount))
            {
                writer.WritePropertyName("excludedPatchCount"u8);
                writer.WriteNumberValue(ExcludedPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NotSelectedPatchCount))
            {
                writer.WritePropertyName("notSelectedPatchCount"u8);
                writer.WriteNumberValue(NotSelectedPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PendingPatchCount))
            {
                writer.WritePropertyName("pendingPatchCount"u8);
                writer.WriteNumberValue(PendingPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InstalledPatchCount))
            {
                writer.WritePropertyName("installedPatchCount"u8);
                writer.WriteNumberValue(InstalledPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FailedPatchCount))
            {
                writer.WritePropertyName("failedPatchCount"u8);
                writer.WriteNumberValue(FailedPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StartedBy))
            {
                writer.WritePropertyName("startedBy"u8);
                writer.WriteStringValue(StartedBy.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PatchServiceUsed))
            {
                writer.WritePropertyName("patchServiceUsed"u8);
                writer.WriteStringValue(PatchServiceUsed.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                JsonSerializer.Serialize(writer, ErrorDetails);
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

        MachineInstallPatchesResult IJsonModel<MachineInstallPatchesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineInstallPatchesResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineInstallPatchesResult(document.RootElement, options);
        }

        internal static MachineInstallPatchesResult DeserializeMachineInstallPatchesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineOperationStatus? status = default;
            string installationActivityId = default;
            VmGuestPatchRebootStatus? rebootStatus = default;
            bool? maintenanceWindowExceeded = default;
            int? excludedPatchCount = default;
            int? notSelectedPatchCount = default;
            int? pendingPatchCount = default;
            int? installedPatchCount = default;
            int? failedPatchCount = default;
            DateTimeOffset? startDateTime = default;
            DateTimeOffset? lastModifiedDateTime = default;
            PatchOperationStartedBy? startedBy = default;
            PatchServiceUsed? patchServiceUsed = default;
            HybridComputeOSType? osType = default;
            ResponseError errorDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("installationActivityId"u8))
                {
                    installationActivityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootStatus = new VmGuestPatchRebootStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maintenanceWindowExceeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindowExceeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("excludedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notSelectedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notSelectedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pendingPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("installedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedBy = new PatchOperationStartedBy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("patchServiceUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchServiceUsed = new PatchServiceUsed(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HybridComputeOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetails = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineInstallPatchesResult(
                status,
                installationActivityId,
                rebootStatus,
                maintenanceWindowExceeded,
                excludedPatchCount,
                notSelectedPatchCount,
                pendingPatchCount,
                installedPatchCount,
                failedPatchCount,
                startDateTime,
                lastModifiedDateTime,
                startedBy,
                patchServiceUsed,
                osType,
                errorDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineInstallPatchesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineInstallPatchesResult)} does not support writing '{options.Format}' format.");
            }
        }

        MachineInstallPatchesResult IPersistableModel<MachineInstallPatchesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineInstallPatchesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineInstallPatchesResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineInstallPatchesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
