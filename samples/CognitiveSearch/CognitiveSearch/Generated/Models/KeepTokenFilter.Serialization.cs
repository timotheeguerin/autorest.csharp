// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class KeepTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keepWords");
            writer.WriteStartArray();
            foreach (var item in KeepWords)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (LowerCaseKeepWords != null)
            {
                writer.WritePropertyName("keepWordsCase");
                writer.WriteBooleanValue(LowerCaseKeepWords.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static KeepTokenFilter DeserializeKeepTokenFilter(JsonElement element)
        {
            KeepTokenFilter result = new KeepTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keepWords"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.KeepWords.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("keepWordsCase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LowerCaseKeepWords = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
