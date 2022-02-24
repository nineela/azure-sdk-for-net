// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Common properties for the deployment script. </summary>
    internal partial class DeploymentScriptPropertiesBase
    {
        /// <summary> Initializes a new instance of DeploymentScriptPropertiesBase. </summary>
        internal DeploymentScriptPropertiesBase()
        {
            Outputs = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Container settings. </summary>
        internal ContainerConfiguration ContainerSettings { get; }
        /// <summary> Container group name, if not specified then the name will get auto-generated. Not specifying a &apos;containerGroupName&apos; indicates the system to generate a unique name which might end up flagging an Azure Policy as non-compliant. Use &apos;containerGroupName&apos; when you have an Azure Policy that expects a specific naming convention or when you want to fully control the name. &apos;containerGroupName&apos; property must be between 1 and 63 characters long, must contain only lowercase letters, numbers, and dashes and it cannot start or end with a dash and consecutive dashes are not allowed. To specify a &apos;containerGroupName&apos;, add the following object to properties: { &quot;containerSettings&quot;: { &quot;containerGroupName&quot;: &quot;contoso-container&quot; } }. If you do not want to specify a &apos;containerGroupName&apos; then do not add &apos;containerSettings&apos; property. </summary>
        public string ContainerGroupName
        {
            get => ContainerSettings.ContainerGroupName;
            set => ContainerSettings.ContainerGroupName = value;
        }

        /// <summary> Storage Account settings. </summary>
        public StorageAccountConfiguration StorageAccountSettings { get; }
        /// <summary> The clean up preference when the script execution gets in a terminal state. Default setting is &apos;Always&apos;. </summary>
        public CleanupOptions? CleanupPreference { get; }
        /// <summary> State of the script execution. This only appears in the response. </summary>
        public ScriptProvisioningState? ProvisioningState { get; }
        /// <summary> Contains the results of script execution. </summary>
        public ScriptStatus Status { get; }
        /// <summary> List of script outputs. </summary>
        public IReadOnlyDictionary<string, object> Outputs { get; }
    }
}
