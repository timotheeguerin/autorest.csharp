// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace additionalProperties.Models
{
    /// <summary> The CatAPTrue. </summary>
    public partial class CatAPTrue : PetAPTrue
    {
        /// <summary> Initializes a new instance of CatAPTrue. </summary>
        /// <param name="id"></param>
        public CatAPTrue(int id) : base(id)
        {
        }

        /// <summary> Initializes a new instance of CatAPTrue. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="friendly"></param>
        internal CatAPTrue(int id, string name, bool? status, IDictionary<string, object> additionalProperties, bool? friendly) : base(id, name, status, additionalProperties)
        {
            Friendly = friendly;
        }

        /// <summary> Gets or sets the friendly. </summary>
        public bool? Friendly { get; set; }
    }
}
