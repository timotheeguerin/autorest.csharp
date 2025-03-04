// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    /// <summary>
    /// Describes a virtual machine scale set storage profile.
    /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateStorageProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateStorageProfile. </summary>
        public VirtualMachineScaleSetUpdateStorageProfile()
        {
            DataDisks = new ChangeTrackingList<VirtualMachineScaleSetDataDisk>();
        }

        /// <summary>
        /// The image reference.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.imageReference
        /// </summary>
        public ImageReference ImageReference { get; set; }
        /// <summary>
        /// The OS disk.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.osDisk
        /// </summary>
        public VirtualMachineScaleSetUpdateOSDisk OSDisk { get; set; }
        /// <summary>
        /// The data disks.
        /// Serialized Name: VirtualMachineScaleSetUpdateStorageProfile.dataDisks
        /// </summary>
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; }
    }
}
