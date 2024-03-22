// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkTapRulePatch : IUtf8JsonSerializable, IJsonModel<NetworkTapRulePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkTapRulePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkTapRulePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkTapRulePatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(ConfigurationType))
            {
                writer.WritePropertyName("configurationType"u8);
                writer.WriteStringValue(ConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(TapRulesUri))
            {
                writer.WritePropertyName("tapRulesUrl"u8);
                writer.WriteStringValue(TapRulesUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(MatchConfigurations))
            {
                writer.WritePropertyName("matchConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in MatchConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DynamicMatchConfigurations))
            {
                writer.WritePropertyName("dynamicMatchConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in DynamicMatchConfigurations)
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

        NetworkTapRulePatch IJsonModel<NetworkTapRulePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRulePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkTapRulePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkTapRulePatch(document.RootElement, options);
        }

        internal static NetworkTapRulePatch DeserializeNetworkTapRulePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string annotation = default;
            NetworkFabricConfigurationType? configurationType = default;
            Uri tapRulesUrl = default;
            IList<NetworkTapRuleMatchConfiguration> matchConfigurations = default;
            IList<CommonDynamicMatchConfiguration> dynamicMatchConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationType = new NetworkFabricConfigurationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tapRulesUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tapRulesUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("matchConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkTapRuleMatchConfiguration> array = new List<NetworkTapRuleMatchConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkTapRuleMatchConfiguration.DeserializeNetworkTapRuleMatchConfiguration(item, options));
                            }
                            matchConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dynamicMatchConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CommonDynamicMatchConfiguration> array = new List<CommonDynamicMatchConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CommonDynamicMatchConfiguration.DeserializeCommonDynamicMatchConfiguration(item, options));
                            }
                            dynamicMatchConfigurations = array;
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
            return new NetworkTapRulePatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                annotation,
                configurationType,
                tapRulesUrl,
                matchConfigurations ?? new ChangeTrackingList<NetworkTapRuleMatchConfiguration>(),
                dynamicMatchConfigurations ?? new ChangeTrackingList<CommonDynamicMatchConfiguration>());
        }

        BinaryData IPersistableModel<NetworkTapRulePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkTapRulePatch)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkTapRulePatch IPersistableModel<NetworkTapRulePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRulePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkTapRulePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkTapRulePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkTapRulePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
