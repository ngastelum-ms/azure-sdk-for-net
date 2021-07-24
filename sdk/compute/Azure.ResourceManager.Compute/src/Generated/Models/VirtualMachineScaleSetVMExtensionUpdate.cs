// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a VMSS VM Extension. </summary>
    public partial class VirtualMachineScaleSetVMExtensionUpdate : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionUpdate. </summary>
        public VirtualMachineScaleSetVMExtensionUpdate()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionUpdate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the extension. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="forceUpdateTag"> How the extension handler should be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="typePropertiesType"> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        internal VirtualMachineScaleSetVMExtensionUpdate(string id, string name, string type, string forceUpdateTag, string publisher, string typePropertiesType, string typeHandlerVersion, bool? autoUpgradeMinorVersion, bool? enableAutomaticUpgrade, object settings, object protectedSettings) : base(id)
        {
            Name = name;
            Type = type;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            TypePropertiesType = typePropertiesType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            EnableAutomaticUpgrade = enableAutomaticUpgrade;
            Settings = settings;
            ProtectedSettings = protectedSettings;
        }

        /// <summary> The name of the extension. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> How the extension handler should be forced to update even if the extension configuration has not changed. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </summary>
        public string TypePropertiesType { get; set; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </summary>
        public bool? EnableAutomaticUpgrade { get; set; }
        /// <summary> Json formatted public settings for the extension. </summary>
        public object Settings { get; set; }
        /// <summary> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </summary>
        public object ProtectedSettings { get; set; }
    }
}
