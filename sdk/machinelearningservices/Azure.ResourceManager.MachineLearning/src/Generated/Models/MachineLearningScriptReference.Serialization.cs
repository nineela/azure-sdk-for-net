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
    public partial class MachineLearningScriptReference : IUtf8JsonSerializable, IJsonModel<MachineLearningScriptReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningScriptReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningScriptReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScriptSource))
            {
                writer.WritePropertyName("scriptSource"u8);
                writer.WriteStringValue(ScriptSource);
            }
            if (Optional.IsDefined(ScriptData))
            {
                writer.WritePropertyName("scriptData"u8);
                writer.WriteStringValue(ScriptData);
            }
            if (Optional.IsDefined(ScriptArguments))
            {
                writer.WritePropertyName("scriptArguments"u8);
                writer.WriteStringValue(ScriptArguments);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout);
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

        MachineLearningScriptReference IJsonModel<MachineLearningScriptReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningScriptReference(document.RootElement, options);
        }

        internal static MachineLearningScriptReference DeserializeMachineLearningScriptReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scriptSource = default;
            string scriptData = default;
            string scriptArguments = default;
            string timeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptSource"u8))
                {
                    scriptSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptData"u8))
                {
                    scriptData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptArguments"u8))
                {
                    scriptArguments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    timeout = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningScriptReference(scriptSource, scriptData, scriptArguments, timeout, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningScriptReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningScriptReference IPersistableModel<MachineLearningScriptReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningScriptReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningScriptReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningScriptReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningScriptReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
