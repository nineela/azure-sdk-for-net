// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmExtension : IUtf8JsonSerializable, IJsonModel<BatchVmExtension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchVmExtension>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchVmExtension>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmExtension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchVmExtension)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("publisher"u8);
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ExtensionType);
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(AutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(EnableAutomaticUpgrade))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                using (JsonDocument document = JsonDocument.Parse(Settings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ProtectedSettings))
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectedSettings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(ProvisionAfterExtensions))
            {
                writer.WritePropertyName("provisionAfterExtensions"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisionAfterExtensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        BatchVmExtension IJsonModel<BatchVmExtension>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmExtension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchVmExtension)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmExtension(document.RootElement, options);
        }

        internal static BatchVmExtension DeserializeBatchVmExtension(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string publisher = default;
            string type = default;
            string typeHandlerVersion = default;
            bool? autoUpgradeMinorVersion = default;
            bool? enableAutomaticUpgrade = default;
            BinaryData settings = default;
            BinaryData protectedSettings = default;
            IList<string> provisionAfterExtensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoUpgradeMinorVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpgradeMinorVersion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("protectedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedSettings = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("provisionAfterExtensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    provisionAfterExtensions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchVmExtension(
                name,
                publisher,
                type,
                typeHandlerVersion,
                autoUpgradeMinorVersion,
                enableAutomaticUpgrade,
                settings,
                protectedSettings,
                provisionAfterExtensions ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchVmExtension>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmExtension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchVmExtension)} does not support writing '{options.Format}' format.");
            }
        }

        BatchVmExtension IPersistableModel<BatchVmExtension>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmExtension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchVmExtension(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchVmExtension)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchVmExtension>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
