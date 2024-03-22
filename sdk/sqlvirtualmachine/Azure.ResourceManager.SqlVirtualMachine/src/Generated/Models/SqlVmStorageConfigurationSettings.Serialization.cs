// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmStorageConfigurationSettings : IUtf8JsonSerializable, IJsonModel<SqlVmStorageConfigurationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlVmStorageConfigurationSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlVmStorageConfigurationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmStorageConfigurationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmStorageConfigurationSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlDataSettings))
            {
                writer.WritePropertyName("sqlDataSettings"u8);
                writer.WriteObjectValue(SqlDataSettings);
            }
            if (Optional.IsDefined(SqlLogSettings))
            {
                writer.WritePropertyName("sqlLogSettings"u8);
                writer.WriteObjectValue(SqlLogSettings);
            }
            if (Optional.IsDefined(SqlTempDBSettings))
            {
                writer.WritePropertyName("sqlTempDbSettings"u8);
                writer.WriteObjectValue(SqlTempDBSettings);
            }
            if (Optional.IsDefined(IsSqlSystemDBOnDataDisk))
            {
                writer.WritePropertyName("sqlSystemDbOnDataDisk"u8);
                writer.WriteBooleanValue(IsSqlSystemDBOnDataDisk.Value);
            }
            if (Optional.IsDefined(DiskConfigurationType))
            {
                writer.WritePropertyName("diskConfigurationType"u8);
                writer.WriteStringValue(DiskConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(StorageWorkloadType))
            {
                writer.WritePropertyName("storageWorkloadType"u8);
                writer.WriteStringValue(StorageWorkloadType.Value.ToString());
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

        SqlVmStorageConfigurationSettings IJsonModel<SqlVmStorageConfigurationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmStorageConfigurationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmStorageConfigurationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlVmStorageConfigurationSettings(document.RootElement, options);
        }

        internal static SqlVmStorageConfigurationSettings DeserializeSqlVmStorageConfigurationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlStorageSettings sqlDataSettings = default;
            SqlStorageSettings sqlLogSettings = default;
            SqlTempDBSettings sqlTempDBSettings = default;
            bool? sqlSystemDBOnDataDisk = default;
            SqlVmDiskConfigurationType? diskConfigurationType = default;
            SqlVmStorageWorkloadType? storageWorkloadType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlDataSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlDataSettings = SqlStorageSettings.DeserializeSqlStorageSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlLogSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlLogSettings = SqlStorageSettings.DeserializeSqlStorageSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlTempDbSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlTempDBSettings = SqlTempDBSettings.DeserializeSqlTempDBSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sqlSystemDbOnDataDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlSystemDBOnDataDisk = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskConfigurationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskConfigurationType = new SqlVmDiskConfigurationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageWorkloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageWorkloadType = new SqlVmStorageWorkloadType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlVmStorageConfigurationSettings(
                sqlDataSettings,
                sqlLogSettings,
                sqlTempDBSettings,
                sqlSystemDBOnDataDisk,
                diskConfigurationType,
                storageWorkloadType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlVmStorageConfigurationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmStorageConfigurationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlVmStorageConfigurationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SqlVmStorageConfigurationSettings IPersistableModel<SqlVmStorageConfigurationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmStorageConfigurationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlVmStorageConfigurationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlVmStorageConfigurationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlVmStorageConfigurationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
