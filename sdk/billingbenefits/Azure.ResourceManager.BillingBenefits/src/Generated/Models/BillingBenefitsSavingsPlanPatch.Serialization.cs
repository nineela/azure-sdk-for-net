// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsSavingsPlanPatch : IUtf8JsonSerializable, IJsonModel<BillingBenefitsSavingsPlanPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsSavingsPlanPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingBenefitsSavingsPlanPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
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

        BillingBenefitsSavingsPlanPatch IJsonModel<BillingBenefitsSavingsPlanPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanPatch(document.RootElement, options);
        }

        internal static BillingBenefitsSavingsPlanPatch DeserializeBillingBenefitsSavingsPlanPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsSavingsPlanPatchProperties properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BillingBenefitsSavingsPlanPatchProperties.DeserializeBillingBenefitsSavingsPlanPatchProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingBenefitsSavingsPlanPatch(properties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsSavingsPlanPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanPatch)} does not support writing '{options.Format}' format.");
            }
        }

        BillingBenefitsSavingsPlanPatch IPersistableModel<BillingBenefitsSavingsPlanPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsSavingsPlanPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsSavingsPlanPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
