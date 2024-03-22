// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputePrivateLinkScopeProperties : IUtf8JsonSerializable, IJsonModel<HybridComputePrivateLinkScopeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputePrivateLinkScopeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputePrivateLinkScopeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputePrivateLinkScopeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputePrivateLinkScopeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateLinkScopeId))
            {
                writer.WritePropertyName("privateLinkScopeId"u8);
                writer.WriteStringValue(PrivateLinkScopeId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        HybridComputePrivateLinkScopeProperties IJsonModel<HybridComputePrivateLinkScopeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputePrivateLinkScopeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputePrivateLinkScopeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputePrivateLinkScopeProperties(document.RootElement, options);
        }

        internal static HybridComputePrivateLinkScopeProperties DeserializeHybridComputePrivateLinkScopeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HybridComputePublicNetworkAccessType? publicNetworkAccess = default;
            string provisioningState = default;
            string privateLinkScopeId = default;
            IReadOnlyList<PrivateEndpointConnectionDataModel> privateEndpointConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HybridComputePublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkScopeId"u8))
                {
                    privateLinkScopeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateEndpointConnectionDataModel> array = new List<PrivateEndpointConnectionDataModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointConnectionDataModel.DeserializePrivateEndpointConnectionDataModel(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputePrivateLinkScopeProperties(publicNetworkAccess, provisioningState, privateLinkScopeId, privateEndpointConnections ?? new ChangeTrackingList<PrivateEndpointConnectionDataModel>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputePrivateLinkScopeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputePrivateLinkScopeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputePrivateLinkScopeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HybridComputePrivateLinkScopeProperties IPersistableModel<HybridComputePrivateLinkScopeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputePrivateLinkScopeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputePrivateLinkScopeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputePrivateLinkScopeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputePrivateLinkScopeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
