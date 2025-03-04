// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtSupersetFlattenInheritance.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class ResourceModel2ListResult
    {
        /// <summary> Initializes a new instance of ResourceModel2ListResult. </summary>
        internal ResourceModel2ListResult()
        {
            Value = new ChangeTrackingList<ResourceModel2>();
        }

        /// <summary> Initializes a new instance of ResourceModel2ListResult. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal ResourceModel2ListResult(IReadOnlyList<ResourceModel2> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<ResourceModel2> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
