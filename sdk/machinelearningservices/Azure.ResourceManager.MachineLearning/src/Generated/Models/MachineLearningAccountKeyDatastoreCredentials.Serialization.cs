// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAccountKeyDatastoreCredentials : IUtf8JsonSerializable, IJsonModel<MachineLearningAccountKeyDatastoreCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAccountKeyDatastoreCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningAccountKeyDatastoreCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreCredentials)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("secrets"u8);
            writer.WriteObjectValue(Secrets);
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        MachineLearningAccountKeyDatastoreCredentials IJsonModel<MachineLearningAccountKeyDatastoreCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreCredentials)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAccountKeyDatastoreCredentials(document.RootElement, options);
        }

        internal static MachineLearningAccountKeyDatastoreCredentials DeserializeMachineLearningAccountKeyDatastoreCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningAccountKeyDatastoreSecrets secrets = default;
            CredentialsType credentialsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secrets"u8))
                {
                    secrets = MachineLearningAccountKeyDatastoreSecrets.DeserializeMachineLearningAccountKeyDatastoreSecrets(property.Value, options);
                    continue;
                }
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningAccountKeyDatastoreCredentials(credentialsType, serializedAdditionalRawData, secrets);
        }

        BinaryData IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreCredentials)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningAccountKeyDatastoreCredentials IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAccountKeyDatastoreCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreCredentials)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAccountKeyDatastoreCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
