// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class InternetGatewayRules : IUtf8JsonSerializable, IJsonModel<InternetGatewayRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternetGatewayRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InternetGatewayRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternetGatewayRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternetGatewayRules)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WritePropertyName("addressList"u8);
            writer.WriteStartArray();
            foreach (var item in AddressList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        InternetGatewayRules IJsonModel<InternetGatewayRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternetGatewayRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternetGatewayRules)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternetGatewayRules(document.RootElement, options);
        }

        internal static InternetGatewayRules DeserializeInternetGatewayRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternetGatewayRuleAction action = default;
            IList<string> addressList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    action = new InternetGatewayRuleAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InternetGatewayRules(action, addressList, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternetGatewayRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternetGatewayRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternetGatewayRules)} does not support writing '{options.Format}' format.");
            }
        }

        InternetGatewayRules IPersistableModel<InternetGatewayRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternetGatewayRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternetGatewayRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternetGatewayRules)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternetGatewayRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
