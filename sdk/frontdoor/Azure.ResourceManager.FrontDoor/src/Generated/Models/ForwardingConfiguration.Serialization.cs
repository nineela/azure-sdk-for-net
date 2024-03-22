// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ForwardingConfiguration : IUtf8JsonSerializable, IJsonModel<ForwardingConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForwardingConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ForwardingConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardingConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForwardingConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomForwardingPath))
            {
                writer.WritePropertyName("customForwardingPath"u8);
                writer.WriteStringValue(CustomForwardingPath);
            }
            if (Optional.IsDefined(ForwardingProtocol))
            {
                writer.WritePropertyName("forwardingProtocol"u8);
                writer.WriteStringValue(ForwardingProtocol.Value.ToString());
            }
            if (Optional.IsDefined(CacheConfiguration))
            {
                if (CacheConfiguration != null)
                {
                    writer.WritePropertyName("cacheConfiguration"u8);
                    writer.WriteObjectValue(CacheConfiguration);
                }
                else
                {
                    writer.WriteNull("cacheConfiguration");
                }
            }
            if (Optional.IsDefined(BackendPool))
            {
                writer.WritePropertyName("backendPool"u8);
                JsonSerializer.Serialize(writer, BackendPool);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ForwardingConfiguration IJsonModel<ForwardingConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardingConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForwardingConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForwardingConfiguration(document.RootElement, options);
        }

        internal static ForwardingConfiguration DeserializeForwardingConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customForwardingPath = default;
            FrontDoorForwardingProtocol? forwardingProtocol = default;
            FrontDoorCacheConfiguration cacheConfiguration = default;
            WritableSubResource backendPool = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customForwardingPath"u8))
                {
                    customForwardingPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forwardingProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardingProtocol = new FrontDoorForwardingProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cacheConfiguration = null;
                        continue;
                    }
                    cacheConfiguration = FrontDoorCacheConfiguration.DeserializeFrontDoorCacheConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("backendPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPool = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ForwardingConfiguration(
                odataType,
                serializedAdditionalRawData,
                customForwardingPath,
                forwardingProtocol,
                cacheConfiguration,
                backendPool);
        }

        BinaryData IPersistableModel<ForwardingConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardingConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ForwardingConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ForwardingConfiguration IPersistableModel<ForwardingConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardingConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForwardingConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForwardingConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForwardingConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
