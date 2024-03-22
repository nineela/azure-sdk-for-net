// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class LinkedOperationRule : IUtf8JsonSerializable, IJsonModel<LinkedOperationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedOperationRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkedOperationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedOperationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedOperationRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("linkedOperation"u8);
            writer.WriteStringValue(LinkedOperation.ToString());
            writer.WritePropertyName("linkedAction"u8);
            writer.WriteStringValue(LinkedAction.ToString());
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

        LinkedOperationRule IJsonModel<LinkedOperationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedOperationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedOperationRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedOperationRule(document.RootElement, options);
        }

        internal static LinkedOperationRule DeserializeLinkedOperationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedOperation linkedOperation = default;
            LinkedAction linkedAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedOperation"u8))
                {
                    linkedOperation = new LinkedOperation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("linkedAction"u8))
                {
                    linkedAction = new LinkedAction(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkedOperationRule(linkedOperation, linkedAction, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkedOperationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedOperationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkedOperationRule)} does not support writing '{options.Format}' format.");
            }
        }

        LinkedOperationRule IPersistableModel<LinkedOperationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedOperationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkedOperationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkedOperationRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkedOperationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
