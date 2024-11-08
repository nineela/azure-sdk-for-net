// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Scale and concurrency settings for the function app. </summary>
    public partial class FunctionAppScaleAndConcurrency
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FunctionAppScaleAndConcurrency"/>. </summary>
        public FunctionAppScaleAndConcurrency()
        {
            AlwaysReady = new ChangeTrackingList<FunctionAppAlwaysReadyConfig>();
        }

        /// <summary> Initializes a new instance of <see cref="FunctionAppScaleAndConcurrency"/>. </summary>
        /// <param name="alwaysReady"> 'Always Ready' configuration for the function app. </param>
        /// <param name="maximumInstanceCount"> The maximum number of instances for the function app. </param>
        /// <param name="instanceMemoryMB"> Set the amount of memory allocated to each instance of the function app in MB. CPU and network bandwidth are allocated proportionally. </param>
        /// <param name="triggers"> Scale and concurrency settings for the function app triggers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionAppScaleAndConcurrency(IList<FunctionAppAlwaysReadyConfig> alwaysReady, int? maximumInstanceCount, int? instanceMemoryMB, FunctionsScaleAndConcurrencyTriggers triggers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AlwaysReady = alwaysReady;
            MaximumInstanceCount = maximumInstanceCount;
            InstanceMemoryMB = instanceMemoryMB;
            Triggers = triggers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> 'Always Ready' configuration for the function app. </summary>
        [WirePath("alwaysReady")]
        public IList<FunctionAppAlwaysReadyConfig> AlwaysReady { get; }
        /// <summary> The maximum number of instances for the function app. </summary>
        [WirePath("maximumInstanceCount")]
        public int? MaximumInstanceCount { get; set; }
        /// <summary> Set the amount of memory allocated to each instance of the function app in MB. CPU and network bandwidth are allocated proportionally. </summary>
        [WirePath("instanceMemoryMB")]
        public int? InstanceMemoryMB { get; set; }
        /// <summary> Scale and concurrency settings for the function app triggers. </summary>
        internal FunctionsScaleAndConcurrencyTriggers Triggers { get; set; }
        /// <summary> The maximum number of concurrent HTTP trigger invocations per instance. </summary>
        [WirePath("triggers.http.perInstanceConcurrency")]
        public int? HttpPerInstanceConcurrency
        {
            get => Triggers is null ? default : Triggers.HttpPerInstanceConcurrency;
            set
            {
                if (Triggers is null)
                    Triggers = new FunctionsScaleAndConcurrencyTriggers();
                Triggers.HttpPerInstanceConcurrency = value;
            }
        }
    }
}
