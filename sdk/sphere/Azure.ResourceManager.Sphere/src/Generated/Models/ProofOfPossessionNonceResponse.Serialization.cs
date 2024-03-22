// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class ProofOfPossessionNonceResponse : IUtf8JsonSerializable, IJsonModel<ProofOfPossessionNonceResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProofOfPossessionNonceResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProofOfPossessionNonceResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProofOfPossessionNonceResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteStringValue(Certificate);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (options.Format != "W" && Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiryUtc))
            {
                writer.WritePropertyName("expiryUtc"u8);
                writer.WriteStringValue(ExpiryUtc.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(NotBeforeUtc))
            {
                writer.WritePropertyName("notBeforeUtc"u8);
                writer.WriteStringValue(NotBeforeUtc.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        ProofOfPossessionNonceResponse IJsonModel<ProofOfPossessionNonceResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProofOfPossessionNonceResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProofOfPossessionNonceResponse(document.RootElement, options);
        }

        internal static ProofOfPossessionNonceResponse DeserializeProofOfPossessionNonceResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string certificate = default;
            SphereCertificateStatus? status = default;
            string subject = default;
            string thumbprint = default;
            DateTimeOffset? expiryUtc = default;
            DateTimeOffset? notBeforeUtc = default;
            SphereProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SphereCertificateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("notBeforeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notBeforeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SphereProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProofOfPossessionNonceResponse(
                certificate,
                status,
                subject,
                thumbprint,
                expiryUtc,
                notBeforeUtc,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProofOfPossessionNonceResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProofOfPossessionNonceResponse)} does not support writing '{options.Format}' format.");
            }
        }

        ProofOfPossessionNonceResponse IPersistableModel<ProofOfPossessionNonceResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProofOfPossessionNonceResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProofOfPossessionNonceResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProofOfPossessionNonceResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProofOfPossessionNonceResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
