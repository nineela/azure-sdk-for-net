// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudClusterData : IUtf8JsonSerializable, IJsonModel<NetworkCloudClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudClusterData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudClusterData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("aggregatorOrSingleRackDefinition"u8);
            writer.WriteObjectValue(AggregatorOrSingleRackDefinition);
            if (Optional.IsDefined(AnalyticsWorkspaceId))
            {
                writer.WritePropertyName("analyticsWorkspaceId"u8);
                writer.WriteStringValue(AnalyticsWorkspaceId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AvailableUpgradeVersions))
            {
                writer.WritePropertyName("availableUpgradeVersions"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableUpgradeVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterCapacity))
            {
                writer.WritePropertyName("clusterCapacity"u8);
                writer.WriteObjectValue(ClusterCapacity);
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterConnectionStatus))
            {
                writer.WritePropertyName("clusterConnectionStatus"u8);
                writer.WriteStringValue(ClusterConnectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterExtendedLocation))
            {
                writer.WritePropertyName("clusterExtendedLocation"u8);
                writer.WriteObjectValue(ClusterExtendedLocation);
            }
            if (Optional.IsDefined(ClusterLocation))
            {
                writer.WritePropertyName("clusterLocation"u8);
                writer.WriteStringValue(ClusterLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterManagerConnectionStatus))
            {
                writer.WritePropertyName("clusterManagerConnectionStatus"u8);
                writer.WriteStringValue(ClusterManagerConnectionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterManagerId))
            {
                writer.WritePropertyName("clusterManagerId"u8);
                writer.WriteStringValue(ClusterManagerId);
            }
            if (Optional.IsDefined(ClusterServicePrincipal))
            {
                writer.WritePropertyName("clusterServicePrincipal"u8);
                writer.WriteObjectValue(ClusterServicePrincipal);
            }
            writer.WritePropertyName("clusterType"u8);
            writer.WriteStringValue(ClusterType.ToString());
            writer.WritePropertyName("clusterVersion"u8);
            writer.WriteStringValue(ClusterVersion);
            if (Optional.IsDefined(ComputeDeploymentThreshold))
            {
                writer.WritePropertyName("computeDeploymentThreshold"u8);
                writer.WriteObjectValue(ComputeDeploymentThreshold);
            }
            if (Optional.IsCollectionDefined(ComputeRackDefinitions))
            {
                writer.WritePropertyName("computeRackDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in ComputeRackDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(HybridAksExtendedLocation))
            {
                writer.WritePropertyName("hybridAksExtendedLocation"u8);
                writer.WriteObjectValue(HybridAksExtendedLocation);
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(ManualActionCount))
            {
                writer.WritePropertyName("manualActionCount"u8);
                writer.WriteNumberValue(ManualActionCount.Value);
            }
            writer.WritePropertyName("networkFabricId"u8);
            writer.WriteStringValue(NetworkFabricId);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SupportExpireOn))
            {
                writer.WritePropertyName("supportExpiryDate"u8);
                writer.WriteStringValue(SupportExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(WorkloadResourceIds))
            {
                writer.WritePropertyName("workloadResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in WorkloadResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        NetworkCloudClusterData IJsonModel<NetworkCloudClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudClusterData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudClusterData(document.RootElement, options);
        }

        internal static NetworkCloudClusterData DeserializeNetworkCloudClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            NetworkCloudRackDefinition aggregatorOrSingleRackDefinition = default;
            ResourceIdentifier analyticsWorkspaceId = default;
            IReadOnlyList<ClusterAvailableUpgradeVersion> availableUpgradeVersions = default;
            ClusterCapacity clusterCapacity = default;
            ClusterConnectionStatus? clusterConnectionStatus = default;
            ExtendedLocation clusterExtendedLocation = default;
            string clusterLocation = default;
            ClusterManagerConnectionStatus? clusterManagerConnectionStatus = default;
            ResourceIdentifier clusterManagerId = default;
            ServicePrincipalInformation clusterServicePrincipal = default;
            ClusterType clusterType = default;
            string clusterVersion = default;
            ValidationThreshold computeDeploymentThreshold = default;
            IList<NetworkCloudRackDefinition> computeRackDefinitions = default;
            ClusterDetailedStatus? detailedStatus = default;
            string detailedStatusMessage = default;
            ExtendedLocation hybridAksExtendedLocation = default;
            ManagedResourceGroupConfiguration managedResourceGroupConfiguration = default;
            long? manualActionCount = default;
            ResourceIdentifier networkFabricId = default;
            ClusterProvisioningState? provisioningState = default;
            DateTimeOffset? supportExpiryDate = default;
            IReadOnlyList<ResourceIdentifier> workloadResourceIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("aggregatorOrSingleRackDefinition"u8))
                        {
                            aggregatorOrSingleRackDefinition = NetworkCloudRackDefinition.DeserializeNetworkCloudRackDefinition(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("analyticsWorkspaceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            analyticsWorkspaceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availableUpgradeVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterAvailableUpgradeVersion> array = new List<ClusterAvailableUpgradeVersion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterAvailableUpgradeVersion.DeserializeClusterAvailableUpgradeVersion(item, options));
                            }
                            availableUpgradeVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterCapacity = ClusterCapacity.DeserializeClusterCapacity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clusterConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterConnectionStatus = new ClusterConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterExtendedLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterExtendedLocation = ExtendedLocation.DeserializeExtendedLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clusterLocation"u8))
                        {
                            clusterLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterManagerConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterManagerConnectionStatus = new ClusterManagerConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterManagerId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterManagerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterServicePrincipal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterServicePrincipal = ServicePrincipalInformation.DeserializeServicePrincipalInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            clusterType = new ClusterType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterVersion"u8))
                        {
                            clusterVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeDeploymentThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeDeploymentThreshold = ValidationThreshold.DeserializeValidationThreshold(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("computeRackDefinitions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudRackDefinition> array = new List<NetworkCloudRackDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudRackDefinition.DeserializeNetworkCloudRackDefinition(item, options));
                            }
                            computeRackDefinitions = array;
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new ClusterDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hybridAksExtendedLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hybridAksExtendedLocation = ExtendedLocation.DeserializeExtendedLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("manualActionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            manualActionCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("networkFabricId"u8))
                        {
                            networkFabricId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ClusterProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportExpiryDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportExpiryDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("workloadResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            workloadResourceIds = array;
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
            return new NetworkCloudClusterData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                aggregatorOrSingleRackDefinition,
                analyticsWorkspaceId,
                availableUpgradeVersions ?? new ChangeTrackingList<ClusterAvailableUpgradeVersion>(),
                clusterCapacity,
                clusterConnectionStatus,
                clusterExtendedLocation,
                clusterLocation,
                clusterManagerConnectionStatus,
                clusterManagerId,
                clusterServicePrincipal,
                clusterType,
                clusterVersion,
                computeDeploymentThreshold,
                computeRackDefinitions ?? new ChangeTrackingList<NetworkCloudRackDefinition>(),
                detailedStatus,
                detailedStatusMessage,
                hybridAksExtendedLocation,
                managedResourceGroupConfiguration,
                manualActionCount,
                networkFabricId,
                provisioningState,
                supportExpiryDate,
                workloadResourceIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudClusterData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudClusterData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudClusterData IPersistableModel<NetworkCloudClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudClusterData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudClusterData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
