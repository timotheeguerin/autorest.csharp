// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Suggester : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("searchMode");
            writer.WriteStringValue(SearchMode);
            writer.WritePropertyName("sourceFields");
            writer.WriteStartArray();
            foreach (var item in SourceFields)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
        internal static Suggester DeserializeSuggester(JsonElement element)
        {
            Suggester result = new Suggester();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"))
                {
                    result.SearchMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFields"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.SourceFields.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
