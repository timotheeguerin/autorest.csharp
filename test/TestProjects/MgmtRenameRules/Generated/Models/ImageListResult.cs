// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using MgmtRenameRules;

namespace MgmtRenameRules.Models
{
    /// <summary>
    /// The List Image operation response.
    /// Serialized Name: ImageListResult
    /// </summary>
    internal partial class ImageListResult
    {
        /// <summary> Initializes a new instance of ImageListResult. </summary>
        /// <param name="value">
        /// The list of Images.
        /// Serialized Name: ImageListResult.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ImageListResult(IEnumerable<ImageData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ImageListResult. </summary>
        /// <param name="value">
        /// The list of Images.
        /// Serialized Name: ImageListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The uri to fetch the next page of Images. Call ListNext() with this to fetch the next page of Images.
        /// Serialized Name: ImageListResult.nextLink
        /// </param>
        internal ImageListResult(IReadOnlyList<ImageData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of Images.
        /// Serialized Name: ImageListResult.value
        /// </summary>
        public IReadOnlyList<ImageData> Value { get; }
        /// <summary>
        /// The uri to fetch the next page of Images. Call ListNext() with this to fetch the next page of Images.
        /// Serialized Name: ImageListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
