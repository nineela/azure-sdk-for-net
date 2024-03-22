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
    public partial class FirewallPolicySnat : IUtf8JsonSerializable, IJsonModel<FirewallPolicySnat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicySnat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPolicySnat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicySnat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicySnat)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PrivateRanges))
            {
                writer.WritePropertyName("privateRanges"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AutoLearnPrivateRanges))
            {
                writer.WritePropertyName("autoLearnPrivateRanges"u8);
                writer.WriteStringValue(AutoLearnPrivateRanges.Value.ToString());
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

        FirewallPolicySnat IJsonModel<FirewallPolicySnat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicySnat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicySnat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicySnat(document.RootElement, options);
        }

        internal static FirewallPolicySnat DeserializeFirewallPolicySnat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> privateRanges = default;
            AutoLearnPrivateRangesMode? autoLearnPrivateRanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    privateRanges = array;
                    continue;
                }
                if (property.NameEquals("autoLearnPrivateRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoLearnPrivateRanges = new AutoLearnPrivateRangesMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallPolicySnat(privateRanges ?? new ChangeTrackingList<string>(), autoLearnPrivateRanges, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPolicySnat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicySnat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicySnat)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallPolicySnat IPersistableModel<FirewallPolicySnat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicySnat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicySnat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicySnat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicySnat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
