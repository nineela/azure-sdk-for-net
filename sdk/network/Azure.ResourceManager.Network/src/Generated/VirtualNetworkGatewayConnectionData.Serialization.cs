// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkGatewayConnectionData : IUtf8JsonSerializable, IJsonModel<VirtualNetworkGatewayConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkGatewayConnectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualNetworkGatewayConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayConnectionData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey"u8);
                writer.WriteStringValue(AuthorizationKey);
            }
            writer.WritePropertyName("virtualNetworkGateway1"u8);
            writer.WriteObjectValue(VirtualNetworkGateway1);
            if (Optional.IsDefined(VirtualNetworkGateway2))
            {
                writer.WritePropertyName("virtualNetworkGateway2"u8);
                writer.WriteObjectValue(VirtualNetworkGateway2);
            }
            if (Optional.IsDefined(LocalNetworkGateway2))
            {
                writer.WritePropertyName("localNetworkGateway2"u8);
                writer.WriteObjectValue(LocalNetworkGateway2);
            }
            if (Optional.IsCollectionDefined(IngressNatRules))
            {
                writer.WritePropertyName("ingressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in IngressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EgressNatRules))
            {
                writer.WritePropertyName("egressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("connectionType"u8);
            writer.WriteStringValue(ConnectionType.ToString());
            if (Optional.IsDefined(ConnectionProtocol))
            {
                writer.WritePropertyName("connectionProtocol"u8);
                writer.WriteStringValue(ConnectionProtocol.Value.ToString());
            }
            if (Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight"u8);
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Optional.IsDefined(DpdTimeoutSeconds))
            {
                writer.WritePropertyName("dpdTimeoutSeconds"u8);
                writer.WriteNumberValue(DpdTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(ConnectionMode))
            {
                writer.WritePropertyName("connectionMode"u8);
                writer.WriteStringValue(ConnectionMode.Value.ToString());
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionStatus))
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(TunnelConnectionStatus))
            {
                writer.WritePropertyName("tunnelConnectionStatus"u8);
                writer.WriteStartArray();
                foreach (var item in TunnelConnectionStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(EgressBytesTransferred))
            {
                writer.WritePropertyName("egressBytesTransferred"u8);
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IngressBytesTransferred))
            {
                writer.WritePropertyName("ingressBytesTransferred"u8);
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (Optional.IsDefined(Peer))
            {
                writer.WritePropertyName("peer"u8);
                JsonSerializer.Serialize(writer, Peer);
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp"u8);
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsCollectionDefined(GatewayCustomBgpIPAddresses))
            {
                writer.WritePropertyName("gatewayCustomBgpIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in GatewayCustomBgpIPAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UseLocalAzureIPAddress))
            {
                writer.WritePropertyName("useLocalAzureIpAddress"u8);
                writer.WriteBooleanValue(UseLocalAzureIPAddress.Value);
            }
            if (Optional.IsDefined(UsePolicyBasedTrafficSelectors))
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors"u8);
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (Optional.IsCollectionDefined(IPsecPolicies))
            {
                writer.WritePropertyName("ipsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in IPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrafficSelectorPolicies))
            {
                writer.WritePropertyName("trafficSelectorPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in TrafficSelectorPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ExpressRouteGatewayBypass))
            {
                writer.WritePropertyName("expressRouteGatewayBypass"u8);
                writer.WriteBooleanValue(ExpressRouteGatewayBypass.Value);
            }
            if (Optional.IsDefined(EnablePrivateLinkFastPath))
            {
                writer.WritePropertyName("enablePrivateLinkFastPath"u8);
                writer.WriteBooleanValue(EnablePrivateLinkFastPath.Value);
            }
            writer.WriteEndObject();
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

        VirtualNetworkGatewayConnectionData IJsonModel<VirtualNetworkGatewayConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayConnectionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkGatewayConnectionData(document.RootElement, options);
        }

        internal static VirtualNetworkGatewayConnectionData DeserializeVirtualNetworkGatewayConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            string authorizationKey = default;
            VirtualNetworkGatewayData virtualNetworkGateway1 = default;
            VirtualNetworkGatewayData virtualNetworkGateway2 = default;
            LocalNetworkGatewayData localNetworkGateway2 = default;
            IList<WritableSubResource> ingressNatRules = default;
            IList<WritableSubResource> egressNatRules = default;
            VirtualNetworkGatewayConnectionType connectionType = default;
            VirtualNetworkGatewayConnectionProtocol? connectionProtocol = default;
            int? routingWeight = default;
            int? dpdTimeoutSeconds = default;
            VirtualNetworkGatewayConnectionMode? connectionMode = default;
            string sharedKey = default;
            VirtualNetworkGatewayConnectionStatus? connectionStatus = default;
            IReadOnlyList<TunnelConnectionHealth> tunnelConnectionStatus = default;
            long? egressBytesTransferred = default;
            long? ingressBytesTransferred = default;
            WritableSubResource peer = default;
            bool? enableBgp = default;
            IList<GatewayCustomBgpIPAddressIPConfiguration> gatewayCustomBgpIPAddresses = default;
            bool? useLocalAzureIPAddress = default;
            bool? usePolicyBasedTrafficSelectors = default;
            IList<IPsecPolicy> ipsecPolicies = default;
            IList<TrafficSelectorPolicy> trafficSelectorPolicies = default;
            Guid? resourceGuid = default;
            NetworkProvisioningState? provisioningState = default;
            bool? expressRouteGatewayBypass = default;
            bool? enablePrivateLinkFastPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authorizationKey"u8))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway1"u8))
                        {
                            virtualNetworkGateway1 = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkGateway2 = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("localNetworkGateway2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localNetworkGateway2 = LocalNetworkGatewayData.DeserializeLocalNetworkGatewayData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ingressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ingressNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("egressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            egressNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("connectionType"u8))
                        {
                            connectionType = new VirtualNetworkGatewayConnectionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionProtocol = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dpdTimeoutSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dpdTimeoutSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionMode = new VirtualNetworkGatewayConnectionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VirtualNetworkGatewayConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tunnelConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TunnelConnectionHealth> array = new List<TunnelConnectionHealth>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TunnelConnectionHealth.DeserializeTunnelConnectionHealth(item, options));
                            }
                            tunnelConnectionStatus = array;
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peer = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gatewayCustomBgpIpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GatewayCustomBgpIPAddressIPConfiguration> array = new List<GatewayCustomBgpIPAddressIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GatewayCustomBgpIPAddressIPConfiguration.DeserializeGatewayCustomBgpIPAddressIPConfiguration(item, options));
                            }
                            gatewayCustomBgpIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPsecPolicy> array = new List<IPsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPsecPolicy.DeserializeIPsecPolicy(item, options));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficSelectorPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficSelectorPolicy> array = new List<TrafficSelectorPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficSelectorPolicy.DeserializeTrafficSelectorPolicy(item, options));
                            }
                            trafficSelectorPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGatewayBypass"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGatewayBypass = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePrivateLinkFastPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePrivateLinkFastPath = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualNetworkGatewayConnectionData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                etag,
                authorizationKey,
                virtualNetworkGateway1,
                virtualNetworkGateway2,
                localNetworkGateway2,
                ingressNatRules ?? new ChangeTrackingList<WritableSubResource>(),
                egressNatRules ?? new ChangeTrackingList<WritableSubResource>(),
                connectionType,
                connectionProtocol,
                routingWeight,
                dpdTimeoutSeconds,
                connectionMode,
                sharedKey,
                connectionStatus,
                tunnelConnectionStatus ?? new ChangeTrackingList<TunnelConnectionHealth>(),
                egressBytesTransferred,
                ingressBytesTransferred,
                peer,
                enableBgp,
                gatewayCustomBgpIPAddresses ?? new ChangeTrackingList<GatewayCustomBgpIPAddressIPConfiguration>(),
                useLocalAzureIPAddress,
                usePolicyBasedTrafficSelectors,
                ipsecPolicies ?? new ChangeTrackingList<IPsecPolicy>(),
                trafficSelectorPolicies ?? new ChangeTrackingList<TrafficSelectorPolicy>(),
                resourceGuid,
                provisioningState,
                expressRouteGatewayBypass,
                enablePrivateLinkFastPath);
        }

        BinaryData IPersistableModel<VirtualNetworkGatewayConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkGatewayConnectionData)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualNetworkGatewayConnectionData IPersistableModel<VirtualNetworkGatewayConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkGatewayConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualNetworkGatewayConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkGatewayConnectionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkGatewayConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
