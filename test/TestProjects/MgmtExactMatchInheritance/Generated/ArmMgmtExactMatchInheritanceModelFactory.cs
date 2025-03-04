// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.Models;
using MgmtExactMatchInheritance;

namespace MgmtExactMatchInheritance.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtExactMatchInheritanceModelFactory
    {

        /// <summary> Initializes a new instance of ExactMatchModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="new"></param>
        /// <param name="supportingUris"></param>
        /// <param name="type1"></param>
        /// <param name="type2"></param>
        /// <param name="type3"></param>
        /// <param name="type4"></param>
        /// <param name="type5"> Any object. </param>
        /// <param name="type6"> Any object. </param>
        /// <param name="type7"> Any object. </param>
        /// <param name="type8"> Any object. </param>
        /// <param name="type9"> Any object. </param>
        /// <param name="type10"> Any object. </param>
        /// <param name="type11"> Any object. </param>
        /// <param name="type12"> Any object. </param>
        /// <param name="type13"> Any object. </param>
        /// <param name="type14"> Any object. </param>
        /// <param name="type15"> Any object. </param>
        /// <param name="type16"> Any object. </param>
        /// <returns> A new <see cref="MgmtExactMatchInheritance.ExactMatchModel1Data"/> instance for mocking. </returns>
        public static ExactMatchModel1Data ExactMatchModel1Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string @new = null, IEnumerable<Uri> supportingUris = null, Type1? type1 = null, Type2? type2 = null, IPAddress type3 = null, object type4 = null, DataFactoryElement<string> type5 = null, DataFactoryElement<double> type6 = null, DataFactoryElement<bool> type7 = null, DataFactoryElement<int> type8 = null, DataFactoryElement<BinaryData> type9 = null, DataFactoryElement<IList<SeparateClass>> type10 = null, DataFactoryElement<IList<string>> type11 = null, DataFactoryElement<IDictionary<string, string>> type12 = null, DataFactoryElement<IList<SeparateClass>> type13 = null, DataFactoryElement<DateTimeOffset> type14 = null, DataFactoryElement<TimeSpan> type15 = null, DataFactoryElement<Uri> type16 = null)
        {
            supportingUris ??= new List<Uri>();

            return new ExactMatchModel1Data(id, name, resourceType, systemData, @new, supportingUris?.ToList(), type1, type2, type3, type4, type5, type6, type7, type8, type9, type10, type11, type12, type13, type14, type15, type16);
        }

        /// <summary> Initializes a new instance of ExactMatchModel5Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="new"></param>
        /// <returns> A new <see cref="MgmtExactMatchInheritance.ExactMatchModel5Data"/> instance for mocking. </returns>
        public static ExactMatchModel5Data ExactMatchModel5Data(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string @new = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ExactMatchModel5Data(id, name, resourceType, systemData, tags, location, @new);
        }

        /// <summary> Initializes a new instance of ExactMatchModel10. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <returns> A new <see cref="Models.ExactMatchModel10"/> instance for mocking. </returns>
        public static ExactMatchModel10 ExactMatchModel10(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, AzureLocation? location = null, IDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ExactMatchModel10(id, name, resourceType, systemData, location, tags);
        }

        /// <summary> Initializes a new instance of ExactMatchModel11. </summary>
        /// <param name="name"></param>
        /// <param name="resourceType"></param>
        /// <returns> A new <see cref="Models.ExactMatchModel11"/> instance for mocking. </returns>
        public static ExactMatchModel11 ExactMatchModel11(string name = null, ResourceType? resourceType = null)
        {
            return new ExactMatchModel11(name, resourceType);
        }
    }
}
