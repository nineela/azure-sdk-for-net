// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasClassifications : IUtf8JsonSerializable, IJsonModel<AtlasClassifications>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasClassifications>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AtlasClassifications>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassifications>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasClassifications)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(List))
            {
                writer.WritePropertyName("list"u8);
                writer.WriteStartArray();
                foreach (var item in List)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PageSize))
            {
                writer.WritePropertyName("pageSize"u8);
                writer.WriteNumberValue(PageSize.Value);
            }
            if (Optional.IsDefined(SortBy))
            {
                writer.WritePropertyName("sortBy"u8);
                writer.WriteStringValue(SortBy);
            }
            if (Optional.IsDefined(SortType))
            {
                writer.WritePropertyName("sortType"u8);
                writer.WriteStringValue(SortType.Value.ToString());
            }
            if (Optional.IsDefined(StartIndex))
            {
                writer.WritePropertyName("startIndex"u8);
                writer.WriteNumberValue(StartIndex.Value);
            }
            if (Optional.IsDefined(TotalCount))
            {
                writer.WritePropertyName("totalCount"u8);
                writer.WriteNumberValue(TotalCount.Value);
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

        AtlasClassifications IJsonModel<AtlasClassifications>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassifications>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasClassifications)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasClassifications(document.RootElement, options);
        }

        internal static AtlasClassifications DeserializeAtlasClassifications(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<BinaryData> list = default;
            int? pageSize = default;
            string sortBy = default;
            AtlasSortType? sortType = default;
            int? startIndex = default;
            int? totalCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("list"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    list = array;
                    continue;
                }
                if (property.NameEquals("pageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sortBy"u8))
                {
                    sortBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sortType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sortType = new AtlasSortType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startIndex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AtlasClassifications(
                list ?? new ChangeTrackingList<BinaryData>(),
                pageSize,
                sortBy,
                sortType,
                startIndex,
                totalCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasClassifications>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassifications>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasClassifications)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasClassifications IPersistableModel<AtlasClassifications>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasClassifications>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasClassifications(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasClassifications)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasClassifications>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasClassifications FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasClassifications(document.RootElement);
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
