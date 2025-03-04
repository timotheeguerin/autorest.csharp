// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class LinkedEntity
    {
        internal static LinkedEntity DeserializeLinkedEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<Match> matches = default;
            string language = default;
            Optional<string> id = default;
            string url = default;
            string dataSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matches"u8))
                {
                    List<Match> array = new List<Match>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Match.DeserializeMatch(item));
                    }
                    matches = array;
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    dataSource = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedEntity(name, matches, language, id.Value, url, dataSource);
        }
    }
}
