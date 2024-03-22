// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class GitHubRepoProperties : IUtf8JsonSerializable, IJsonModel<GitHubRepoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubRepoProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GitHubRepoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubRepoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubRepoProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteNumberValue(AccountId.Value);
            }
            if (Optional.IsDefined(RepoUri))
            {
                writer.WritePropertyName("repoUrl"u8);
                writer.WriteStringValue(RepoUri.AbsoluteUri);
            }
            if (Optional.IsDefined(OwnerName))
            {
                writer.WritePropertyName("ownerName"u8);
                writer.WriteStringValue(OwnerName);
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

        GitHubRepoProperties IJsonModel<GitHubRepoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubRepoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubRepoProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubRepoProperties(document.RootElement, options);
        }

        internal static GitHubRepoProperties DeserializeGitHubRepoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            long? accountId = default;
            Uri repoUrl = default;
            string ownerName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("repoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ownerName"u8))
                {
                    ownerName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubRepoProperties(provisioningState, accountId, repoUrl, ownerName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GitHubRepoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubRepoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GitHubRepoProperties)} does not support writing '{options.Format}' format.");
            }
        }

        GitHubRepoProperties IPersistableModel<GitHubRepoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubRepoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGitHubRepoProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GitHubRepoProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GitHubRepoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
