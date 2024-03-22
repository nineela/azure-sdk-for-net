// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerAutomaticTuningData : IUtf8JsonSerializable, IJsonModel<SqlServerAutomaticTuningData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerAutomaticTuningData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerAutomaticTuningData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerAutomaticTuningData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActualState))
            {
                writer.WritePropertyName("actualState"u8);
                writer.WriteStringValue(ActualState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        SqlServerAutomaticTuningData IJsonModel<SqlServerAutomaticTuningData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerAutomaticTuningData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerAutomaticTuningData(document.RootElement, options);
        }

        internal static SqlServerAutomaticTuningData DeserializeSqlServerAutomaticTuningData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            AutomaticTuningServerMode? desiredState = default;
            AutomaticTuningServerMode? actualState = default;
            IDictionary<string, AutomaticTuningServerOptions> options0 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("desiredState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            desiredState = property0.Value.GetString().ToAutomaticTuningServerMode();
                            continue;
                        }
                        if (property0.NameEquals("actualState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            actualState = property0.Value.GetString().ToAutomaticTuningServerMode();
                            continue;
                        }
                        if (property0.NameEquals("options"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AutomaticTuningServerOptions> dictionary = new Dictionary<string, AutomaticTuningServerOptions>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AutomaticTuningServerOptions.DeserializeAutomaticTuningServerOptions(property1.Value, options));
                            }
                            options0 = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlServerAutomaticTuningData(
                id,
                name,
                type,
                systemData,
                desiredState,
                actualState,
                options0 ?? new ChangeTrackingDictionary<string, AutomaticTuningServerOptions>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerAutomaticTuningData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerAutomaticTuningData)} does not support writing '{options.Format}' format.");
            }
        }

        SqlServerAutomaticTuningData IPersistableModel<SqlServerAutomaticTuningData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerAutomaticTuningData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerAutomaticTuningData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerAutomaticTuningData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
