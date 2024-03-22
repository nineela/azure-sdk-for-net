// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementServiceBackupRestoreContent : IUtf8JsonSerializable, IJsonModel<ApiManagementServiceBackupRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementServiceBackupRestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementServiceBackupRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServiceBackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccount"u8);
            writer.WriteStringValue(StorageAccount);
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("backupName"u8);
            writer.WriteStringValue(BackupName);
            if (Optional.IsDefined(AccessType))
            {
                writer.WritePropertyName("accessType"u8);
                writer.WriteStringValue(AccessType.Value.ToString());
            }
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey"u8);
                writer.WriteStringValue(AccessKey);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
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

        ApiManagementServiceBackupRestoreContent IJsonModel<ApiManagementServiceBackupRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServiceBackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementServiceBackupRestoreContent(document.RootElement, options);
        }

        internal static ApiManagementServiceBackupRestoreContent DeserializeApiManagementServiceBackupRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccount = default;
            string containerName = default;
            string backupName = default;
            StorageAccountAccessType? accessType = default;
            string accessKey = default;
            string clientId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccount"u8))
                {
                    storageAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupName"u8))
                {
                    backupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessType = new StorageAccountAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessKey"u8))
                {
                    accessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementServiceBackupRestoreContent(
                storageAccount,
                containerName,
                backupName,
                accessType,
                accessKey,
                clientId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementServiceBackupRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServiceBackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementServiceBackupRestoreContent IPersistableModel<ApiManagementServiceBackupRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementServiceBackupRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementServiceBackupRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementServiceBackupRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
