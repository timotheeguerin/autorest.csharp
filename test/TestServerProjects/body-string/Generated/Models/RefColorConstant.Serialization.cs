// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace body_string.Models
{
    public partial class RefColorConstant : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ColorConstant");
            writer.WriteStringValue(ColorConstant);
            if (Field1 != null)
            {
                writer.WritePropertyName("field1");
                writer.WriteStringValue(Field1);
            }
            writer.WriteEndObject();
        }
        internal static RefColorConstant DeserializeRefColorConstant(JsonElement element)
        {
            RefColorConstant result = new RefColorConstant();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ColorConstant"))
                {
                    result.ColorConstant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("field1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Field1 = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
