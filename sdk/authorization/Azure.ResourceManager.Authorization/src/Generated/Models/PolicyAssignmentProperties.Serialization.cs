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

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class PolicyAssignmentProperties : IUtf8JsonSerializable, IJsonModel<PolicyAssignmentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyAssignmentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyAssignmentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentProperties)} does not support writing '{format}' format.");
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
            writer.WritePropertyName("policy"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteObjectValue(LastModifiedBy);
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            writer.WriteEndObject();
            writer.WritePropertyName("roleDefinition"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(RoleDefinitionDisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(RoleDefinitionDisplayName);
            }
            if (Optional.IsDefined(RoleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoleType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("scope"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ScopeId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(ScopeId);
            }
            if (Optional.IsDefined(ScopeDisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(ScopeDisplayName);
            }
            if (Optional.IsDefined(ScopeType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ScopeType.Value.ToString());
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

        PolicyAssignmentProperties IJsonModel<PolicyAssignmentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyAssignmentProperties(document.RootElement, options);
        }

        internal static PolicyAssignmentProperties DeserializePolicyAssignmentProperties(JsonElement element, ModelReaderWriterOptions options = null)
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
            ResourceIdentifier id0 = default;
            RoleManagementPrincipal lastModifiedBy = default;
            DateTimeOffset? lastModifiedDateTime = default;
            ResourceIdentifier id1 = default;
            string displayName = default;
            AuthorizationRoleType? type0 = default;
            ResourceIdentifier id2 = default;
            string displayName0 = default;
            RoleManagementScopeType? type1 = default;
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
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id0 = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedBy = RoleManagementPrincipal.DeserializeRoleManagementPrincipal(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("roleDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id1 = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new AuthorizationRoleType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id2 = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type1 = new RoleManagementScopeType(property0.Value.GetString());
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
            return new PolicyAssignmentProperties(
                id,
                name,
                type,
                systemData,
                id0,
                lastModifiedBy,
                lastModifiedDateTime,
                id1,
                displayName,
                type0,
                id2,
                displayName0,
                type1,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyAssignmentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PolicyAssignmentProperties IPersistableModel<PolicyAssignmentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyAssignmentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyAssignmentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
