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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapsePrivateEndpointConnectionProperties : IUtf8JsonSerializable, IJsonModel<SynapsePrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapsePrivateEndpointConnectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapsePrivateEndpointConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapsePrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapsePrivateEndpointConnectionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(ConnectionState);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        SynapsePrivateEndpointConnectionProperties IJsonModel<SynapsePrivateEndpointConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapsePrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapsePrivateEndpointConnectionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapsePrivateEndpointConnectionProperties(document.RootElement, options);
        }

        internal static SynapsePrivateEndpointConnectionProperties DeserializeSynapsePrivateEndpointConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubResource privateEndpoint = default;
            SynapsePrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            string provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = SynapsePrivateLinkServiceConnectionState.DeserializeSynapsePrivateLinkServiceConnectionState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapsePrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapsePrivateEndpointConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapsePrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapsePrivateEndpointConnectionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SynapsePrivateEndpointConnectionProperties IPersistableModel<SynapsePrivateEndpointConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapsePrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapsePrivateEndpointConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapsePrivateEndpointConnectionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapsePrivateEndpointConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
