// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class FhirServiceResourceVersionPolicyConfiguration : IUtf8JsonSerializable, IJsonModel<FhirServiceResourceVersionPolicyConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirServiceResourceVersionPolicyConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirServiceResourceVersionPolicyConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteStringValue(Default.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceTypeOverrides))
            {
                writer.WritePropertyName("resourceTypeOverrides"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceTypeOverrides)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value.ToString());
                }
                writer.WriteEndObject();
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

        FhirServiceResourceVersionPolicyConfiguration IJsonModel<FhirServiceResourceVersionPolicyConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirServiceResourceVersionPolicyConfiguration(document.RootElement, options);
        }

        internal static FhirServiceResourceVersionPolicyConfiguration DeserializeFhirServiceResourceVersionPolicyConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirResourceVersionPolicy? @default = default;
            IDictionary<string, FhirResourceVersionPolicy> resourceTypeOverrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = new FhirResourceVersionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceTypeOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, FhirResourceVersionPolicy> dictionary = new Dictionary<string, FhirResourceVersionPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, new FhirResourceVersionPolicy(property0.Value.GetString()));
                    }
                    resourceTypeOverrides = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FhirServiceResourceVersionPolicyConfiguration(@default, resourceTypeOverrides ?? new ChangeTrackingDictionary<string, FhirResourceVersionPolicy>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        FhirServiceResourceVersionPolicyConfiguration IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirServiceResourceVersionPolicyConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirServiceResourceVersionPolicyConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirServiceResourceVersionPolicyConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
