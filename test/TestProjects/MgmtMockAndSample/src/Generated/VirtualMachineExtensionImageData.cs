// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtMockAndSample
{
    /// <summary>
    /// A class representing the VirtualMachineExtensionImage data model.
    /// Describes a Virtual Machine Extension Image.
    /// </summary>
    public partial class VirtualMachineExtensionImageData : ResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        public VirtualMachineExtensionImageData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="operatingSystem"> The operating system this extension supports. </param>
        /// <param name="computeRole"> The type of role (IaaS or PaaS) this extension supports. </param>
        /// <param name="handlerSchema"> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </param>
        /// <param name="vmScaleSetEnabled"> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </param>
        /// <param name="supportsMultipleExtensions"> Whether the handler can support multiple extensions. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        internal VirtualMachineExtensionImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string operatingSystem, string computeRole, string handlerSchema, bool? vmScaleSetEnabled, bool? supportsMultipleExtensions, AzureLocation? location, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            OperatingSystem = operatingSystem;
            ComputeRole = computeRole;
            HandlerSchema = handlerSchema;
            VmScaleSetEnabled = vmScaleSetEnabled;
            SupportsMultipleExtensions = supportsMultipleExtensions;
            Location = location;
            Tags = tags;
        }

        /// <summary> The operating system this extension supports. </summary>
        public string OperatingSystem { get; set; }
        /// <summary> The type of role (IaaS or PaaS) this extension supports. </summary>
        public string ComputeRole { get; set; }
        /// <summary> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </summary>
        public string HandlerSchema { get; set; }
        /// <summary> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </summary>
        public bool? VmScaleSetEnabled { get; set; }
        /// <summary> Whether the handler can support multiple extensions. </summary>
        public bool? SupportsMultipleExtensions { get; set; }
        /// <summary> Azure location of the key vault resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Tags assigned to the key vault resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
