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
    public partial class DscpQosDefinition : IUtf8JsonSerializable, IJsonModel<DscpQosDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscpQosDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscpQosDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscpQosDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Markings))
            {
                writer.WritePropertyName("markings"u8);
                writer.WriteStartArray();
                foreach (var item in Markings)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceIPRanges))
            {
                writer.WritePropertyName("sourceIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourceIPRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationIPRanges))
            {
                writer.WritePropertyName("destinationIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationIPRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourcePortRanges))
            {
                writer.WritePropertyName("sourcePortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPortRanges))
            {
                writer.WritePropertyName("destinationPortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPortRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
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

        DscpQosDefinition IJsonModel<DscpQosDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscpQosDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscpQosDefinition(document.RootElement, options);
        }

        internal static DscpQosDefinition DeserializeDscpQosDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<int> markings = default;
            IList<QosIPRange> sourceIPRanges = default;
            IList<QosIPRange> destinationIPRanges = default;
            IList<QosPortRange> sourcePortRanges = default;
            IList<QosPortRange> destinationPortRanges = default;
            ProtocolType? protocol = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("markings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    markings = array;
                    continue;
                }
                if (property.NameEquals("sourceIpRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosIPRange> array = new List<QosIPRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosIPRange.DeserializeQosIPRange(item, options));
                    }
                    sourceIPRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationIpRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosIPRange> array = new List<QosIPRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosIPRange.DeserializeQosIPRange(item, options));
                    }
                    destinationIPRanges = array;
                    continue;
                }
                if (property.NameEquals("sourcePortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosPortRange> array = new List<QosPortRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosPortRange.DeserializeQosPortRange(item, options));
                    }
                    sourcePortRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationPortRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QosPortRange> array = new List<QosPortRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QosPortRange.DeserializeQosPortRange(item, options));
                    }
                    destinationPortRanges = array;
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new ProtocolType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscpQosDefinition(
                markings ?? new ChangeTrackingList<int>(),
                sourceIPRanges ?? new ChangeTrackingList<QosIPRange>(),
                destinationIPRanges ?? new ChangeTrackingList<QosIPRange>(),
                sourcePortRanges ?? new ChangeTrackingList<QosPortRange>(),
                destinationPortRanges ?? new ChangeTrackingList<QosPortRange>(),
                protocol,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscpQosDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscpQosDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        DscpQosDefinition IPersistableModel<DscpQosDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscpQosDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscpQosDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscpQosDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscpQosDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
