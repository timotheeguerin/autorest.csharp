// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtExtensionCommonRestOperation
{
    /// <summary> A class representing the TypeTwo data model. </summary>
    public partial class TypeTwoData : TrackedResource
    {
        /// <summary> Initializes a new instance of TypeTwoData. </summary>
        /// <param name="location"> The location. </param>
        public TypeTwoData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of TypeTwoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="myType"> The details of the type. </param>
        internal TypeTwoData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string myType) : base(id, name, type, tags, location)
        {
            MyType = myType;
        }

        /// <summary> The details of the type. </summary>
        public string MyType { get; set; }
    }
}
