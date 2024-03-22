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
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    public partial class JobDefinitionData : IUtf8JsonSerializable, IJsonModel<JobDefinitionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobDefinitionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobDefinitionData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("copyMode"u8);
            writer.WriteStringValue(CopyMode.ToString());
            writer.WritePropertyName("sourceName"u8);
            writer.WriteStringValue(SourceName);
            if (options.Format != "W" && Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(SourceSubpath))
            {
                writer.WritePropertyName("sourceSubpath"u8);
                writer.WriteStringValue(SourceSubpath);
            }
            writer.WritePropertyName("targetName"u8);
            writer.WriteStringValue(TargetName);
            if (options.Format != "W" && Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(TargetSubpath))
            {
                writer.WritePropertyName("targetSubpath"u8);
                writer.WriteStringValue(TargetSubpath);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestJobRunName))
            {
                writer.WritePropertyName("latestJobRunName"u8);
                writer.WriteStringValue(LatestJobRunName);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestJobRunResourceId))
            {
                writer.WritePropertyName("latestJobRunResourceId"u8);
                writer.WriteStringValue(LatestJobRunResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(LatestJobRunStatus))
            {
                writer.WritePropertyName("latestJobRunStatus"u8);
                writer.WriteStringValue(LatestJobRunStatus.Value.ToString());
            }
            if (Optional.IsDefined(AgentName))
            {
                writer.WritePropertyName("agentName"u8);
                writer.WriteStringValue(AgentName);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentResourceId))
            {
                writer.WritePropertyName("agentResourceId"u8);
                writer.WriteStringValue(AgentResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        JobDefinitionData IJsonModel<JobDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobDefinitionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobDefinitionData(document.RootElement, options);
        }

        internal static JobDefinitionData DeserializeJobDefinitionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            StorageMoverCopyMode copyMode = default;
            string sourceName = default;
            ResourceIdentifier sourceResourceId = default;
            string sourceSubpath = default;
            string targetName = default;
            ResourceIdentifier targetResourceId = default;
            string targetSubpath = default;
            string latestJobRunName = default;
            ResourceIdentifier latestJobRunResourceId = default;
            JobRunStatus? latestJobRunStatus = default;
            string agentName = default;
            ResourceIdentifier agentResourceId = default;
            StorageMoverProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("copyMode"u8))
                        {
                            copyMode = new StorageMoverCopyMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceName"u8))
                        {
                            sourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceSubpath"u8))
                        {
                            sourceSubpath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetName"u8))
                        {
                            targetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetSubpath"u8))
                        {
                            targetSubpath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestJobRunName"u8))
                        {
                            latestJobRunName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latestJobRunResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            latestJobRunResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("latestJobRunStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            latestJobRunStatus = new JobRunStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentName"u8))
                        {
                            agentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageMoverProvisioningState(property0.Value.GetString());
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
            return new JobDefinitionData(
                id,
                name,
                type,
                systemData,
                description,
                copyMode,
                sourceName,
                sourceResourceId,
                sourceSubpath,
                targetName,
                targetResourceId,
                targetSubpath,
                latestJobRunName,
                latestJobRunResourceId,
                latestJobRunStatus,
                agentName,
                agentResourceId,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JobDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JobDefinitionData)} does not support writing '{options.Format}' format.");
            }
        }

        JobDefinitionData IPersistableModel<JobDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobDefinitionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobDefinitionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
