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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class RequestReportRecordContract : IUtf8JsonSerializable, IJsonModel<RequestReportRecordContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestReportRecordContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequestReportRecordContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestReportRecordContract)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApiId))
            {
                writer.WritePropertyName("apiId"u8);
                writer.WriteStringValue(ApiId);
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductId))
            {
                writer.WritePropertyName("productId"u8);
                writer.WriteStringValue(ProductId);
            }
            if (options.Format != "W" && Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId"u8);
                writer.WriteStringValue(UserId);
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(Method.Value.ToString());
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(BackendResponseCode))
            {
                writer.WritePropertyName("backendResponseCode"u8);
                SerializeBackendResponseCodeValue(writer);
            }
            if (Optional.IsDefined(ResponseCode))
            {
                writer.WritePropertyName("responseCode"u8);
                writer.WriteNumberValue(ResponseCode.Value);
            }
            if (Optional.IsDefined(ResponseSize))
            {
                writer.WritePropertyName("responseSize"u8);
                writer.WriteNumberValue(ResponseSize.Value);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(Cache))
            {
                writer.WritePropertyName("cache"u8);
                writer.WriteStringValue(Cache);
            }
            if (Optional.IsDefined(ApiTime))
            {
                writer.WritePropertyName("apiTime"u8);
                writer.WriteNumberValue(ApiTime.Value);
            }
            if (Optional.IsDefined(ServiceTime))
            {
                writer.WritePropertyName("serviceTime"u8);
                writer.WriteNumberValue(ServiceTime.Value);
            }
            if (Optional.IsDefined(ApiRegion))
            {
                writer.WritePropertyName("apiRegion"u8);
                writer.WriteStringValue(ApiRegion);
            }
            if (Optional.IsDefined(SubscriptionResourceId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionResourceId);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(RequestSize))
            {
                writer.WritePropertyName("requestSize"u8);
                writer.WriteNumberValue(RequestSize.Value);
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

        RequestReportRecordContract IJsonModel<RequestReportRecordContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestReportRecordContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestReportRecordContract(document.RootElement, options);
        }

        internal static RequestReportRecordContract DeserializeRequestReportRecordContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string apiId = default;
            string operationId = default;
            string productId = default;
            string userId = default;
            RequestMethod? method = default;
            Uri uri = default;
            IPAddress ipAddress = default;
            string backendResponseCode = default;
            int? responseCode = default;
            int? responseSize = default;
            DateTimeOffset? timestamp = default;
            string cache = default;
            double? apiTime = default;
            double? serviceTime = default;
            string apiRegion = default;
            ResourceIdentifier subscriptionId = default;
            string requestId = default;
            int? requestSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiId"u8))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new RequestMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backendResponseCode"u8))
                {
                    DeserializeBackendResponseCodeValue(property, ref backendResponseCode);
                    continue;
                }
                if (property.NameEquals("responseCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("responseSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cache"u8))
                {
                    cache = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiTime = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("serviceTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTime = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("apiRegion"u8))
                {
                    apiRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestSize = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestReportRecordContract(
                apiId,
                operationId,
                productId,
                userId,
                method,
                uri,
                ipAddress,
                backendResponseCode,
                responseCode,
                responseSize,
                timestamp,
                cache,
                apiTime,
                serviceTime,
                apiRegion,
                subscriptionId,
                requestId,
                requestSize,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequestReportRecordContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequestReportRecordContract)} does not support writing '{options.Format}' format.");
            }
        }

        RequestReportRecordContract IPersistableModel<RequestReportRecordContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequestReportRecordContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequestReportRecordContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestReportRecordContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
