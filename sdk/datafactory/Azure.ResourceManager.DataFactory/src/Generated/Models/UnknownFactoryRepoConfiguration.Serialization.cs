// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class UnknownFactoryRepoConfiguration : IUtf8JsonSerializable, IJsonModel<FactoryRepoConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FactoryRepoConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FactoryRepoConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryRepoConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FactoryRepoConfigurationType);
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("repositoryName"u8);
            writer.WriteStringValue(RepositoryName);
            writer.WritePropertyName("collaborationBranch"u8);
            writer.WriteStringValue(CollaborationBranch);
            writer.WritePropertyName("rootFolder"u8);
            writer.WriteStringValue(RootFolder);
            if (Optional.IsDefined(LastCommitId))
            {
                writer.WritePropertyName("lastCommitId"u8);
                writer.WriteStringValue(LastCommitId);
            }
            if (Optional.IsDefined(DisablePublish))
            {
                writer.WritePropertyName("disablePublish"u8);
                writer.WriteBooleanValue(DisablePublish.Value);
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

        FactoryRepoConfiguration IJsonModel<FactoryRepoConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryRepoConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFactoryRepoConfiguration(document.RootElement, options);
        }

        internal static UnknownFactoryRepoConfiguration DeserializeUnknownFactoryRepoConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            string accountName = default;
            string repositoryName = default;
            string collaborationBranch = default;
            string rootFolder = default;
            string lastCommitId = default;
            bool? disablePublish = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"u8))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"u8))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"u8))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disablePublish"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePublish = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownFactoryRepoConfiguration(
                type,
                accountName,
                repositoryName,
                collaborationBranch,
                rootFolder,
                lastCommitId,
                disablePublish,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FactoryRepoConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FactoryRepoConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        FactoryRepoConfiguration IPersistableModel<FactoryRepoConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryRepoConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFactoryRepoConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FactoryRepoConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FactoryRepoConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
