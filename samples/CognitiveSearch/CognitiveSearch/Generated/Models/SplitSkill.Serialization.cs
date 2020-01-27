// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SplitSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DefaultLanguageCode != null)
            {
                writer.WritePropertyName("defaultLanguageCode");
                writer.WriteStringValue(DefaultLanguageCode.Value.ToString());
            }
            if (TextSplitMode != null)
            {
                writer.WritePropertyName("textSplitMode");
                writer.WriteStringValue(TextSplitMode.Value.ToSerialString());
            }
            if (MaximumPageLength != null)
            {
                writer.WritePropertyName("maximumPageLength");
                writer.WriteNumberValue(MaximumPageLength.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Context != null)
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs");
            writer.WriteStartArray();
            foreach (var item0 in Outputs)
            {
                writer.WriteObjectValue(item0);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
        internal static SplitSkill DeserializeSplitSkill(JsonElement element)
        {
            SplitSkill result = new SplitSkill();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultLanguageCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DefaultLanguageCode = new SplitSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("textSplitMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TextSplitMode = property.Value.GetString().ToTextSplitMode();
                    continue;
                }
                if (property.NameEquals("maximumPageLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaximumPageLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Inputs.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Outputs.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
