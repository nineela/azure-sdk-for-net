// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class SourceDictionaryLanguage : IUtf8JsonSerializable, IJsonModel<SourceDictionaryLanguage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceDictionaryLanguage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceDictionaryLanguage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceDictionaryLanguage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("nativeName"u8);
            writer.WriteStringValue(NativeName);
            writer.WritePropertyName("dir"u8);
            writer.WriteStringValue(Dir);
            writer.WritePropertyName("translations"u8);
            writer.WriteStartArray();
            foreach (var item in Translations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        SourceDictionaryLanguage IJsonModel<SourceDictionaryLanguage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceDictionaryLanguage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceDictionaryLanguage(document.RootElement, options);
        }

        internal static SourceDictionaryLanguage DeserializeSourceDictionaryLanguage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string nativeName = default;
            string dir = default;
            IReadOnlyList<TargetDictionaryLanguage> translations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nativeName"u8))
                {
                    nativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dir"u8))
                {
                    dir = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translations"u8))
                {
                    List<TargetDictionaryLanguage> array = new List<TargetDictionaryLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetDictionaryLanguage.DeserializeTargetDictionaryLanguage(item, options));
                    }
                    translations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceDictionaryLanguage(name, nativeName, dir, translations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceDictionaryLanguage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceDictionaryLanguage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support writing '{options.Format}' format.");
            }
        }

        SourceDictionaryLanguage IPersistableModel<SourceDictionaryLanguage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceDictionaryLanguage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceDictionaryLanguage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceDictionaryLanguage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SourceDictionaryLanguage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSourceDictionaryLanguage(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
