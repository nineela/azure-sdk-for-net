// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteBuildData : IUtf8JsonSerializable, IJsonModel<StaticSiteBuildData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteBuildData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StaticSiteBuildData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (options.Format != "W" && Optional.IsDefined(BuildId))
            {
                writer.WritePropertyName("buildId"u8);
                writer.WriteStringValue(BuildId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceBranch))
            {
                writer.WritePropertyName("sourceBranch"u8);
                writer.WriteStringValue(SourceBranch);
            }
            if (options.Format != "W" && Optional.IsDefined(PullRequestTitle))
            {
                writer.WritePropertyName("pullRequestTitle"u8);
                writer.WriteStringValue(PullRequestTitle);
            }
            if (options.Format != "W" && Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTimeUtc"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedOn"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(UserProvidedFunctionApps))
            {
                writer.WritePropertyName("userProvidedFunctionApps"u8);
                writer.WriteStartArray();
                foreach (var item in UserProvidedFunctionApps)
                {
                    writer.WriteObjectValue(item);
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

        StaticSiteBuildData IJsonModel<StaticSiteBuildData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteBuildData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteBuildData(document.RootElement, options);
        }

        internal static StaticSiteBuildData DeserializeStaticSiteBuildData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string buildId = default;
            string sourceBranch = default;
            string pullRequestTitle = default;
            string hostname = default;
            DateTimeOffset? createdTimeUtc = default;
            DateTimeOffset? lastUpdatedOn = default;
            StaticSiteBuildStatus? status = default;
            IReadOnlyList<StaticSiteUserProvidedFunctionAppData> userProvidedFunctionApps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("buildId"u8))
                        {
                            buildId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceBranch"u8))
                        {
                            sourceBranch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pullRequestTitle"u8))
                        {
                            pullRequestTitle = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostname"u8))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new StaticSiteBuildStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userProvidedFunctionApps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StaticSiteUserProvidedFunctionAppData> array = new List<StaticSiteUserProvidedFunctionAppData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StaticSiteUserProvidedFunctionAppData.DeserializeStaticSiteUserProvidedFunctionAppData(item, options));
                            }
                            userProvidedFunctionApps = array;
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
            return new StaticSiteBuildData(
                id,
                name,
                type,
                systemData,
                buildId,
                sourceBranch,
                pullRequestTitle,
                hostname,
                createdTimeUtc,
                lastUpdatedOn,
                status,
                userProvidedFunctionApps ?? new ChangeTrackingList<StaticSiteUserProvidedFunctionAppData>(),
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StaticSiteBuildData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildData)} does not support writing '{options.Format}' format.");
            }
        }

        StaticSiteBuildData IPersistableModel<StaticSiteBuildData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteBuildData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticSiteBuildData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSiteBuildData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSiteBuildData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
