// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    [PersistableModelProxy(typeof(UnknownSapSizingRecommendationResult))]
    public partial class SapSizingRecommendationResult : IUtf8JsonSerializable, IJsonModel<SapSizingRecommendationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSizingRecommendationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapSizingRecommendationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
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

        SapSizingRecommendationResult IJsonModel<SapSizingRecommendationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSizingRecommendationResult(document.RootElement, options);
        }

        internal static SapSizingRecommendationResult DeserializeSapSizingRecommendationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("deploymentType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SingleServer": return SingleServerRecommendationResult.DeserializeSingleServerRecommendationResult(element, options);
                    case "ThreeTier": return ThreeTierRecommendationResult.DeserializeThreeTierRecommendationResult(element, options);
                }
            }
            return UnknownSapSizingRecommendationResult.DeserializeUnknownSapSizingRecommendationResult(element, options);
        }

        BinaryData IPersistableModel<SapSizingRecommendationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support writing '{options.Format}' format.");
            }
        }

        SapSizingRecommendationResult IPersistableModel<SapSizingRecommendationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapSizingRecommendationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapSizingRecommendationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
