// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkInterface : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                writer.WritePropertyName("networkSecurityGroup");
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (Optional.IsCollectionDefined(IpConfigurations))
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                writer.WritePropertyName("enableAcceleratedNetworking");
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (Optional.IsDefined(EnableIPForwarding))
            {
                writer.WritePropertyName("enableIPForwarding");
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkInterface DeserializeNetworkInterface(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SubResource> virtualMachine = default;
            Optional<NetworkSecurityGroup> networkSecurityGroup = default;
            Optional<PrivateEndpoint> privateEndpoint = default;
            Optional<IList<NetworkInterfaceIPConfiguration>> ipConfigurations = default;
            Optional<IReadOnlyList<NetworkInterfaceTapConfiguration>> tapConfigurations = default;
            Optional<NetworkInterfaceDnsSettings> dnsSettings = default;
            Optional<string> macAddress = default;
            Optional<bool> primary = default;
            Optional<bool> enableAcceleratedNetworking = default;
            Optional<bool> enableIPForwarding = default;
            Optional<IReadOnlyList<string>> hostedWorkloads = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualMachine"))
                        {
                            virtualMachine = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"))
                        {
                            networkSecurityGroup = NetworkSecurityGroup.DeserializeNetworkSecurityGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoint"))
                        {
                            privateEndpoint = PrivateEndpoint.DeserializePrivateEndpoint(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            List<NetworkInterfaceIPConfiguration> array = new List<NetworkInterfaceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("tapConfigurations"))
                        {
                            List<NetworkInterfaceTapConfiguration> array = new List<NetworkInterfaceTapConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceTapConfiguration.DeserializeNetworkInterfaceTapConfiguration(item));
                            }
                            tapConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            dnsSettings = NetworkInterfaceDnsSettings.DeserializeNetworkInterfaceDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("macAddress"))
                        {
                            macAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primary"))
                        {
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"))
                        {
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableIPForwarding"))
                        {
                            enableIPForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostedWorkloads"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hostedWorkloads = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkInterface(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, virtualMachine.Value, networkSecurityGroup.Value, privateEndpoint.Value, Optional.ToList(ipConfigurations), Optional.ToList(tapConfigurations), dnsSettings.Value, macAddress.Value, Optional.ToNullable(primary), Optional.ToNullable(enableAcceleratedNetworking), Optional.ToNullable(enableIPForwarding), Optional.ToList(hostedWorkloads), resourceGuid.Value, Optional.ToNullable(provisioningState));
        }
    }
}
