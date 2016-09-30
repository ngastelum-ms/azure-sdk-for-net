// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information

namespace Microsoft.Azure.Management.Fluent.Compute
{

    using Microsoft.Azure.Management.Fluent.Resource.Core;
    using Microsoft.Azure.Management.Compute.Models;
    /// <summary>
    /// The implementation for VirtualMachineExtensionImage.
    /// </summary>
    internal partial class VirtualMachineExtensionImageImpl :
        Wrapper<VirtualMachineExtensionImageInner>,
        IVirtualMachineExtensionImage
    {
        private IVirtualMachineExtensionImageVersion version;
        internal VirtualMachineExtensionImageImpl(IVirtualMachineExtensionImageVersion version, VirtualMachineExtensionImageInner inner) : base(inner)
        {
            this.version = version;
        }

        public string Id
        {
            get
            {
                return this.Inner.Id;
            }
        }

        public string RegionName
        {
            get
            {
                return this.Inner.Location;
            }
        }

        public string PublisherName
        {
            get
            {
                return this.Version().Type().Publisher().Name;
            }
        }

        public string TypeName
        {
            get
            {
                return this.Version().Type().Name;
            }
        }

        public string VersionName
        {
            get
            {
                return this.Version().Name;
            }
        }
        public OperatingSystemTypes? OsType
        {
            get
            {
                if (this.Inner.OperatingSystem == null)
                {
                    return null;
                }
                // OperatingSystemTypes is an AutoRest generated type from the swagger
                return EnumHelper.FromEnumMemberSerializationValue<OperatingSystemTypes>(this.Inner.OperatingSystem);
            }
        }

        public ComputeRoles? ComputeRole
        {
            get
            {
                if (this.Inner.ComputeRole == null)
                {
                    return null;
                }
                // ComputeRole is a fluent level convinence enum
                return EnumNameAttribute.FromName<ComputeRoles>(this.Inner.ComputeRole);
            }
        }

        public string HandlerSchema
        {
            get
            {
                return this.Inner.HandlerSchema;
            }
        }

        public bool? SupportsVirtualMachineScaleSets
        {
            get
            {
                return this.Inner.VmScaleSetEnabled;
            }
        }

        public bool? SupportsMultipleExtensions
        {
            get
            {
                return this.Inner.SupportsMultipleExtensions;
            }
        }

        public IVirtualMachineExtensionImageVersion Version()
        {
            return this.version;
        }

    }
}