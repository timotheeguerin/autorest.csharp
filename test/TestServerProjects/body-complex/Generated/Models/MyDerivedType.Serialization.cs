// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class MyDerivedType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PropD1 != null)
            {
                writer.WritePropertyName("propD1");
                writer.WriteStringValue(PropD1);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            if (PropB1 != null)
            {
                writer.WritePropertyName("propB1");
                writer.WriteStringValue(PropB1);
            }
            writer.WritePropertyName("helper");
            writer.WriteStartObject();
            if (PropBH1 != null)
            {
                writer.WritePropertyName("propBH1");
                writer.WriteStringValue(PropBH1);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static MyDerivedType DeserializeMyDerivedType(JsonElement element)
        {
            MyDerivedType result = new MyDerivedType();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propD1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PropD1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    result.Kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propB1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PropB1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("helper"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("propBH1"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PropBH1 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
