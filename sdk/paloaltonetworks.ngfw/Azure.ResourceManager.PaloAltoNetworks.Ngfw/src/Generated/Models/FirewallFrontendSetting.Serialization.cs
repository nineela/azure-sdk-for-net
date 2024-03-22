// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallFrontendSetting : IUtf8JsonSerializable, IJsonModel<FirewallFrontendSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallFrontendSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallFrontendSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallFrontendSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallFrontendSetting)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            writer.WritePropertyName("frontendConfiguration"u8);
            writer.WriteObjectValue(FrontendConfiguration);
            writer.WritePropertyName("backendConfiguration"u8);
            writer.WriteObjectValue(BackendConfiguration);
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

        FirewallFrontendSetting IJsonModel<FirewallFrontendSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallFrontendSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallFrontendSetting)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallFrontendSetting(document.RootElement, options);
        }

        internal static FirewallFrontendSetting DeserializeFirewallFrontendSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            FirewallProtocolType protocol = default;
            FirewallEndpointConfiguration frontendConfiguration = default;
            FirewallEndpointConfiguration backendConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new FirewallProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontendConfiguration"u8))
                {
                    frontendConfiguration = FirewallEndpointConfiguration.DeserializeFirewallEndpointConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("backendConfiguration"u8))
                {
                    backendConfiguration = FirewallEndpointConfiguration.DeserializeFirewallEndpointConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallFrontendSetting(name, protocol, frontendConfiguration, backendConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallFrontendSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallFrontendSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallFrontendSetting)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallFrontendSetting IPersistableModel<FirewallFrontendSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallFrontendSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallFrontendSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallFrontendSetting)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallFrontendSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
