// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicContentLink : IUtf8JsonSerializable, IJsonModel<LogicContentLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicContentLink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicContentLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicContentLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicContentLink)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(ContentVersion))
            {
                writer.WritePropertyName("contentVersion"u8);
                writer.WriteStringValue(ContentVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ContentSize))
            {
                writer.WritePropertyName("contentSize"u8);
                writer.WriteNumberValue(ContentSize.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ContentHash))
            {
                writer.WritePropertyName("contentHash"u8);
                writer.WriteObjectValue(ContentHash);
            }
            if (options.Format != "W" && Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        LogicContentLink IJsonModel<LogicContentLink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicContentLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicContentLink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicContentLink(document.RootElement, options);
        }

        internal static LogicContentLink DeserializeLogicContentLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri uri = default;
            string contentVersion = default;
            long? contentSize = default;
            LogicContentHash contentHash = default;
            BinaryData metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentVersion"u8))
                {
                    contentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("contentHash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentHash = LogicContentHash.DeserializeLogicContentHash(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicContentLink(
                uri,
                contentVersion,
                contentSize,
                contentHash,
                metadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicContentLink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicContentLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicContentLink)} does not support writing '{options.Format}' format.");
            }
        }

        LogicContentLink IPersistableModel<LogicContentLink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicContentLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicContentLink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicContentLink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicContentLink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
