// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class OrcWriteSettings : IUtf8JsonSerializable, IJsonModel<OrcWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrcWriteSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OrcWriteSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrcWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrcWriteSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxRowsPerFile))
            {
                writer.WritePropertyName("maxRowsPerFile"u8);
                JsonSerializer.Serialize(writer, MaxRowsPerFile);
            }
            if (Optional.IsDefined(FileNamePrefix))
            {
                writer.WritePropertyName("fileNamePrefix"u8);
                JsonSerializer.Serialize(writer, FileNamePrefix);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatWriteSettingsType);
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        OrcWriteSettings IJsonModel<OrcWriteSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrcWriteSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrcWriteSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrcWriteSettings(document.RootElement, options);
        }

        internal static OrcWriteSettings DeserializeOrcWriteSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<int> maxRowsPerFile = default;
            DataFactoryElement<string> fileNamePrefix = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRowsPerFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRowsPerFile = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileNamePrefix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileNamePrefix = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new OrcWriteSettings(type, additionalProperties, maxRowsPerFile, fileNamePrefix);
        }

        BinaryData IPersistableModel<OrcWriteSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrcWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrcWriteSettings)} does not support writing '{options.Format}' format.");
            }
        }

        OrcWriteSettings IPersistableModel<OrcWriteSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrcWriteSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrcWriteSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrcWriteSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrcWriteSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
