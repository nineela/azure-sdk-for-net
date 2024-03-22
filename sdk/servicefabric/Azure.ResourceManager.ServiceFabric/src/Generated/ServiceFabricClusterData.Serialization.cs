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
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricClusterData : IUtf8JsonSerializable, IJsonModel<ServiceFabricClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricClusterData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceFabricClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricClusterData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
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
            if (Optional.IsCollectionDefined(AddOnFeatures))
            {
                writer.WritePropertyName("addOnFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in AddOnFeatures)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AvailableClusterVersions))
            {
                writer.WritePropertyName("availableClusterVersions"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableClusterVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory"u8);
                writer.WriteObjectValue(AzureActiveDirectory);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate);
            }
            if (Optional.IsDefined(CertificateCommonNames))
            {
                writer.WritePropertyName("certificateCommonNames"u8);
                writer.WriteObjectValue(CertificateCommonNames);
            }
            if (Optional.IsCollectionDefined(ClientCertificateCommonNames))
            {
                writer.WritePropertyName("clientCertificateCommonNames"u8);
                writer.WriteStartArray();
                foreach (var item in ClientCertificateCommonNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientCertificateThumbprints))
            {
                writer.WritePropertyName("clientCertificateThumbprints"u8);
                writer.WriteStartArray();
                foreach (var item in ClientCertificateThumbprints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClusterCodeVersion))
            {
                writer.WritePropertyName("clusterCodeVersion"u8);
                writer.WriteStringValue(ClusterCodeVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterEndpoint))
            {
                writer.WritePropertyName("clusterEndpoint"u8);
                writer.WriteStringValue(ClusterEndpoint.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterState))
            {
                writer.WritePropertyName("clusterState"u8);
                writer.WriteStringValue(ClusterState.Value.ToString());
            }
            if (Optional.IsDefined(DiagnosticsStorageAccountConfig))
            {
                writer.WritePropertyName("diagnosticsStorageAccountConfig"u8);
                writer.WriteObjectValue(DiagnosticsStorageAccountConfig);
            }
            if (Optional.IsDefined(IsEventStoreServiceEnabled))
            {
                writer.WritePropertyName("eventStoreServiceEnabled"u8);
                writer.WriteBooleanValue(IsEventStoreServiceEnabled.Value);
            }
            if (Optional.IsCollectionDefined(FabricSettings))
            {
                writer.WritePropertyName("fabricSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FabricSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagementEndpoint))
            {
                writer.WritePropertyName("managementEndpoint"u8);
                writer.WriteStringValue(ManagementEndpoint.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(NodeTypes))
            {
                writer.WritePropertyName("nodeTypes"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ReliabilityLevel))
            {
                writer.WritePropertyName("reliabilityLevel"u8);
                writer.WriteStringValue(ReliabilityLevel.Value.ToString());
            }
            if (Optional.IsDefined(ReverseProxyCertificate))
            {
                writer.WritePropertyName("reverseProxyCertificate"u8);
                writer.WriteObjectValue(ReverseProxyCertificate);
            }
            if (Optional.IsDefined(ReverseProxyCertificateCommonNames))
            {
                writer.WritePropertyName("reverseProxyCertificateCommonNames"u8);
                writer.WriteObjectValue(ReverseProxyCertificateCommonNames);
            }
            if (Optional.IsDefined(UpgradeDescription))
            {
                writer.WritePropertyName("upgradeDescription"u8);
                writer.WriteObjectValue(UpgradeDescription);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode"u8);
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationTypeVersionsCleanupPolicy))
            {
                writer.WritePropertyName("applicationTypeVersionsCleanupPolicy"u8);
                writer.WriteObjectValue(ApplicationTypeVersionsCleanupPolicy);
            }
            if (Optional.IsDefined(VmImage))
            {
                writer.WritePropertyName("vmImage"u8);
                writer.WriteStringValue(VmImage);
            }
            if (Optional.IsDefined(ServiceFabricZonalUpgradeMode))
            {
                writer.WritePropertyName("sfZonalUpgradeMode"u8);
                writer.WriteStringValue(ServiceFabricZonalUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(VmssZonalUpgradeMode))
            {
                writer.WritePropertyName("vmssZonalUpgradeMode"u8);
                writer.WriteStringValue(VmssZonalUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(IsInfrastructureServiceManagerEnabled))
            {
                writer.WritePropertyName("infrastructureServiceManager"u8);
                writer.WriteBooleanValue(IsInfrastructureServiceManagerEnabled.Value);
            }
            if (Optional.IsDefined(UpgradeWave))
            {
                writer.WritePropertyName("upgradeWave"u8);
                writer.WriteStringValue(UpgradeWave.Value.ToString());
            }
            if (Optional.IsDefined(UpgradePauseStartOn))
            {
                writer.WritePropertyName("upgradePauseStartTimestampUtc"u8);
                writer.WriteStringValue(UpgradePauseStartOn.Value, "O");
            }
            if (Optional.IsDefined(UpgradePauseEndOn))
            {
                writer.WritePropertyName("upgradePauseEndTimestampUtc"u8);
                writer.WriteStringValue(UpgradePauseEndOn.Value, "O");
            }
            if (Optional.IsDefined(IsWaveUpgradePaused))
            {
                writer.WritePropertyName("waveUpgradePaused"u8);
                writer.WriteBooleanValue(IsWaveUpgradePaused.Value);
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications"u8);
                writer.WriteStartArray();
                foreach (var item in Notifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsHttpGatewayExclusiveAuthModeEnabled))
            {
                writer.WritePropertyName("enableHttpGatewayExclusiveAuthMode"u8);
                writer.WriteBooleanValue(IsHttpGatewayExclusiveAuthModeEnabled.Value);
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

        ServiceFabricClusterData IJsonModel<ServiceFabricClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricClusterData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricClusterData(document.RootElement, options);
        }

        internal static ServiceFabricClusterData DeserializeServiceFabricClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IList<ClusterAddOnFeature> addOnFeatures = default;
            IReadOnlyList<ClusterVersionDetails> availableClusterVersions = default;
            ClusterAadSetting azureActiveDirectory = default;
            ClusterCertificateDescription certificate = default;
            ClusterServerCertificateCommonNames certificateCommonNames = default;
            IList<ClusterClientCertificateCommonName> clientCertificateCommonNames = default;
            IList<ClusterClientCertificateThumbprint> clientCertificateThumbprints = default;
            string clusterCodeVersion = default;
            Uri clusterEndpoint = default;
            Guid? clusterId = default;
            ServiceFabricClusterState? clusterState = default;
            DiagnosticsStorageAccountConfig diagnosticsStorageAccountConfig = default;
            bool? eventStoreServiceEnabled = default;
            IList<SettingsSectionDescription> fabricSettings = default;
            Uri managementEndpoint = default;
            IList<ClusterNodeTypeDescription> nodeTypes = default;
            ServiceFabricProvisioningState? provisioningState = default;
            ClusterReliabilityLevel? reliabilityLevel = default;
            ClusterCertificateDescription reverseProxyCertificate = default;
            ClusterServerCertificateCommonNames reverseProxyCertificateCommonNames = default;
            ClusterUpgradePolicy upgradeDescription = default;
            ClusterUpgradeMode? upgradeMode = default;
            ApplicationTypeVersionsCleanupPolicy applicationTypeVersionsCleanupPolicy = default;
            string vmImage = default;
            SfZonalUpgradeMode? sfZonalUpgradeMode = default;
            VmssZonalUpgradeMode? vmssZonalUpgradeMode = default;
            bool? infrastructureServiceManager = default;
            ClusterUpgradeCadence? upgradeWave = default;
            DateTimeOffset? upgradePauseStartTimestampUtc = default;
            DateTimeOffset? upgradePauseEndTimestampUtc = default;
            bool? waveUpgradePaused = default;
            IList<ClusterNotification> notifications = default;
            bool? enableHttpGatewayExclusiveAuthMode = default;
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
                        if (property0.NameEquals("addOnFeatures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterAddOnFeature> array = new List<ClusterAddOnFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ClusterAddOnFeature(item.GetString()));
                            }
                            addOnFeatures = array;
                            continue;
                        }
                        if (property0.NameEquals("availableClusterVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterVersionDetails> array = new List<ClusterVersionDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterVersionDetails.DeserializeClusterVersionDetails(item, options));
                            }
                            availableClusterVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureActiveDirectory = ClusterAadSetting.DeserializeClusterAadSetting(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("certificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certificate = ClusterCertificateDescription.DeserializeClusterCertificateDescription(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("certificateCommonNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certificateCommonNames = ClusterServerCertificateCommonNames.DeserializeClusterServerCertificateCommonNames(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clientCertificateCommonNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterClientCertificateCommonName> array = new List<ClusterClientCertificateCommonName>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterClientCertificateCommonName.DeserializeClusterClientCertificateCommonName(item, options));
                            }
                            clientCertificateCommonNames = array;
                            continue;
                        }
                        if (property0.NameEquals("clientCertificateThumbprints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterClientCertificateThumbprint> array = new List<ClusterClientCertificateThumbprint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterClientCertificateThumbprint.DeserializeClusterClientCertificateThumbprint(item, options));
                            }
                            clientCertificateThumbprints = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterCodeVersion"u8))
                        {
                            clusterCodeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterState = new ServiceFabricClusterState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diagnosticsStorageAccountConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticsStorageAccountConfig = DiagnosticsStorageAccountConfig.DeserializeDiagnosticsStorageAccountConfig(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventStoreServiceEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventStoreServiceEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("fabricSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SettingsSectionDescription> array = new List<SettingsSectionDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SettingsSectionDescription.DeserializeSettingsSectionDescription(item, options));
                            }
                            fabricSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("managementEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterNodeTypeDescription> array = new List<ClusterNodeTypeDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterNodeTypeDescription.DeserializeClusterNodeTypeDescription(item, options));
                            }
                            nodeTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ServiceFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reliabilityLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reliabilityLevel = new ClusterReliabilityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reverseProxyCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseProxyCertificate = ClusterCertificateDescription.DeserializeClusterCertificateDescription(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("reverseProxyCertificateCommonNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseProxyCertificateCommonNames = ClusterServerCertificateCommonNames.DeserializeClusterServerCertificateCommonNames(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("upgradeDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeDescription = ClusterUpgradePolicy.DeserializeClusterUpgradePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("upgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeMode = new ClusterUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationTypeVersionsCleanupPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationTypeVersionsCleanupPolicy = ApplicationTypeVersionsCleanupPolicy.DeserializeApplicationTypeVersionsCleanupPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmImage"u8))
                        {
                            vmImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sfZonalUpgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sfZonalUpgradeMode = new SfZonalUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmssZonalUpgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmssZonalUpgradeMode = new VmssZonalUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("infrastructureServiceManager"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            infrastructureServiceManager = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("upgradeWave"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeWave = new ClusterUpgradeCadence(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgradePauseStartTimestampUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePauseStartTimestampUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("upgradePauseEndTimestampUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePauseEndTimestampUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("waveUpgradePaused"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            waveUpgradePaused = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterNotification> array = new List<ClusterNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterNotification.DeserializeClusterNotification(item, options));
                            }
                            notifications = array;
                            continue;
                        }
                        if (property0.NameEquals("enableHttpGatewayExclusiveAuthMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableHttpGatewayExclusiveAuthMode = property0.Value.GetBoolean();
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
            return new ServiceFabricClusterData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                addOnFeatures ?? new ChangeTrackingList<ClusterAddOnFeature>(),
                availableClusterVersions ?? new ChangeTrackingList<ClusterVersionDetails>(),
                azureActiveDirectory,
                certificate,
                certificateCommonNames,
                clientCertificateCommonNames ?? new ChangeTrackingList<ClusterClientCertificateCommonName>(),
                clientCertificateThumbprints ?? new ChangeTrackingList<ClusterClientCertificateThumbprint>(),
                clusterCodeVersion,
                clusterEndpoint,
                clusterId,
                clusterState,
                diagnosticsStorageAccountConfig,
                eventStoreServiceEnabled,
                fabricSettings ?? new ChangeTrackingList<SettingsSectionDescription>(),
                managementEndpoint,
                nodeTypes ?? new ChangeTrackingList<ClusterNodeTypeDescription>(),
                provisioningState,
                reliabilityLevel,
                reverseProxyCertificate,
                reverseProxyCertificateCommonNames,
                upgradeDescription,
                upgradeMode,
                applicationTypeVersionsCleanupPolicy,
                vmImage,
                sfZonalUpgradeMode,
                vmssZonalUpgradeMode,
                infrastructureServiceManager,
                upgradeWave,
                upgradePauseStartTimestampUtc,
                upgradePauseEndTimestampUtc,
                waveUpgradePaused,
                notifications ?? new ChangeTrackingList<ClusterNotification>(),
                enableHttpGatewayExclusiveAuthMode,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricClusterData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricClusterData)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceFabricClusterData IPersistableModel<ServiceFabricClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricClusterData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricClusterData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
