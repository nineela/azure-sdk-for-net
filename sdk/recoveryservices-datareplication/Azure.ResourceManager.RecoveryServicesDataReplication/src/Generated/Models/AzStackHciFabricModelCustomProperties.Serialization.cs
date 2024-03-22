// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class AzStackHciFabricModelCustomProperties : IUtf8JsonSerializable, IJsonModel<AzStackHciFabricModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzStackHciFabricModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzStackHciFabricModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzStackHciFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzStackHciFabricModelCustomProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("azStackHciSiteId"u8);
            writer.WriteStringValue(AzStackHciSiteId);
            if (options.Format != "W" && Optional.IsCollectionDefined(ApplianceName))
            {
                writer.WritePropertyName("applianceName"u8);
                writer.WriteStartArray();
                foreach (var item in ApplianceName)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("cluster"u8);
            writer.WriteObjectValue(Cluster);
            if (options.Format != "W" && Optional.IsDefined(FabricResourceId))
            {
                writer.WritePropertyName("fabricResourceId"u8);
                writer.WriteStringValue(FabricResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricContainerId))
            {
                writer.WritePropertyName("fabricContainerId"u8);
                writer.WriteStringValue(FabricContainerId);
            }
            writer.WritePropertyName("migrationSolutionId"u8);
            writer.WriteStringValue(MigrationSolutionId);
            if (options.Format != "W" && Optional.IsDefined(MigrationHubUri))
            {
                writer.WritePropertyName("migrationHubUri"u8);
                writer.WriteStringValue(MigrationHubUri.AbsoluteUri);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        AzStackHciFabricModelCustomProperties IJsonModel<AzStackHciFabricModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzStackHciFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzStackHciFabricModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzStackHciFabricModelCustomProperties(document.RootElement, options);
        }

        internal static AzStackHciFabricModelCustomProperties DeserializeAzStackHciFabricModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier azStackHciSiteId = default;
            IReadOnlyList<string> applianceName = default;
            AzStackHciClusterProperties cluster = default;
            ResourceIdentifier fabricResourceId = default;
            string fabricContainerId = default;
            ResourceIdentifier migrationSolutionId = default;
            Uri migrationHubUri = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azStackHciSiteId"u8))
                {
                    azStackHciSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applianceName"u8))
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
                    applianceName = array;
                    continue;
                }
                if (property.NameEquals("cluster"u8))
                {
                    cluster = AzStackHciClusterProperties.DeserializeAzStackHciClusterProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fabricResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricContainerId"u8))
                {
                    fabricContainerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationHubUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationHubUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzStackHciFabricModelCustomProperties(
                instanceType,
                serializedAdditionalRawData,
                azStackHciSiteId,
                applianceName ?? new ChangeTrackingList<string>(),
                cluster,
                fabricResourceId,
                fabricContainerId,
                migrationSolutionId,
                migrationHubUri);
        }

        BinaryData IPersistableModel<AzStackHciFabricModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzStackHciFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzStackHciFabricModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AzStackHciFabricModelCustomProperties IPersistableModel<AzStackHciFabricModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzStackHciFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzStackHciFabricModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzStackHciFabricModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzStackHciFabricModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
