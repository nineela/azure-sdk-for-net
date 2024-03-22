// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseSqlPoolSecurityAlertPolicyListResult : IUtf8JsonSerializable, IJsonModel<SynapseSqlPoolSecurityAlertPolicyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSqlPoolSecurityAlertPolicyListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSqlPoolSecurityAlertPolicyListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSqlPoolSecurityAlertPolicyListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        SynapseSqlPoolSecurityAlertPolicyListResult IJsonModel<SynapseSqlPoolSecurityAlertPolicyListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSqlPoolSecurityAlertPolicyListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSqlPoolSecurityAlertPolicyListResult(document.RootElement, options);
        }

        internal static SynapseSqlPoolSecurityAlertPolicyListResult DeserializeSynapseSqlPoolSecurityAlertPolicyListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseSqlPoolSecurityAlertPolicyData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSqlPoolSecurityAlertPolicyData> array = new List<SynapseSqlPoolSecurityAlertPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSqlPoolSecurityAlertPolicyData.DeserializeSynapseSqlPoolSecurityAlertPolicyData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseSqlPoolSecurityAlertPolicyListResult(value ?? new ChangeTrackingList<SynapseSqlPoolSecurityAlertPolicyData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSqlPoolSecurityAlertPolicyListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseSqlPoolSecurityAlertPolicyListResult IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSqlPoolSecurityAlertPolicyListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSqlPoolSecurityAlertPolicyListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSqlPoolSecurityAlertPolicyListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
