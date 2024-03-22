// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    [PersistableModelProxy(typeof(UnknownAlertResourceIdentifier))]
    public partial class SecurityAlertResourceIdentifier : IUtf8JsonSerializable, IJsonModel<SecurityAlertResourceIdentifier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAlertResourceIdentifier>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityAlertResourceIdentifier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertResourceIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAlertResourceIdentifier)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceIdentifierType.ToString());
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

        SecurityAlertResourceIdentifier IJsonModel<SecurityAlertResourceIdentifier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertResourceIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAlertResourceIdentifier)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAlertResourceIdentifier(document.RootElement, options);
        }

        internal static SecurityAlertResourceIdentifier DeserializeSecurityAlertResourceIdentifier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureResource": return AzureResourceIdentifier.DeserializeAzureResourceIdentifier(element, options);
                    case "LogAnalytics": return LogAnalyticsIdentifier.DeserializeLogAnalyticsIdentifier(element, options);
                }
            }
            return UnknownAlertResourceIdentifier.DeserializeUnknownAlertResourceIdentifier(element, options);
        }

        BinaryData IPersistableModel<SecurityAlertResourceIdentifier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertResourceIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAlertResourceIdentifier)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAlertResourceIdentifier IPersistableModel<SecurityAlertResourceIdentifier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertResourceIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAlertResourceIdentifier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAlertResourceIdentifier)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAlertResourceIdentifier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
