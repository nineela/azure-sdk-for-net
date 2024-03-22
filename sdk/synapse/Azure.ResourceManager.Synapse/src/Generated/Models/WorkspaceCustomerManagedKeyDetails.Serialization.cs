// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class WorkspaceCustomerManagedKeyDetails : IUtf8JsonSerializable, IJsonModel<WorkspaceCustomerManagedKeyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkspaceCustomerManagedKeyDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkspaceCustomerManagedKeyDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceCustomerManagedKeyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceCustomerManagedKeyDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteObjectValue(Key);
            }
            if (Optional.IsDefined(KekIdentity))
            {
                writer.WritePropertyName("kekIdentity"u8);
                writer.WriteObjectValue(KekIdentity);
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

        WorkspaceCustomerManagedKeyDetails IJsonModel<WorkspaceCustomerManagedKeyDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceCustomerManagedKeyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkspaceCustomerManagedKeyDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkspaceCustomerManagedKeyDetails(document.RootElement, options);
        }

        internal static WorkspaceCustomerManagedKeyDetails DeserializeWorkspaceCustomerManagedKeyDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            SynapseWorkspaceKeyDetails key = default;
            KekIdentityProperties kekIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key = SynapseWorkspaceKeyDetails.DeserializeSynapseWorkspaceKeyDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kekIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekIdentity = KekIdentityProperties.DeserializeKekIdentityProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkspaceCustomerManagedKeyDetails(status, key, kekIdentity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkspaceCustomerManagedKeyDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceCustomerManagedKeyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkspaceCustomerManagedKeyDetails)} does not support writing '{options.Format}' format.");
            }
        }

        WorkspaceCustomerManagedKeyDetails IPersistableModel<WorkspaceCustomerManagedKeyDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkspaceCustomerManagedKeyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkspaceCustomerManagedKeyDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkspaceCustomerManagedKeyDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkspaceCustomerManagedKeyDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
