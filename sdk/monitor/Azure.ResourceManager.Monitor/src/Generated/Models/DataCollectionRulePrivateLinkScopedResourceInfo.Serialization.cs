// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRulePrivateLinkScopedResourceInfo : IUtf8JsonSerializable, IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ScopeId))
            {
                writer.WritePropertyName("scopeId"u8);
                writer.WriteStringValue(ScopeId);
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

        DataCollectionRulePrivateLinkScopedResourceInfo IJsonModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(document.RootElement, options);
        }

        internal static DataCollectionRulePrivateLinkScopedResourceInfo DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            string scopeId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scopeId"u8))
                {
                    scopeId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRulePrivateLinkScopedResourceInfo(resourceId, scopeId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionRulePrivateLinkScopedResourceInfo IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionRulePrivateLinkScopedResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRulePrivateLinkScopedResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRulePrivateLinkScopedResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
