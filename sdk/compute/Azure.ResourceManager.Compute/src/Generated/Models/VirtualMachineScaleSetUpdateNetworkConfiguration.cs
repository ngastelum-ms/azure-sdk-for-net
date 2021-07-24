// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set network profile&apos;s network configurations. </summary>
    public partial class VirtualMachineScaleSetUpdateNetworkConfiguration : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateNetworkConfiguration. </summary>
        public VirtualMachineScaleSetUpdateNetworkConfiguration()
        {
            IpConfigurations = new ChangeTrackingList<VirtualMachineScaleSetUpdateIPConfiguration>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateNetworkConfiguration. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The network configuration name. </param>
        /// <param name="primary"> Whether this is a primary NIC on a virtual machine. </param>
        /// <param name="enableAcceleratedNetworking"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="enableFpga"> Specifies whether the network interface is FPGA networking-enabled. </param>
        /// <param name="networkSecurityGroup"> The network security group. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the network interfaces. </param>
        /// <param name="ipConfigurations"> The virtual machine scale set IP Configuration. </param>
        /// <param name="enableIPForwarding"> Whether IP forwarding enabled on this NIC. </param>
        /// <param name="deleteOption"> Specify what happens to the network interface when the VM is deleted. </param>
        internal VirtualMachineScaleSetUpdateNetworkConfiguration(string id, string name, bool? primary, bool? enableAcceleratedNetworking, bool? enableFpga, SubResource networkSecurityGroup, VirtualMachineScaleSetNetworkConfigurationDnsSettings dnsSettings, IList<VirtualMachineScaleSetUpdateIPConfiguration> ipConfigurations, bool? enableIPForwarding, DeleteOptions? deleteOption) : base(id)
        {
            Name = name;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            EnableFpga = enableFpga;
            NetworkSecurityGroup = networkSecurityGroup;
            DnsSettings = dnsSettings;
            IpConfigurations = ipConfigurations;
            EnableIPForwarding = enableIPForwarding;
            DeleteOption = deleteOption;
        }

        /// <summary> The network configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Whether this is a primary NIC on a virtual machine. </summary>
        public bool? Primary { get; set; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Specifies whether the network interface is FPGA networking-enabled. </summary>
        public bool? EnableFpga { get; set; }
        /// <summary> The network security group. </summary>
        public SubResource NetworkSecurityGroup { get; set; }
        /// <summary> The dns settings to be applied on the network interfaces. </summary>
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The virtual machine scale set IP Configuration. </summary>
        public IList<VirtualMachineScaleSetUpdateIPConfiguration> IpConfigurations { get; }
        /// <summary> Whether IP forwarding enabled on this NIC. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
        public DeleteOptions? DeleteOption { get; set; }
    }
}
