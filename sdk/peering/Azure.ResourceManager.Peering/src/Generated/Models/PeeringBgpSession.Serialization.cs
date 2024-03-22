// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class PeeringBgpSession : IUtf8JsonSerializable, IJsonModel<PeeringBgpSession>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringBgpSession>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeeringBgpSession>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringBgpSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringBgpSession)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionPrefixV4))
            {
                writer.WritePropertyName("sessionPrefixV4"u8);
                writer.WriteStringValue(SessionPrefixV4);
            }
            if (Optional.IsDefined(SessionPrefixV6))
            {
                writer.WritePropertyName("sessionPrefixV6"u8);
                writer.WriteStringValue(SessionPrefixV6);
            }
            if (Optional.IsDefined(MicrosoftSessionIPv4Address))
            {
                writer.WritePropertyName("microsoftSessionIPv4Address"u8);
                writer.WriteStringValue(MicrosoftSessionIPv4Address.ToString());
            }
            if (Optional.IsDefined(MicrosoftSessionIPv6Address))
            {
                writer.WritePropertyName("microsoftSessionIPv6Address"u8);
                writer.WriteStringValue(MicrosoftSessionIPv6Address.ToString());
            }
            if (Optional.IsDefined(PeerSessionIPv4Address))
            {
                writer.WritePropertyName("peerSessionIPv4Address"u8);
                writer.WriteStringValue(PeerSessionIPv4Address.ToString());
            }
            if (Optional.IsDefined(PeerSessionIPv6Address))
            {
                writer.WritePropertyName("peerSessionIPv6Address"u8);
                writer.WriteStringValue(PeerSessionIPv6Address.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SessionStateV4))
            {
                writer.WritePropertyName("sessionStateV4"u8);
                writer.WriteStringValue(SessionStateV4.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SessionStateV6))
            {
                writer.WritePropertyName("sessionStateV6"u8);
                writer.WriteStringValue(SessionStateV6.Value.ToString());
            }
            if (Optional.IsDefined(MaxPrefixesAdvertisedV4))
            {
                writer.WritePropertyName("maxPrefixesAdvertisedV4"u8);
                writer.WriteNumberValue(MaxPrefixesAdvertisedV4.Value);
            }
            if (Optional.IsDefined(MaxPrefixesAdvertisedV6))
            {
                writer.WritePropertyName("maxPrefixesAdvertisedV6"u8);
                writer.WriteNumberValue(MaxPrefixesAdvertisedV6.Value);
            }
            if (Optional.IsDefined(Md5AuthenticationKey))
            {
                writer.WritePropertyName("md5AuthenticationKey"u8);
                writer.WriteStringValue(Md5AuthenticationKey);
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

        PeeringBgpSession IJsonModel<PeeringBgpSession>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringBgpSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringBgpSession)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringBgpSession(document.RootElement, options);
        }

        internal static PeeringBgpSession DeserializePeeringBgpSession(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sessionPrefixV4 = default;
            string sessionPrefixV6 = default;
            IPAddress microsoftSessionIPv4Address = default;
            IPAddress microsoftSessionIPv6Address = default;
            IPAddress peerSessionIPv4Address = default;
            IPAddress peerSessionIPv6Address = default;
            PeeringSessionStateV4? sessionStateV4 = default;
            PeeringSessionStateV6? sessionStateV6 = default;
            int? maxPrefixesAdvertisedV4 = default;
            int? maxPrefixesAdvertisedV6 = default;
            string md5AuthenticationKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionPrefixV4"u8))
                {
                    sessionPrefixV4 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionPrefixV6"u8))
                {
                    sessionPrefixV6 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("microsoftSessionIPv4Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    microsoftSessionIPv4Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("microsoftSessionIPv6Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    microsoftSessionIPv6Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peerSessionIPv4Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    peerSessionIPv4Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peerSessionIPv6Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    peerSessionIPv6Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionStateV4"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionStateV4 = new PeeringSessionStateV4(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionStateV6"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionStateV6 = new PeeringSessionStateV6(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxPrefixesAdvertisedV4"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPrefixesAdvertisedV4 = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPrefixesAdvertisedV6"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPrefixesAdvertisedV6 = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("md5AuthenticationKey"u8))
                {
                    md5AuthenticationKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeeringBgpSession(
                sessionPrefixV4,
                sessionPrefixV6,
                microsoftSessionIPv4Address,
                microsoftSessionIPv6Address,
                peerSessionIPv4Address,
                peerSessionIPv6Address,
                sessionStateV4,
                sessionStateV6,
                maxPrefixesAdvertisedV4,
                maxPrefixesAdvertisedV6,
                md5AuthenticationKey,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringBgpSession>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringBgpSession>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeeringBgpSession)} does not support writing '{options.Format}' format.");
            }
        }

        PeeringBgpSession IPersistableModel<PeeringBgpSession>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringBgpSession>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeeringBgpSession(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringBgpSession)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringBgpSession>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
