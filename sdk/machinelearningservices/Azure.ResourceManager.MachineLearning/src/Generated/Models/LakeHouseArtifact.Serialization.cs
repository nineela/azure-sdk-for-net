// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class LakeHouseArtifact : IUtf8JsonSerializable, IJsonModel<LakeHouseArtifact>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LakeHouseArtifact>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LakeHouseArtifact>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LakeHouseArtifact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LakeHouseArtifact)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactName"u8);
            writer.WriteStringValue(ArtifactName);
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
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

        LakeHouseArtifact IJsonModel<LakeHouseArtifact>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LakeHouseArtifact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LakeHouseArtifact)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLakeHouseArtifact(document.RootElement, options);
        }

        internal static LakeHouseArtifact DeserializeLakeHouseArtifact(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string artifactName = default;
            OneLakeArtifactType artifactType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactName"u8))
                {
                    artifactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new OneLakeArtifactType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LakeHouseArtifact(artifactName, artifactType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LakeHouseArtifact>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LakeHouseArtifact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LakeHouseArtifact)} does not support writing '{options.Format}' format.");
            }
        }

        LakeHouseArtifact IPersistableModel<LakeHouseArtifact>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LakeHouseArtifact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLakeHouseArtifact(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LakeHouseArtifact)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LakeHouseArtifact>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
