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
    public partial class BillingPlanInformation : IUtf8JsonSerializable, IJsonModel<BillingPlanInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingPlanInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingPlanInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingPlanInformation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PricingCurrencyTotal))
            {
                writer.WritePropertyName("pricingCurrencyTotal"u8);
                writer.WriteObjectValue(PricingCurrencyTotal);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "D");
            }
            if (Optional.IsDefined(NextPaymentDueOn))
            {
                writer.WritePropertyName("nextPaymentDueDate"u8);
                writer.WriteStringValue(NextPaymentDueOn.Value, "D");
            }
            if (Optional.IsCollectionDefined(Transactions))
            {
                writer.WritePropertyName("transactions"u8);
                writer.WriteStartArray();
                foreach (var item in Transactions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BillingPlanInformation IJsonModel<BillingPlanInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingPlanInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingPlanInformation(document.RootElement, options);
        }

        internal static BillingPlanInformation DeserializeBillingPlanInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsPrice pricingCurrencyTotal = default;
            DateTimeOffset? startDate = default;
            DateTimeOffset? nextPaymentDueDate = default;
            IList<SavingsPlanOrderPaymentDetail> transactions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = BillingBenefitsPrice.DeserializeBillingBenefitsPrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("nextPaymentDueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextPaymentDueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("transactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanOrderPaymentDetail> array = new List<SavingsPlanOrderPaymentDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanOrderPaymentDetail.DeserializeSavingsPlanOrderPaymentDetail(item, options));
                    }
                    transactions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingPlanInformation(pricingCurrencyTotal, startDate, nextPaymentDueDate, transactions ?? new ChangeTrackingList<SavingsPlanOrderPaymentDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingPlanInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingPlanInformation)} does not support writing '{options.Format}' format.");
            }
        }

        BillingPlanInformation IPersistableModel<BillingPlanInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingPlanInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingPlanInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingPlanInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
