// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class FhirServiceData : IUtf8JsonSerializable, IJsonModel<FhirServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirServiceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirServiceData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(AcrConfiguration))
            {
                writer.WritePropertyName("acrConfiguration"u8);
                writer.WriteObjectValue(AcrConfiguration);
            }
            if (Optional.IsDefined(AuthenticationConfiguration))
            {
                writer.WritePropertyName("authenticationConfiguration"u8);
                writer.WriteObjectValue(AuthenticationConfiguration);
            }
            if (Optional.IsDefined(CorsConfiguration))
            {
                writer.WritePropertyName("corsConfiguration"u8);
                writer.WriteObjectValue(CorsConfiguration);
            }
            if (Optional.IsDefined(ExportConfiguration))
            {
                writer.WritePropertyName("exportConfiguration"u8);
                writer.WriteObjectValue(ExportConfiguration);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(EventState))
            {
                writer.WritePropertyName("eventState"u8);
                writer.WriteStringValue(EventState.Value.ToString());
            }
            if (Optional.IsDefined(ResourceVersionPolicyConfiguration))
            {
                writer.WritePropertyName("resourceVersionPolicyConfiguration"u8);
                writer.WriteObjectValue(ResourceVersionPolicyConfiguration);
            }
            if (Optional.IsDefined(ImportConfiguration))
            {
                writer.WritePropertyName("importConfiguration"u8);
                writer.WriteObjectValue(ImportConfiguration);
            }
            if (Optional.IsDefined(ImplementationGuidesConfiguration))
            {
                writer.WritePropertyName("implementationGuidesConfiguration"u8);
                writer.WriteObjectValue(ImplementationGuidesConfiguration);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
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

        FhirServiceData IJsonModel<FhirServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirServiceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirServiceData(document.RootElement, options);
        }

        internal static FhirServiceData DeserializeFhirServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirServiceKind? kind = default;
            ManagedServiceIdentity identity = default;
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            HealthcareApisProvisioningState? provisioningState = default;
            FhirServiceAcrConfiguration acrConfiguration = default;
            FhirServiceAuthenticationConfiguration authenticationConfiguration = default;
            FhirServiceCorsConfiguration corsConfiguration = default;
            FhirServiceExportConfiguration exportConfiguration = default;
            IReadOnlyList<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections = default;
            HealthcareApisPublicNetworkAccess? publicNetworkAccess = default;
            FhirServiceEventState? eventState = default;
            FhirServiceResourceVersionPolicyConfiguration resourceVersionPolicyConfiguration = default;
            FhirServiceImportConfiguration importConfiguration = default;
            ImplementationGuidesConfiguration implementationGuidesConfiguration = default;
            Encryption encryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new FhirServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HealthcareApisProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("acrConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            acrConfiguration = FhirServiceAcrConfiguration.DeserializeFhirServiceAcrConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("authenticationConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationConfiguration = FhirServiceAuthenticationConfiguration.DeserializeFhirServiceAuthenticationConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("corsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            corsConfiguration = FhirServiceCorsConfiguration.DeserializeFhirServiceCorsConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("exportConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportConfiguration = FhirServiceExportConfiguration.DeserializeFhirServiceExportConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HealthcareApisPrivateEndpointConnectionData> array = new List<HealthcareApisPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new HealthcareApisPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventState = new FhirServiceEventState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceVersionPolicyConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceVersionPolicyConfiguration = FhirServiceResourceVersionPolicyConfiguration.DeserializeFhirServiceResourceVersionPolicyConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("importConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importConfiguration = FhirServiceImportConfiguration.DeserializeFhirServiceImportConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("implementationGuidesConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            implementationGuidesConfiguration = ImplementationGuidesConfiguration.DeserializeImplementationGuidesConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = Encryption.DeserializeEncryption(property0.Value, options);
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
            return new FhirServiceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                kind,
                provisioningState,
                acrConfiguration,
                authenticationConfiguration,
                corsConfiguration,
                exportConfiguration,
                privateEndpointConnections ?? new ChangeTrackingList<HealthcareApisPrivateEndpointConnectionData>(),
                publicNetworkAccess,
                eventState,
                resourceVersionPolicyConfiguration,
                importConfiguration,
                implementationGuidesConfiguration,
                encryption,
                identity,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FhirServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirServiceData)} does not support writing '{options.Format}' format.");
            }
        }

        FhirServiceData IPersistableModel<FhirServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirServiceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirServiceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
