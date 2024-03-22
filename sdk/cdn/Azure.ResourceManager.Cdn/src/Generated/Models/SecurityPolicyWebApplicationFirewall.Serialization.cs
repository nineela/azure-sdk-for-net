// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class SecurityPolicyWebApplicationFirewall : IUtf8JsonSerializable, IJsonModel<SecurityPolicyWebApplicationFirewall>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityPolicyWebApplicationFirewall>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityPolicyWebApplicationFirewall>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewall)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WafPolicy))
            {
                writer.WritePropertyName("wafPolicy"u8);
                JsonSerializer.Serialize(writer, WafPolicy);
            }
            if (Optional.IsCollectionDefined(Associations))
            {
                writer.WritePropertyName("associations"u8);
                writer.WriteStartArray();
                foreach (var item in Associations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
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

        SecurityPolicyWebApplicationFirewall IJsonModel<SecurityPolicyWebApplicationFirewall>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewall)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityPolicyWebApplicationFirewall(document.RootElement, options);
        }

        internal static SecurityPolicyWebApplicationFirewall DeserializeSecurityPolicyWebApplicationFirewall(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource wafPolicy = default;
            IList<SecurityPolicyWebApplicationFirewallAssociation> associations = default;
            SecurityPolicyType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wafPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wafPolicy = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("associations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityPolicyWebApplicationFirewallAssociation> array = new List<SecurityPolicyWebApplicationFirewallAssociation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityPolicyWebApplicationFirewallAssociation.DeserializeSecurityPolicyWebApplicationFirewallAssociation(item, options));
                    }
                    associations = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SecurityPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityPolicyWebApplicationFirewall(type, serializedAdditionalRawData, wafPolicy, associations ?? new ChangeTrackingList<SecurityPolicyWebApplicationFirewallAssociation>());
        }

        BinaryData IPersistableModel<SecurityPolicyWebApplicationFirewall>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewall)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityPolicyWebApplicationFirewall IPersistableModel<SecurityPolicyWebApplicationFirewall>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityPolicyWebApplicationFirewall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityPolicyWebApplicationFirewall(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityPolicyWebApplicationFirewall)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityPolicyWebApplicationFirewall>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
