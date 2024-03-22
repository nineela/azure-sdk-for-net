// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRewriteRule : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayRewriteRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayRewriteRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayRewriteRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(RuleSequence))
            {
                writer.WritePropertyName("ruleSequence"u8);
                writer.WriteNumberValue(RuleSequence.Value);
            }
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ActionSet))
            {
                writer.WritePropertyName("actionSet"u8);
                writer.WriteObjectValue(ActionSet);
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

        ApplicationGatewayRewriteRule IJsonModel<ApplicationGatewayRewriteRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRewriteRule(document.RootElement, options);
        }

        internal static ApplicationGatewayRewriteRule DeserializeApplicationGatewayRewriteRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? ruleSequence = default;
            IList<ApplicationGatewayRewriteRuleCondition> conditions = default;
            ApplicationGatewayRewriteRuleActionSet actionSet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSequence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ruleSequence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayRewriteRuleCondition> array = new List<ApplicationGatewayRewriteRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayRewriteRuleCondition.DeserializeApplicationGatewayRewriteRuleCondition(item, options));
                    }
                    conditions = array;
                    continue;
                }
                if (property.NameEquals("actionSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionSet = ApplicationGatewayRewriteRuleActionSet.DeserializeApplicationGatewayRewriteRuleActionSet(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayRewriteRule(name, ruleSequence, conditions ?? new ChangeTrackingList<ApplicationGatewayRewriteRuleCondition>(), actionSet, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayRewriteRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRule)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayRewriteRule IPersistableModel<ApplicationGatewayRewriteRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayRewriteRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayRewriteRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayRewriteRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayRewriteRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
