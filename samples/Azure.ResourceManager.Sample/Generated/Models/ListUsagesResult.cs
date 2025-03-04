// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// The List Usages operation response.
    /// Serialized Name: ListUsagesResult
    /// </summary>
    internal partial class ListUsagesResult
    {
        /// <summary> Initializes a new instance of ListUsagesResult. </summary>
        /// <param name="value">
        /// The list of compute resource usages.
        /// Serialized Name: ListUsagesResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ListUsagesResult(IEnumerable<SampleUsage> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ListUsagesResult. </summary>
        /// <param name="value">
        /// The list of compute resource usages.
        /// Serialized Name: ListUsagesResult.value
        /// </param>
        /// <param name="nextLink">
        /// The URI to fetch the next page of compute resource usage information. Call ListNext() with this to fetch the next page of compute resource usage information.
        /// Serialized Name: ListUsagesResult.nextLink
        /// </param>
        internal ListUsagesResult(IReadOnlyList<SampleUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of compute resource usages.
        /// Serialized Name: ListUsagesResult.value
        /// </summary>
        public IReadOnlyList<SampleUsage> Value { get; }
        /// <summary>
        /// The URI to fetch the next page of compute resource usage information. Call ListNext() with this to fetch the next page of compute resource usage information.
        /// Serialized Name: ListUsagesResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
