// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    public partial class BillingSubscriptionData : IUtf8JsonSerializable, IJsonModel<BillingSubscriptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingSubscriptionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteStringValue(AutoRenew.Value.ToString());
            }
            if (Optional.IsDefined(BeneficiaryTenantId))
            {
                writer.WritePropertyName("beneficiaryTenantId"u8);
                writer.WriteStringValue(BeneficiaryTenantId);
            }
            if (Optional.IsDefined(BillingFrequency))
            {
                writer.WritePropertyName("billingFrequency"u8);
                writer.WriteStringValue(BillingFrequency);
            }
            if (Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BillingPolicies))
            {
                writer.WritePropertyName("billingPolicies"u8);
                writer.WriteStartObject();
                foreach (var item in BillingPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileDisplayName))
            {
                writer.WritePropertyName("billingProfileDisplayName"u8);
                writer.WriteStringValue(BillingProfileDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileName))
            {
                writer.WritePropertyName("billingProfileName"u8);
                writer.WriteStringValue(BillingProfileName);
            }
            if (Optional.IsDefined(ConsumptionCostCenter))
            {
                writer.WritePropertyName("consumptionCostCenter"u8);
                writer.WriteStringValue(ConsumptionCostCenter);
            }
            if (Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomerDisplayName))
            {
                writer.WritePropertyName("customerDisplayName"u8);
                writer.WriteStringValue(CustomerDisplayName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(EnrollmentAccountId))
            {
                writer.WritePropertyName("enrollmentAccountId"u8);
                writer.WriteStringValue(EnrollmentAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(EnrollmentAccountDisplayName))
            {
                writer.WritePropertyName("enrollmentAccountDisplayName"u8);
                writer.WriteStringValue(EnrollmentAccountDisplayName);
            }
            if (Optional.IsDefined(InvoiceSectionId))
            {
                writer.WritePropertyName("invoiceSectionId"u8);
                writer.WriteStringValue(InvoiceSectionId);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionDisplayName))
            {
                writer.WritePropertyName("invoiceSectionDisplayName"u8);
                writer.WriteStringValue(InvoiceSectionDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionName))
            {
                writer.WritePropertyName("invoiceSectionName"u8);
                writer.WriteStringValue(InvoiceSectionName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastMonthCharges))
            {
                writer.WritePropertyName("lastMonthCharges"u8);
                writer.WriteObjectValue(LastMonthCharges);
            }
            if (options.Format != "W" && Optional.IsDefined(MonthToDateCharges))
            {
                writer.WritePropertyName("monthToDateCharges"u8);
                writer.WriteObjectValue(MonthToDateCharges);
            }
            if (options.Format != "W" && Optional.IsDefined(NextBillingCycleDetails))
            {
                writer.WritePropertyName("nextBillingCycleDetails"u8);
                writer.WriteObjectValue(NextBillingCycleDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductCategory))
            {
                writer.WritePropertyName("productCategory"u8);
                writer.WriteStringValue(ProductCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType);
            }
            if (Optional.IsDefined(ProductTypeId))
            {
                writer.WritePropertyName("productTypeId"u8);
                writer.WriteStringValue(ProductTypeId);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchaseOn))
            {
                writer.WritePropertyName("purchaseDate"u8);
                writer.WriteStringValue(PurchaseOn.Value, "O");
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Reseller))
            {
                writer.WritePropertyName("reseller"u8);
                writer.WriteObjectValue(Reseller);
            }
            if (options.Format != "W" && Optional.IsDefined(RenewalTermDetails))
            {
                writer.WritePropertyName("renewalTermDetails"u8);
                writer.WriteObjectValue(RenewalTermDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(SkuDescription))
            {
                writer.WritePropertyName("skuDescription"u8);
                writer.WriteStringValue(SkuDescription);
            }
            if (Optional.IsDefined(SkuId))
            {
                writer.WritePropertyName("skuId"u8);
                writer.WriteStringValue(SkuId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SuspensionReasons))
            {
                writer.WritePropertyName("suspensionReasons"u8);
                writer.WriteStartArray();
                foreach (var item in SuspensionReasons)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TermDuration))
            {
                writer.WritePropertyName("termDuration"u8);
                writer.WriteStringValue(TermDuration.Value, "P");
            }
            if (options.Format != "W" && Optional.IsDefined(TermStartOn))
            {
                writer.WritePropertyName("termStartDate"u8);
                writer.WriteStringValue(TermStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TermEndOn))
            {
                writer.WritePropertyName("termEndDate"u8);
                writer.WriteStringValue(TermEndOn.Value, "O");
            }
            writer.WritePropertyName("enrollmentAccountSubscriptionDetails"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SubscriptionEnrollmentAccountStatus))
            {
                writer.WritePropertyName("subscriptionEnrollmentAccountStatus"u8);
                writer.WriteStringValue(SubscriptionEnrollmentAccountStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EnrollmentAccountStartOn))
            {
                writer.WritePropertyName("enrollmentAccountStartDate"u8);
                writer.WriteStringValue(EnrollmentAccountStartOn.Value, "O");
            }
            writer.WriteEndObject();
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

        BillingSubscriptionData IJsonModel<BillingSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingSubscriptionData(document.RootElement, options);
        }

        internal static BillingSubscriptionData DeserializeBillingSubscriptionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            BillingSubscriptionAutoRenewState? autoRenew = default;
            string beneficiaryTenantId = default;
            string billingFrequency = default;
            ResourceIdentifier billingProfileId = default;
            IReadOnlyDictionary<string, string> billingPolicies = default;
            string billingProfileDisplayName = default;
            string billingProfileName = default;
            string consumptionCostCenter = default;
            string customerId = default;
            string customerDisplayName = default;
            string displayName = default;
            string enrollmentAccountId = default;
            string enrollmentAccountDisplayName = default;
            ResourceIdentifier invoiceSectionId = default;
            string invoiceSectionDisplayName = default;
            string invoiceSectionName = default;
            BillingAmount lastMonthCharges = default;
            BillingAmount monthToDateCharges = default;
            NextBillingCycleDetails nextBillingCycleDetails = default;
            string offerId = default;
            string productCategory = default;
            string productType = default;
            string productTypeId = default;
            DateTimeOffset? purchaseDate = default;
            long? quantity = default;
            CreatedSubscriptionReseller reseller = default;
            SubscriptionRenewalTermDetails renewalTermDetails = default;
            string skuDescription = default;
            string skuId = default;
            BillingSubscriptionStatus? status = default;
            string subscriptionId = default;
            IReadOnlyList<string> suspensionReasons = default;
            TimeSpan? termDuration = default;
            DateTimeOffset? termStartDate = default;
            DateTimeOffset? termEndDate = default;
            SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus = default;
            DateTimeOffset? enrollmentAccountStartDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("autoRenew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoRenew = new BillingSubscriptionAutoRenewState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("beneficiaryTenantId"u8))
                        {
                            beneficiaryTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"u8))
                        {
                            billingFrequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingProfileId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            billingPolicies = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("billingProfileDisplayName"u8))
                        {
                            billingProfileDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"u8))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumptionCostCenter"u8))
                        {
                            consumptionCostCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerId"u8))
                        {
                            customerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerDisplayName"u8))
                        {
                            customerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enrollmentAccountId"u8))
                        {
                            enrollmentAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enrollmentAccountDisplayName"u8))
                        {
                            enrollmentAccountDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            invoiceSectionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionDisplayName"u8))
                        {
                            invoiceSectionDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionName"u8))
                        {
                            invoiceSectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastMonthCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastMonthCharges = BillingAmount.DeserializeBillingAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("monthToDateCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monthToDateCharges = BillingAmount.DeserializeBillingAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("nextBillingCycleDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextBillingCycleDetails = NextBillingCycleDetails.DeserializeNextBillingCycleDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("offerId"u8))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productCategory"u8))
                        {
                            productCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            productType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productTypeId"u8))
                        {
                            productTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchaseDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchaseDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reseller = CreatedSubscriptionReseller.DeserializeCreatedSubscriptionReseller(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("renewalTermDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renewalTermDetails = SubscriptionRenewalTermDetails.DeserializeSubscriptionRenewalTermDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("skuDescription"u8))
                        {
                            skuDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("skuId"u8))
                        {
                            skuId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new BillingSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suspensionReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            suspensionReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("termDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("termStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("termEndDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("enrollmentAccountSubscriptionDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("subscriptionEnrollmentAccountStatus"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    subscriptionEnrollmentAccountStatus = new SubscriptionEnrollmentAccountStatus(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("enrollmentAccountStartDate"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    enrollmentAccountStartDate = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                            }
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
            return new BillingSubscriptionData(
                id,
                name,
                type,
                systemData,
                autoRenew,
                beneficiaryTenantId,
                billingFrequency,
                billingProfileId,
                billingPolicies ?? new ChangeTrackingDictionary<string, string>(),
                billingProfileDisplayName,
                billingProfileName,
                consumptionCostCenter,
                customerId,
                customerDisplayName,
                displayName,
                enrollmentAccountId,
                enrollmentAccountDisplayName,
                invoiceSectionId,
                invoiceSectionDisplayName,
                invoiceSectionName,
                lastMonthCharges,
                monthToDateCharges,
                nextBillingCycleDetails,
                offerId,
                productCategory,
                productType,
                productTypeId,
                purchaseDate,
                quantity,
                reseller,
                renewalTermDetails,
                skuDescription,
                skuId,
                status,
                subscriptionId,
                suspensionReasons ?? new ChangeTrackingList<string>(),
                termDuration,
                termStartDate,
                termEndDate,
                subscriptionEnrollmentAccountStatus,
                enrollmentAccountStartDate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingSubscriptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingSubscriptionData)} does not support writing '{options.Format}' format.");
            }
        }

        BillingSubscriptionData IPersistableModel<BillingSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingSubscriptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingSubscriptionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
