// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace MgmtDiscriminator.Models
{
    public partial class OriginGroupOverrideActionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(TypeName.ToString());
            writer.WritePropertyName("originGroup"u8);
            JsonSerializer.Serialize(writer, OriginGroup); writer.WriteEndObject();
        }

        internal static OriginGroupOverrideActionParameters DeserializeOriginGroupOverrideActionParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OriginGroupOverrideActionParametersTypeName typeName = default;
            WritableSubResource originGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new OriginGroupOverrideActionParametersTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originGroup"u8))
                {
                    originGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new OriginGroupOverrideActionParameters(typeName, originGroup);
        }
    }
}
