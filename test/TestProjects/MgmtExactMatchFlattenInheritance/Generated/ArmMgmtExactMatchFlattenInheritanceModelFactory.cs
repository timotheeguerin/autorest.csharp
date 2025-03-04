// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtExactMatchFlattenInheritance;

namespace MgmtExactMatchFlattenInheritance.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtExactMatchFlattenInheritanceModelFactory
    {

        /// <summary> Initializes a new instance of AzureResourceFlattenModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> New property. </param>
        /// <param name="fooPropertiesFoo"></param>
        /// <param name="idPropertiesId"> ID in CustomModel1. </param>
        /// <returns> A new <see cref="MgmtExactMatchFlattenInheritance.AzureResourceFlattenModel1Data"/> instance for mocking. </returns>
        public static AzureResourceFlattenModel1Data AzureResourceFlattenModel1Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? foo = null, string fooPropertiesFoo = null, string idPropertiesId = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AzureResourceFlattenModel1Data(id, name, resourceType, systemData, tags, location, foo, fooPropertiesFoo, idPropertiesId);
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel2. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> New property. </param>
        /// <returns> A new <see cref="Models.AzureResourceFlattenModel2"/> instance for mocking. </returns>
        public static AzureResourceFlattenModel2 AzureResourceFlattenModel2(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? foo = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AzureResourceFlattenModel2(id, name, resourceType, systemData, tags, location, foo);
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel3. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> New property. </param>
        /// <returns> A new <see cref="Models.AzureResourceFlattenModel3"/> instance for mocking. </returns>
        public static AzureResourceFlattenModel3 AzureResourceFlattenModel3(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? foo = null)
        {
            tags ??= new Dictionary<string, string>();

            return new AzureResourceFlattenModel3(id, name, resourceType, systemData, tags, location, foo);
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel5. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"> New property. </param>
        /// <returns> A new <see cref="Models.AzureResourceFlattenModel5"/> instance for mocking. </returns>
        public static AzureResourceFlattenModel5 AzureResourceFlattenModel5(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, int? foo = null)
        {
            return new AzureResourceFlattenModel5(id, name, resourceType, systemData, foo);
        }

        /// <summary> Initializes a new instance of CustomModel2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"></param>
        /// <returns> A new <see cref="MgmtExactMatchFlattenInheritance.CustomModel2Data"/> instance for mocking. </returns>
        public static CustomModel2Data CustomModel2Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string foo = null)
        {
            return new CustomModel2Data(id, name, resourceType, systemData, foo);
        }
    }
}
