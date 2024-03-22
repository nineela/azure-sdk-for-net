// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class KpiAlias : IUtf8JsonSerializable, IJsonModel<KpiAlias>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KpiAlias>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KpiAlias>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiAlias>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KpiAlias)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("aliasName"u8);
            writer.WriteStringValue(AliasName);
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
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

        KpiAlias IJsonModel<KpiAlias>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiAlias>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KpiAlias)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKpiAlias(document.RootElement, options);
        }

        internal static KpiAlias DeserializeKpiAlias(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aliasName = default;
            string expression = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aliasName"u8))
                {
                    aliasName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KpiAlias(aliasName, expression, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KpiAlias>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiAlias>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KpiAlias)} does not support writing '{options.Format}' format.");
            }
        }

        KpiAlias IPersistableModel<KpiAlias>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiAlias>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKpiAlias(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KpiAlias)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KpiAlias>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
