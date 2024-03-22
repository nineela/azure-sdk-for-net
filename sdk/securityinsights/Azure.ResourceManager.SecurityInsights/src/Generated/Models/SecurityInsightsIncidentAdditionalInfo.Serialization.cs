// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentAdditionalInfo : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIncidentAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIncidentAdditionalInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIncidentAdditionalInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentAdditionalInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AlertsCount))
            {
                writer.WritePropertyName("alertsCount"u8);
                writer.WriteNumberValue(AlertsCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BookmarksCount))
            {
                writer.WritePropertyName("bookmarksCount"u8);
                writer.WriteNumberValue(BookmarksCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CommentsCount))
            {
                writer.WritePropertyName("commentsCount"u8);
                writer.WriteNumberValue(CommentsCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AlertProductNames))
            {
                writer.WritePropertyName("alertProductNames"u8);
                writer.WriteStartArray();
                foreach (var item in AlertProductNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
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

        SecurityInsightsIncidentAdditionalInfo IJsonModel<SecurityInsightsIncidentAdditionalInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentAdditionalInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentAdditionalInfo(document.RootElement, options);
        }

        internal static SecurityInsightsIncidentAdditionalInfo DeserializeSecurityInsightsIncidentAdditionalInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? alertsCount = default;
            int? bookmarksCount = default;
            int? commentsCount = default;
            IReadOnlyList<string> alertProductNames = default;
            IReadOnlyList<SecurityInsightsAttackTactic> tactics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bookmarksCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bookmarksCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("commentsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("alertProductNames"u8))
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
                    alertProductNames = array;
                    continue;
                }
                if (property.NameEquals("tactics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                    }
                    tactics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIncidentAdditionalInfo(
                alertsCount,
                bookmarksCount,
                commentsCount,
                alertProductNames ?? new ChangeTrackingList<string>(),
                tactics ?? new ChangeTrackingList<SecurityInsightsAttackTactic>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsIncidentAdditionalInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentAdditionalInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsIncidentAdditionalInfo IPersistableModel<SecurityInsightsIncidentAdditionalInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsIncidentAdditionalInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentAdditionalInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsIncidentAdditionalInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
