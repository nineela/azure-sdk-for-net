// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class LabelingJobProperties : IUtf8JsonSerializable, IJsonModel<LabelingJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabelingJobProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabelingJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabelingJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabelingJobProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                if (CreatedOn != null)
                {
                    writer.WritePropertyName("createdDateTime"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("createdDateTime");
                }
            }
            if (Optional.IsDefined(DataConfiguration))
            {
                if (DataConfiguration != null)
                {
                    writer.WritePropertyName("dataConfiguration"u8);
                    writer.WriteObjectValue(DataConfiguration);
                }
                else
                {
                    writer.WriteNull("dataConfiguration");
                }
            }
            if (Optional.IsDefined(JobInstructions))
            {
                if (JobInstructions != null)
                {
                    writer.WritePropertyName("jobInstructions"u8);
                    writer.WriteObjectValue(JobInstructions);
                }
                else
                {
                    writer.WriteNull("jobInstructions");
                }
            }
            if (Optional.IsCollectionDefined(LabelCategories))
            {
                if (LabelCategories != null)
                {
                    writer.WritePropertyName("labelCategories"u8);
                    writer.WriteStartObject();
                    foreach (var item in LabelCategories)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("labelCategories");
                }
            }
            if (Optional.IsDefined(LabelingJobMediaProperties))
            {
                if (LabelingJobMediaProperties != null)
                {
                    writer.WritePropertyName("labelingJobMediaProperties"u8);
                    writer.WriteObjectValue(LabelingJobMediaProperties);
                }
                else
                {
                    writer.WriteNull("labelingJobMediaProperties");
                }
            }
            if (Optional.IsDefined(MlAssistConfiguration))
            {
                writer.WritePropertyName("mlAssistConfiguration"u8);
                writer.WriteObjectValue(MlAssistConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(ProgressMetrics))
            {
                if (ProgressMetrics != null)
                {
                    writer.WritePropertyName("progressMetrics"u8);
                    writer.WriteObjectValue(ProgressMetrics);
                }
                else
                {
                    writer.WriteNull("progressMetrics");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteStringValue(ProjectId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StatusMessages))
            {
                if (StatusMessages != null)
                {
                    writer.WritePropertyName("statusMessages"u8);
                    writer.WriteStartArray();
                    foreach (var item in StatusMessages)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("statusMessages");
                }
            }
            if (Optional.IsDefined(ComponentId))
            {
                if (ComponentId != null)
                {
                    writer.WritePropertyName("componentId"u8);
                    writer.WriteStringValue(ComponentId);
                }
                else
                {
                    writer.WriteNull("componentId");
                }
            }
            if (Optional.IsDefined(ComputeId))
            {
                if (ComputeId != null)
                {
                    writer.WritePropertyName("computeId"u8);
                    writer.WriteStringValue(ComputeId);
                }
                else
                {
                    writer.WriteNull("computeId");
                }
            }
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName"u8);
                writer.WriteStringValue(ExperimentName);
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
            if (Optional.IsDefined(NotificationSetting))
            {
                if (NotificationSetting != null)
                {
                    writer.WritePropertyName("notificationSetting"u8);
                    writer.WriteObjectValue(NotificationSetting);
                }
                else
                {
                    writer.WriteNull("notificationSetting");
                }
            }
            if (Optional.IsCollectionDefined(SecretsConfiguration))
            {
                if (SecretsConfiguration != null)
                {
                    writer.WritePropertyName("secretsConfiguration"u8);
                    writer.WriteStartObject();
                    foreach (var item in SecretsConfiguration)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("secretsConfiguration");
                }
            }
            if (Optional.IsCollectionDefined(Services))
            {
                if (Services != null)
                {
                    writer.WritePropertyName("services"u8);
                    writer.WriteStartObject();
                    foreach (var item in Services)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("services");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
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

        LabelingJobProperties IJsonModel<LabelingJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabelingJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabelingJobProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabelingJobProperties(document.RootElement, options);
        }

        internal static LabelingJobProperties DeserializeLabelingJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? createdDateTime = default;
            LabelingDataConfiguration dataConfiguration = default;
            LabelingJobInstructions jobInstructions = default;
            IDictionary<string, LabelCategory> labelCategories = default;
            LabelingJobMediaProperties labelingJobMediaProperties = default;
            MachineLearningAssistConfiguration mlAssistConfiguration = default;
            ProgressMetrics progressMetrics = default;
            Guid? projectId = default;
            JobProvisioningState? provisioningState = default;
            IReadOnlyList<JobStatusMessage> statusMessages = default;
            ResourceIdentifier componentId = default;
            ResourceIdentifier computeId = default;
            string displayName = default;
            string experimentName = default;
            MachineLearningIdentityConfiguration identity = default;
            bool? isArchived = default;
            JobType jobType = default;
            NotificationSetting notificationSetting = default;
            IDictionary<string, SecretConfiguration> secretsConfiguration = default;
            IDictionary<string, MachineLearningJobService> services = default;
            MachineLearningJobStatus? status = default;
            string description = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdDateTime = null;
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dataConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataConfiguration = null;
                        continue;
                    }
                    dataConfiguration = LabelingDataConfiguration.DeserializeLabelingDataConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("jobInstructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobInstructions = null;
                        continue;
                    }
                    jobInstructions = LabelingJobInstructions.DeserializeLabelingJobInstructions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("labelCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        labelCategories = null;
                        continue;
                    }
                    Dictionary<string, LabelCategory> dictionary = new Dictionary<string, LabelCategory>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, LabelCategory.DeserializeLabelCategory(property0.Value, options));
                    }
                    labelCategories = dictionary;
                    continue;
                }
                if (property.NameEquals("labelingJobMediaProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        labelingJobMediaProperties = null;
                        continue;
                    }
                    labelingJobMediaProperties = LabelingJobMediaProperties.DeserializeLabelingJobMediaProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mlAssistConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mlAssistConfiguration = MachineLearningAssistConfiguration.DeserializeMachineLearningAssistConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("progressMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        progressMetrics = null;
                        continue;
                    }
                    progressMetrics = ProgressMetrics.DeserializeProgressMetrics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new JobProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusMessages = null;
                        continue;
                    }
                    List<JobStatusMessage> array = new List<JobStatusMessage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobStatusMessage.DeserializeJobStatusMessage(item, options));
                    }
                    statusMessages = array;
                    continue;
                }
                if (property.NameEquals("componentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentId = null;
                        continue;
                    }
                    componentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        computeId = null;
                        continue;
                    }
                    computeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("experimentName"u8))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = MachineLearningIdentityConfiguration.DeserializeMachineLearningIdentityConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isArchived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new JobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notificationSetting = null;
                        continue;
                    }
                    notificationSetting = NotificationSetting.DeserializeNotificationSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secretsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secretsConfiguration = null;
                        continue;
                    }
                    Dictionary<string, SecretConfiguration> dictionary = new Dictionary<string, SecretConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SecretConfiguration.DeserializeSecretConfiguration(property0.Value, options));
                    }
                    secretsConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        services = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningJobService> dictionary = new Dictionary<string, MachineLearningJobService>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningJobService.DeserializeMachineLearningJobService(property0.Value, options));
                    }
                    services = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LabelingJobProperties(
                description,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                componentId,
                computeId,
                displayName,
                experimentName,
                identity,
                isArchived,
                jobType,
                notificationSetting,
                secretsConfiguration ?? new ChangeTrackingDictionary<string, SecretConfiguration>(),
                services ?? new ChangeTrackingDictionary<string, MachineLearningJobService>(),
                status,
                createdDateTime,
                dataConfiguration,
                jobInstructions,
                labelCategories ?? new ChangeTrackingDictionary<string, LabelCategory>(),
                labelingJobMediaProperties,
                mlAssistConfiguration,
                progressMetrics,
                projectId,
                provisioningState,
                statusMessages ?? new ChangeTrackingList<JobStatusMessage>());
        }

        BinaryData IPersistableModel<LabelingJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabelingJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabelingJobProperties)} does not support writing '{options.Format}' format.");
            }
        }

        LabelingJobProperties IPersistableModel<LabelingJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabelingJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabelingJobProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabelingJobProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabelingJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
