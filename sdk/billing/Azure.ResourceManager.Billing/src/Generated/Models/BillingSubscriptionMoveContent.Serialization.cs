// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingSubscriptionMoveContent : IUtf8JsonSerializable, IJsonModel<BillingSubscriptionMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingSubscriptionMoveContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingSubscriptionMoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DestinationEnrollmentAccountId))
            {
                writer.WritePropertyName("destinationEnrollmentAccountId"u8);
                writer.WriteStringValue(DestinationEnrollmentAccountId);
            }
            if (Optional.IsDefined(DestinationInvoiceSectionId))
            {
                writer.WritePropertyName("destinationInvoiceSectionId"u8);
                writer.WriteStringValue(DestinationInvoiceSectionId);
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

        BillingSubscriptionMoveContent IJsonModel<BillingSubscriptionMoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingSubscriptionMoveContent(document.RootElement, options);
        }

        internal static BillingSubscriptionMoveContent DeserializeBillingSubscriptionMoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string destinationEnrollmentAccountId = default;
            ResourceIdentifier destinationInvoiceSectionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationEnrollmentAccountId"u8))
                {
                    destinationEnrollmentAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationInvoiceSectionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationInvoiceSectionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingSubscriptionMoveContent(destinationEnrollmentAccountId, destinationInvoiceSectionId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingSubscriptionMoveContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support writing '{options.Format}' format.");
            }
        }

        BillingSubscriptionMoveContent IPersistableModel<BillingSubscriptionMoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingSubscriptionMoveContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingSubscriptionMoveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
