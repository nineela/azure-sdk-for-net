// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountPoolStartTask : IUtf8JsonSerializable, IJsonModel<BatchAccountPoolStartTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPoolStartTask>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountPoolStartTask>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolStartTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CommandLine))
            {
                writer.WritePropertyName("commandLine"u8);
                writer.WriteStringValue(CommandLine);
            }
            if (Optional.IsCollectionDefined(ResourceFiles))
            {
                writer.WritePropertyName("resourceFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentSettings))
            {
                writer.WritePropertyName("environmentSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteObjectValue(UserIdentity);
            }
            if (Optional.IsDefined(MaxTaskRetryCount))
            {
                writer.WritePropertyName("maxTaskRetryCount"u8);
                writer.WriteNumberValue(MaxTaskRetryCount.Value);
            }
            if (Optional.IsDefined(WaitForSuccess))
            {
                writer.WritePropertyName("waitForSuccess"u8);
                writer.WriteBooleanValue(WaitForSuccess.Value);
            }
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings"u8);
                writer.WriteObjectValue(ContainerSettings);
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

        BatchAccountPoolStartTask IJsonModel<BatchAccountPoolStartTask>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolStartTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolStartTask(document.RootElement, options);
        }

        internal static BatchAccountPoolStartTask DeserializeBatchAccountPoolStartTask(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string commandLine = default;
            IList<BatchResourceFile> resourceFiles = default;
            IList<BatchEnvironmentSetting> environmentSettings = default;
            BatchUserIdentity userIdentity = default;
            int? maxTaskRetryCount = default;
            bool? waitForSuccess = default;
            BatchTaskContainerSettings containerSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commandLine"u8))
                {
                    commandLine = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchResourceFile> array = new List<BatchResourceFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchResourceFile.DeserializeBatchResourceFile(item, options));
                    }
                    resourceFiles = array;
                    continue;
                }
                if (property.NameEquals("environmentSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchEnvironmentSetting> array = new List<BatchEnvironmentSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchEnvironmentSetting.DeserializeBatchEnvironmentSetting(item, options));
                    }
                    environmentSettings = array;
                    continue;
                }
                if (property.NameEquals("userIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userIdentity = BatchUserIdentity.DeserializeBatchUserIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("maxTaskRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTaskRetryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("waitForSuccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitForSuccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerSettings = BatchTaskContainerSettings.DeserializeBatchTaskContainerSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountPoolStartTask(
                commandLine,
                resourceFiles ?? new ChangeTrackingList<BatchResourceFile>(),
                environmentSettings ?? new ChangeTrackingList<BatchEnvironmentSetting>(),
                userIdentity,
                maxTaskRetryCount,
                waitForSuccess,
                containerSettings,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountPoolStartTask>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolStartTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support writing '{options.Format}' format.");
            }
        }

        BatchAccountPoolStartTask IPersistableModel<BatchAccountPoolStartTask>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolStartTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountPoolStartTask(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountPoolStartTask)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountPoolStartTask>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
