// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Defines weights on index fields for which matches should boost scoring in search queries. </summary>
    public partial class TextWeights
    {
        /// <summary> The dictionary of per-field weights to boost document scoring. The keys are field names and the values are the weights for each field. </summary>
        public IDictionary<string, double> Weights { get; set; } = new System.Collections.Generic.Dictionary<string, double>();
    }
}
