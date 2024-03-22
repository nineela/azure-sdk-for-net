// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownRecoveryVirtualNetworkCustomDetails))]
    public partial class RecoveryVirtualNetworkCustomDetails : IUtf8JsonSerializable, IJsonModel<RecoveryVirtualNetworkCustomDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryVirtualNetworkCustomDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryVirtualNetworkCustomDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryVirtualNetworkCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryVirtualNetworkCustomDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        RecoveryVirtualNetworkCustomDetails IJsonModel<RecoveryVirtualNetworkCustomDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryVirtualNetworkCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryVirtualNetworkCustomDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryVirtualNetworkCustomDetails(document.RootElement, options);
        }

        internal static RecoveryVirtualNetworkCustomDetails DeserializeRecoveryVirtualNetworkCustomDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryVirtualNetwork.DeserializeExistingRecoveryVirtualNetwork(element, options);
                    case "New": return NewRecoveryVirtualNetwork.DeserializeNewRecoveryVirtualNetwork(element, options);
                }
            }
            return UnknownRecoveryVirtualNetworkCustomDetails.DeserializeUnknownRecoveryVirtualNetworkCustomDetails(element, options);
        }

        BinaryData IPersistableModel<RecoveryVirtualNetworkCustomDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryVirtualNetworkCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryVirtualNetworkCustomDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryVirtualNetworkCustomDetails IPersistableModel<RecoveryVirtualNetworkCustomDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryVirtualNetworkCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryVirtualNetworkCustomDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryVirtualNetworkCustomDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryVirtualNetworkCustomDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
