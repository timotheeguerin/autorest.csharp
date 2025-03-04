// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class IndexDocumentsResult
    {
        internal static IndexDocumentsResult DeserializeIndexDocumentsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IndexingResult> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IndexingResult> array = new List<IndexingResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IndexingResult.DeserializeIndexingResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IndexDocumentsResult(value);
        }
    }
}
