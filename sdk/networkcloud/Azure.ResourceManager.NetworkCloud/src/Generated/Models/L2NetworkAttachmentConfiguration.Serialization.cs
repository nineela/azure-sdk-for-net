// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class L2NetworkAttachmentConfiguration : IUtf8JsonSerializable, IJsonModel<L2NetworkAttachmentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<L2NetworkAttachmentConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<L2NetworkAttachmentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L2NetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(L2NetworkAttachmentConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("networkId"u8);
            writer.WriteStringValue(NetworkId);
            if (Optional.IsDefined(PluginType))
            {
                writer.WritePropertyName("pluginType"u8);
                writer.WriteStringValue(PluginType.Value.ToString());
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

        L2NetworkAttachmentConfiguration IJsonModel<L2NetworkAttachmentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L2NetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(L2NetworkAttachmentConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeL2NetworkAttachmentConfiguration(document.RootElement, options);
        }

        internal static L2NetworkAttachmentConfiguration DeserializeL2NetworkAttachmentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier networkId = default;
            KubernetesPluginType? pluginType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkId"u8))
                {
                    networkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("pluginType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginType = new KubernetesPluginType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new L2NetworkAttachmentConfiguration(networkId, pluginType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<L2NetworkAttachmentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L2NetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(L2NetworkAttachmentConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        L2NetworkAttachmentConfiguration IPersistableModel<L2NetworkAttachmentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L2NetworkAttachmentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeL2NetworkAttachmentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(L2NetworkAttachmentConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<L2NetworkAttachmentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
