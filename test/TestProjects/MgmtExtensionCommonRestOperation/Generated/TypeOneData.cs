// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtExtensionCommonRestOperation
{
    /// <summary>
    /// A class representing the TypeOne data model.
    /// The TypeOne.
    /// </summary>
    public partial class TypeOneData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of TypeOneData. </summary>
        /// <param name="location"> The location. </param>
        public TypeOneData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of TypeOneData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="myType"> The details of the type. </param>
        internal TypeOneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string myType) : base(id, name, resourceType, systemData, tags, location)
        {
            MyType = myType;
        }

        /// <summary> The details of the type. </summary>
        public string MyType { get; set; }
    }
}
