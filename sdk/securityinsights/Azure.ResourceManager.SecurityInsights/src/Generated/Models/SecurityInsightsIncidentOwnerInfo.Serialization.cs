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
    public partial class SecurityInsightsIncidentOwnerInfo : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIncidentOwnerInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIncidentOwnerInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIncidentOwnerInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentOwnerInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentOwnerInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(AssignedTo))
            {
                writer.WritePropertyName("assignedTo"u8);
                writer.WriteStringValue(AssignedTo);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId.Value);
            }
            if (Optional.IsDefined(UserPrincipalName))
            {
                writer.WritePropertyName("userPrincipalName"u8);
                writer.WriteStringValue(UserPrincipalName);
            }
            if (Optional.IsDefined(OwnerType))
            {
                writer.WritePropertyName("ownerType"u8);
                writer.WriteStringValue(OwnerType.Value.ToString());
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

        SecurityInsightsIncidentOwnerInfo IJsonModel<SecurityInsightsIncidentOwnerInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentOwnerInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentOwnerInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentOwnerInfo(document.RootElement, options);
        }

        internal static SecurityInsightsIncidentOwnerInfo DeserializeSecurityInsightsIncidentOwnerInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string email = default;
            string assignedTo = default;
            Guid? objectId = default;
            string userPrincipalName = default;
            SecurityInsightsIncidentOwnerType? ownerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignedTo"u8))
                {
                    assignedTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("userPrincipalName"u8))
                {
                    userPrincipalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownerType = new SecurityInsightsIncidentOwnerType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIncidentOwnerInfo(
                email,
                assignedTo,
                objectId,
                userPrincipalName,
                ownerType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsIncidentOwnerInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentOwnerInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentOwnerInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsIncidentOwnerInfo IPersistableModel<SecurityInsightsIncidentOwnerInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIncidentOwnerInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsIncidentOwnerInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIncidentOwnerInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsIncidentOwnerInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
