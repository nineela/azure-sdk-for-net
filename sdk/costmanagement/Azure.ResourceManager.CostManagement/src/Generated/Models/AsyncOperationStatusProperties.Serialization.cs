// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class AsyncOperationStatusProperties : IUtf8JsonSerializable, IJsonModel<AsyncOperationStatusProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AsyncOperationStatusProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AsyncOperationStatusProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsyncOperationStatusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AsyncOperationStatusProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReportUri))
            {
                writer.WritePropertyName("reportUrl"u8);
                writer.WriteStringValue(ReportUri.Value.ToString());
            }
            if (Optional.IsDefined(SecondaryReportUri))
            {
                writer.WritePropertyName("secondaryReportUrl"u8);
                writer.WriteStringValue(SecondaryReportUri.Value.ToString());
            }
            if (Optional.IsDefined(ValidUntil))
            {
                writer.WritePropertyName("validUntil"u8);
                writer.WriteStringValue(ValidUntil.Value, "O");
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

        AsyncOperationStatusProperties IJsonModel<AsyncOperationStatusProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsyncOperationStatusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AsyncOperationStatusProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAsyncOperationStatusProperties(document.RootElement, options);
        }

        internal static AsyncOperationStatusProperties DeserializeAsyncOperationStatusProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BenefitUtilizationSummaryReportSchema? reportUrl = default;
            BenefitUtilizationSummaryReportSchema? secondaryReportUrl = default;
            DateTimeOffset? validUntil = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reportUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportUrl = new BenefitUtilizationSummaryReportSchema(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryReportUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryReportUrl = new BenefitUtilizationSummaryReportSchema(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validUntil"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AsyncOperationStatusProperties(reportUrl, secondaryReportUrl, validUntil, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AsyncOperationStatusProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsyncOperationStatusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AsyncOperationStatusProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AsyncOperationStatusProperties IPersistableModel<AsyncOperationStatusProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsyncOperationStatusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAsyncOperationStatusProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AsyncOperationStatusProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AsyncOperationStatusProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
