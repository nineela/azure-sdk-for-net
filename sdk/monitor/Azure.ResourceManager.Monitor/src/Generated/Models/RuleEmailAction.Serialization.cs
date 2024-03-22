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
    public partial class RuleEmailAction : IUtf8JsonSerializable, IJsonModel<RuleEmailAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleEmailAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RuleEmailAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEmailAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleEmailAction)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SendToServiceOwners))
            {
                writer.WritePropertyName("sendToServiceOwners"u8);
                writer.WriteBooleanValue(SendToServiceOwners.Value);
            }
            if (Optional.IsCollectionDefined(CustomEmails))
            {
                writer.WritePropertyName("customEmails"u8);
                writer.WriteStartArray();
                foreach (var item in CustomEmails)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("odata.type"u8);
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

        RuleEmailAction IJsonModel<RuleEmailAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEmailAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleEmailAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleEmailAction(document.RootElement, options);
        }

        internal static RuleEmailAction DeserializeRuleEmailAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? sendToServiceOwners = default;
            IList<string> customEmails = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendToServiceOwners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendToServiceOwners = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customEmails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customEmails = array;
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
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
            return new RuleEmailAction(odataType, serializedAdditionalRawData, sendToServiceOwners, customEmails ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<RuleEmailAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEmailAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RuleEmailAction)} does not support writing '{options.Format}' format.");
            }
        }

        RuleEmailAction IPersistableModel<RuleEmailAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleEmailAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRuleEmailAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuleEmailAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuleEmailAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
