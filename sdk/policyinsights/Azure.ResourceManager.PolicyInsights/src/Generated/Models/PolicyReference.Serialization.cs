// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyReference : IUtf8JsonSerializable, IJsonModel<PolicyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyReference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicySetDefinitionId))
            {
                writer.WritePropertyName("policySetDefinitionId"u8);
                writer.WriteStringValue(PolicySetDefinitionId);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyAssignmentId))
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
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

        PolicyReference IJsonModel<PolicyReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyReference(document.RootElement, options);
        }

        internal static PolicyReference DeserializePolicyReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier policyDefinitionId = default;
            ResourceIdentifier policySetDefinitionId = default;
            string policyDefinitionReferenceId = default;
            ResourceIdentifier policyAssignmentId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySetDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policySetDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyReference(policyDefinitionId, policySetDefinitionId, policyDefinitionReferenceId, policyAssignmentId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyReference)} does not support writing '{options.Format}' format.");
            }
        }

        PolicyReference IPersistableModel<PolicyReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
