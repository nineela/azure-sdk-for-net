// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration : IUtf8JsonSerializable, IJsonModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Proxy))
            {
                writer.WritePropertyName("proxy"u8);
                writer.WriteStringValue(Proxy);
            }
            if (Optional.IsDefined(PrivateLinkScope))
            {
                writer.WritePropertyName("privateLinkScope"u8);
                writer.WriteStringValue(PrivateLinkScope);
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

        DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration IJsonModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration(document.RootElement, options);
        }

        internal static DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration DeserializeDefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string proxy = default;
            string privateLinkScope = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("proxy"u8))
                {
                    proxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkScope"u8))
                {
                    privateLinkScope = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration(proxy, privateLinkScope, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderFoDatabasesAwsOfferingArcAutoProvisioningConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
