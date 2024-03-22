// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CryptoKeyResult : IUtf8JsonSerializable, IJsonModel<CryptoKeyResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CryptoKeyResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CryptoKeyResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeyResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CryptoKeyResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CryptoKeyId))
            {
                if (CryptoKeyId != null)
                {
                    writer.WritePropertyName("cryptoKeyId"u8);
                    writer.WriteStringValue(CryptoKeyId);
                }
                else
                {
                    writer.WriteNull("cryptoKeyId");
                }
            }
            if (Optional.IsDefined(KeyType))
            {
                if (KeyType != null)
                {
                    writer.WritePropertyName("keyType"u8);
                    writer.WriteStringValue(KeyType);
                }
                else
                {
                    writer.WriteNull("keyType");
                }
            }
            if (Optional.IsDefined(KeySize))
            {
                if (KeySize != null)
                {
                    writer.WritePropertyName("keySize"u8);
                    writer.WriteNumberValue(KeySize.Value);
                }
                else
                {
                    writer.WriteNull("keySize");
                }
            }
            if (Optional.IsDefined(KeyAlgorithm))
            {
                if (KeyAlgorithm != null)
                {
                    writer.WritePropertyName("keyAlgorithm"u8);
                    writer.WriteStringValue(KeyAlgorithm);
                }
                else
                {
                    writer.WriteNull("keyAlgorithm");
                }
            }
            if (Optional.IsCollectionDefined(Usage))
            {
                if (Usage != null)
                {
                    writer.WritePropertyName("usage"u8);
                    writer.WriteStartArray();
                    foreach (var item in Usage)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("usage");
                }
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FilePaths))
            {
                if (FilePaths != null)
                {
                    writer.WritePropertyName("filePaths"u8);
                    writer.WriteStartArray();
                    foreach (var item in FilePaths)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("filePaths");
                }
            }
            if (Optional.IsDefined(PairedKey))
            {
                if (PairedKey != null)
                {
                    writer.WritePropertyName("pairedKey"u8);
                    writer.WriteObjectValue(PairedKey);
                }
                else
                {
                    writer.WriteNull("pairedKey");
                }
            }
            if (Optional.IsDefined(IsShortKeySize))
            {
                if (IsShortKeySize != null)
                {
                    writer.WritePropertyName("isShortKeySize"u8);
                    writer.WriteBooleanValue(IsShortKeySize.Value);
                }
                else
                {
                    writer.WriteNull("isShortKeySize");
                }
            }
            writer.WriteEndObject();
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

        CryptoKeyResult IJsonModel<CryptoKeyResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeyResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CryptoKeyResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCryptoKeyResult(document.RootElement, options);
        }

        internal static CryptoKeyResult DeserializeCryptoKeyResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string cryptoKeyId = default;
            string keyType = default;
            long? keySize = default;
            string keyAlgorithm = default;
            IList<string> usage = default;
            IReadOnlyList<string> filePaths = default;
            CryptoPairedKey pairedKey = default;
            bool? isShortKeySize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cryptoKeyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cryptoKeyId = null;
                                continue;
                            }
                            cryptoKeyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                keyType = null;
                                continue;
                            }
                            keyType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                keySize = null;
                                continue;
                            }
                            keySize = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("keyAlgorithm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                keyAlgorithm = null;
                                continue;
                            }
                            keyAlgorithm = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            usage = array;
                            continue;
                        }
                        if (property0.NameEquals("filePaths"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            filePaths = array;
                            continue;
                        }
                        if (property0.NameEquals("pairedKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                pairedKey = null;
                                continue;
                            }
                            pairedKey = CryptoPairedKey.DeserializeCryptoPairedKey(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isShortKeySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isShortKeySize = null;
                                continue;
                            }
                            isShortKeySize = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CryptoKeyResult(
                id,
                name,
                type,
                systemData,
                cryptoKeyId,
                keyType,
                keySize,
                keyAlgorithm,
                usage ?? new ChangeTrackingList<string>(),
                filePaths ?? new ChangeTrackingList<string>(),
                pairedKey,
                isShortKeySize,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CryptoKeyResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeyResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CryptoKeyResult)} does not support writing '{options.Format}' format.");
            }
        }

        CryptoKeyResult IPersistableModel<CryptoKeyResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeyResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCryptoKeyResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CryptoKeyResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CryptoKeyResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
