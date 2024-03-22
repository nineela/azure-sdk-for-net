// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Communication.Messages.Models.Channels;
using Azure.Core;

namespace Azure.Communication.Messages
{
    [PersistableModelProxy(typeof(UnknownMessageTemplateBindings))]
    public partial class MessageTemplateBindings : IUtf8JsonSerializable, IJsonModel<MessageTemplateBindings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageTemplateBindings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MessageTemplateBindings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageTemplateBindings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        MessageTemplateBindings IJsonModel<MessageTemplateBindings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageTemplateBindings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageTemplateBindings(document.RootElement, options);
        }

        internal static MessageTemplateBindings DeserializeMessageTemplateBindings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "whatsApp": return WhatsAppMessageTemplateBindings.DeserializeWhatsAppMessageTemplateBindings(element, options);
                }
            }
            return UnknownMessageTemplateBindings.DeserializeUnknownMessageTemplateBindings(element, options);
        }

        BinaryData IPersistableModel<MessageTemplateBindings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageTemplateBindings)} does not support writing '{options.Format}' format.");
            }
        }

        MessageTemplateBindings IPersistableModel<MessageTemplateBindings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageTemplateBindings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageTemplateBindings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageTemplateBindings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MessageTemplateBindings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMessageTemplateBindings(document.RootElement);
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
