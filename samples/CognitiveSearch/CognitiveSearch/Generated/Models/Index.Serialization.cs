// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Index : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("fields");
            writer.WriteStartArray();
            foreach (var item in Fields)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (ScoringProfiles != null)
            {
                writer.WritePropertyName("scoringProfiles");
                writer.WriteStartArray();
                foreach (var item0 in ScoringProfiles)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (DefaultScoringProfile != null)
            {
                writer.WritePropertyName("defaultScoringProfile");
                writer.WriteStringValue(DefaultScoringProfile);
            }
            if (CorsOptions != null)
            {
                writer.WritePropertyName("corsOptions");
                writer.WriteObjectValue(CorsOptions);
            }
            if (Suggesters != null)
            {
                writer.WritePropertyName("suggesters");
                writer.WriteStartArray();
                foreach (var item0 in Suggesters)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (Analyzers != null)
            {
                writer.WritePropertyName("analyzers");
                writer.WriteStartArray();
                foreach (var item0 in Analyzers)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (Tokenizers != null)
            {
                writer.WritePropertyName("tokenizers");
                writer.WriteStartArray();
                foreach (var item0 in Tokenizers)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (TokenFilters != null)
            {
                writer.WritePropertyName("tokenFilters");
                writer.WriteStartArray();
                foreach (var item0 in TokenFilters)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (CharFilters != null)
            {
                writer.WritePropertyName("charFilters");
                writer.WriteStartArray();
                foreach (var item0 in CharFilters)
                {
                    writer.WriteObjectValue(item0);
                }
                writer.WriteEndArray();
            }
            if (ETag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }
        internal static Index DeserializeIndex(JsonElement element)
        {
            Index result = new Index();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Fields.Add(Field.DeserializeField(item));
                    }
                    continue;
                }
                if (property.NameEquals("scoringProfiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ScoringProfiles = new List<ScoringProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.ScoringProfiles.Add(ScoringProfile.DeserializeScoringProfile(item));
                    }
                    continue;
                }
                if (property.NameEquals("defaultScoringProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DefaultScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("corsOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.CorsOptions = CorsOptions.DeserializeCorsOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("suggesters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Suggesters = new List<Suggester>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Suggesters.Add(Suggester.DeserializeSuggester(item));
                    }
                    continue;
                }
                if (property.NameEquals("analyzers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Analyzers = new List<Analyzer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Analyzers.Add(Analyzer.DeserializeAnalyzer(item));
                    }
                    continue;
                }
                if (property.NameEquals("tokenizers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tokenizers = new List<Tokenizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Tokenizers.Add(Tokenizer.DeserializeTokenizer(item));
                    }
                    continue;
                }
                if (property.NameEquals("tokenFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TokenFilters = new List<TokenFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.TokenFilters.Add(TokenFilter.DeserializeTokenFilter(item));
                    }
                    continue;
                }
                if (property.NameEquals("charFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.CharFilters = new List<CharFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.CharFilters.Add(CharFilter.DeserializeCharFilter(item));
                    }
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ETag = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
