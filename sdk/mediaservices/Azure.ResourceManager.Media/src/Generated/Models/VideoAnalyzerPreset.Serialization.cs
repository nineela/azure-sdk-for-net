// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class VideoAnalyzerPreset : IUtf8JsonSerializable, IJsonModel<VideoAnalyzerPreset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VideoAnalyzerPreset>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VideoAnalyzerPreset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoAnalyzerPreset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VideoAnalyzerPreset)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InsightsToExtract))
            {
                writer.WritePropertyName("insightsToExtract"u8);
                writer.WriteStringValue(InsightsToExtract.Value.ToString());
            }
            if (Optional.IsDefined(AudioLanguage))
            {
                writer.WritePropertyName("audioLanguage"u8);
                writer.WriteStringValue(AudioLanguage);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExperimentalOptions))
            {
                writer.WritePropertyName("experimentalOptions"u8);
                writer.WriteStartObject();
                foreach (var item in ExperimentalOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        VideoAnalyzerPreset IJsonModel<VideoAnalyzerPreset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoAnalyzerPreset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VideoAnalyzerPreset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVideoAnalyzerPreset(document.RootElement, options);
        }

        internal static VideoAnalyzerPreset DeserializeVideoAnalyzerPreset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InsightsType? insightsToExtract = default;
            string audioLanguage = default;
            AudioAnalysisMode? mode = default;
            IDictionary<string, string> experimentalOptions = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("insightsToExtract"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    insightsToExtract = new InsightsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("audioLanguage"u8))
                {
                    audioLanguage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new AudioAnalysisMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("experimentalOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    experimentalOptions = dictionary;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VideoAnalyzerPreset(
                odataType,
                serializedAdditionalRawData,
                audioLanguage,
                mode,
                experimentalOptions ?? new ChangeTrackingDictionary<string, string>(),
                insightsToExtract);
        }

        BinaryData IPersistableModel<VideoAnalyzerPreset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoAnalyzerPreset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VideoAnalyzerPreset)} does not support writing '{options.Format}' format.");
            }
        }

        VideoAnalyzerPreset IPersistableModel<VideoAnalyzerPreset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoAnalyzerPreset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVideoAnalyzerPreset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VideoAnalyzerPreset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VideoAnalyzerPreset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
