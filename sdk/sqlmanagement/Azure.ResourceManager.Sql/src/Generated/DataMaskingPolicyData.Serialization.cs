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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class DataMaskingPolicyData : IUtf8JsonSerializable, IJsonModel<DataMaskingPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMaskingPolicyData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataMaskingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMaskingPolicyData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
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
            if (Optional.IsDefined(DataMaskingState))
            {
                writer.WritePropertyName("dataMaskingState"u8);
                writer.WriteStringValue(DataMaskingState.Value.ToSerialString());
            }
            if (Optional.IsDefined(ExemptPrincipals))
            {
                writer.WritePropertyName("exemptPrincipals"u8);
                writer.WriteStringValue(ExemptPrincipals);
            }
            if (options.Format != "W" && Optional.IsDefined(ApplicationPrincipals))
            {
                writer.WritePropertyName("applicationPrincipals"u8);
                writer.WriteStringValue(ApplicationPrincipals);
            }
            if (options.Format != "W" && Optional.IsDefined(MaskingLevel))
            {
                writer.WritePropertyName("maskingLevel"u8);
                writer.WriteStringValue(MaskingLevel);
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

        DataMaskingPolicyData IJsonModel<DataMaskingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMaskingPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMaskingPolicyData(document.RootElement, options);
        }

        internal static DataMaskingPolicyData DeserializeDataMaskingPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DataMaskingState? dataMaskingState = default;
            string exemptPrincipals = default;
            string applicationPrincipals = default;
            string maskingLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("dataMaskingState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataMaskingState = property0.Value.GetString().ToDataMaskingState();
                            continue;
                        }
                        if (property0.NameEquals("exemptPrincipals"u8))
                        {
                            exemptPrincipals = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationPrincipals"u8))
                        {
                            applicationPrincipals = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maskingLevel"u8))
                        {
                            maskingLevel = property0.Value.GetString();
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
            return new DataMaskingPolicyData(
                id,
                name,
                type,
                systemData,
                location,
                kind,
                dataMaskingState,
                exemptPrincipals,
                applicationPrincipals,
                maskingLevel,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataMaskingPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataMaskingPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        DataMaskingPolicyData IPersistableModel<DataMaskingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataMaskingPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMaskingPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMaskingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
