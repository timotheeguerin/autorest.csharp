// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using MgmtSupersetInheritance.Models;

namespace MgmtSupersetInheritance
{
    public partial class SupersetModel7Data : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(New))
            {
                writer.WritePropertyName("new"u8);
                writer.WriteStringValue(New);
            }
            writer.WriteEndObject();
        }

        internal static SupersetModel7Data DeserializeSupersetModel7Data(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> @new = default;
            Optional<SupersetModel7SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new"u8))
                {
                    @new = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = SupersetModel7SystemData.DeserializeSupersetModel7SystemData(property.Value);
                    continue;
                }
            }
            return new SupersetModel7Data(id.Value, name.Value, type.Value, @new.Value, systemData.Value);
        }
    }
}
