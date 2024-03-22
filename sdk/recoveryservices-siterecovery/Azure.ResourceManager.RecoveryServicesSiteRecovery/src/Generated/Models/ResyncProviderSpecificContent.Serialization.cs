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
    [PersistableModelProxy(typeof(UnknownResyncProviderSpecificContent))]
    public partial class ResyncProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<ResyncProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResyncProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResyncProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResyncProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResyncProviderSpecificContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ResyncProviderSpecificContent IJsonModel<ResyncProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResyncProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResyncProviderSpecificContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResyncProviderSpecificContent(document.RootElement, options);
        }

        internal static ResyncProviderSpecificContent DeserializeResyncProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "VMwareCbt": return VMwareCbtResyncContent.DeserializeVMwareCbtResyncContent(element, options);
                }
            }
            return UnknownResyncProviderSpecificContent.DeserializeUnknownResyncProviderSpecificContent(element, options);
        }

        BinaryData IPersistableModel<ResyncProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResyncProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResyncProviderSpecificContent)} does not support writing '{options.Format}' format.");
            }
        }

        ResyncProviderSpecificContent IPersistableModel<ResyncProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResyncProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResyncProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResyncProviderSpecificContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResyncProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
