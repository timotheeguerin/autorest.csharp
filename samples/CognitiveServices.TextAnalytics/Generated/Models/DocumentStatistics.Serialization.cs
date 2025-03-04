// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class DocumentStatistics
    {
        internal static DocumentStatistics DeserializeDocumentStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int charactersCount = default;
            int transactionsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("charactersCount"u8))
                {
                    charactersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"u8))
                {
                    transactionsCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new DocumentStatistics(charactersCount, transactionsCount);
        }
    }
}
