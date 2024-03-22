// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class ServiceProblemClassificationResult : IUtf8JsonSerializable, IJsonModel<ServiceProblemClassificationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceProblemClassificationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceProblemClassificationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceProblemClassificationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceProblemClassificationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProblemId))
            {
                writer.WritePropertyName("problemId"u8);
                writer.WriteStringValue(ProblemId);
            }
            if (options.Format != "W" && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceId))
            {
                writer.WritePropertyName("serviceId"u8);
                writer.WriteStringValue(ServiceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProblemClassificationId))
            {
                writer.WritePropertyName("problemClassificationId"u8);
                writer.WriteStringValue(ProblemClassificationId);
            }
            writer.WritePropertyName("relatedService"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RelatedServiceId))
            {
                writer.WritePropertyName("serviceId"u8);
                writer.WriteStringValue(RelatedServiceId);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        ServiceProblemClassificationResult IJsonModel<ServiceProblemClassificationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceProblemClassificationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceProblemClassificationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceProblemClassificationResult(document.RootElement, options);
        }

        internal static ServiceProblemClassificationResult DeserializeServiceProblemClassificationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string problemId = default;
            string title = default;
            string description = default;
            ResourceIdentifier serviceId = default;
            string problemClassificationId = default;
            ResourceIdentifier serviceId0 = default;
            string displayName = default;
            IReadOnlyList<ResourceType> resourceTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("problemId"u8))
                {
                    problemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    serviceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("problemClassificationId"u8))
                {
                    problemClassificationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relatedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            serviceId0 = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceType> array = new List<ResourceType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ResourceType(item.GetString()));
                            }
                            resourceTypes = array;
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
            return new ServiceProblemClassificationResult(
                problemId,
                title,
                description,
                serviceId,
                problemClassificationId,
                serviceId0,
                displayName,
                resourceTypes ?? new ChangeTrackingList<ResourceType>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceProblemClassificationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceProblemClassificationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceProblemClassificationResult)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceProblemClassificationResult IPersistableModel<ServiceProblemClassificationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceProblemClassificationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceProblemClassificationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceProblemClassificationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceProblemClassificationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
