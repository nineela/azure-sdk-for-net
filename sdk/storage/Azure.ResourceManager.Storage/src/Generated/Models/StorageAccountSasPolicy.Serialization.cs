// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountSasPolicy : IUtf8JsonSerializable, IJsonModel<StorageAccountSasPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountSasPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountSasPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountSasPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountSasPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sasExpirationPeriod"u8);
            writer.WriteStringValue(SasExpirationPeriod);
            writer.WritePropertyName("expirationAction"u8);
            writer.WriteStringValue(ExpirationAction.ToString());
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

        StorageAccountSasPolicy IJsonModel<StorageAccountSasPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountSasPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountSasPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountSasPolicy(document.RootElement, options);
        }

        internal static StorageAccountSasPolicy DeserializeStorageAccountSasPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sasExpirationPeriod = default;
            ExpirationAction expirationAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasExpirationPeriod"u8))
                {
                    sasExpirationPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationAction"u8))
                {
                    expirationAction = new ExpirationAction(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountSasPolicy(sasExpirationPeriod, expirationAction, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountSasPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountSasPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountSasPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        StorageAccountSasPolicy IPersistableModel<StorageAccountSasPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountSasPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountSasPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountSasPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountSasPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
