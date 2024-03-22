// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCustomImageVhd : IUtf8JsonSerializable, IJsonModel<DevTestLabCustomImageVhd>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabCustomImageVhd>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabCustomImageVhd>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVhd>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageVhd)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName"u8);
                writer.WriteStringValue(ImageName);
            }
            if (Optional.IsDefined(IsSysPrepEnabled))
            {
                writer.WritePropertyName("sysPrep"u8);
                writer.WriteBooleanValue(IsSysPrepEnabled.Value);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
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

        DevTestLabCustomImageVhd IJsonModel<DevTestLabCustomImageVhd>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVhd>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageVhd)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCustomImageVhd(document.RootElement, options);
        }

        internal static DevTestLabCustomImageVhd DeserializeDevTestLabCustomImageVhd(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string imageName = default;
            bool? sysPrep = default;
            DevTestLabCustomImageOSType osType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sysPrep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sysPrep = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new DevTestLabCustomImageOSType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabCustomImageVhd(imageName, sysPrep, osType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabCustomImageVhd>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVhd>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageVhd)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabCustomImageVhd IPersistableModel<DevTestLabCustomImageVhd>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageVhd>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabCustomImageVhd(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageVhd)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabCustomImageVhd>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
