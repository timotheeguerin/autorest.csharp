// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class PatternAnalyzer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LowerCaseTerms != null)
            {
                writer.WritePropertyName("lowercase");
                writer.WriteBooleanValue(LowerCaseTerms.Value);
            }
            if (Pattern != null)
            {
                writer.WritePropertyName("pattern");
                writer.WriteStringValue(Pattern);
            }
            if (Flags != null)
            {
                writer.WritePropertyName("flags");
                writer.WriteStringValue(Flags.Value.ToString());
            }
            if (Stopwords != null)
            {
                writer.WritePropertyName("stopwords");
                writer.WriteStartArray();
                foreach (var item in Stopwords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static PatternAnalyzer DeserializePatternAnalyzer(JsonElement element)
        {
            PatternAnalyzer result = new PatternAnalyzer();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lowercase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LowerCaseTerms = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("flags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Flags = new RegexFlags(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stopwords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Stopwords = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Stopwords.Add(item.GetString());
                    }
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
