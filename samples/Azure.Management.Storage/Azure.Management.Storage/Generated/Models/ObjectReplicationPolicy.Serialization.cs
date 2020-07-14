// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ObjectReplicationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId");
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(EnabledTime))
            {
                writer.WritePropertyName("enabledTime");
                writer.WriteStringValue(EnabledTime.Value, "O");
            }
            if (Optional.IsDefined(SourceAccount))
            {
                writer.WritePropertyName("sourceAccount");
                writer.WriteStringValue(SourceAccount);
            }
            if (Optional.IsDefined(DestinationAccount))
            {
                writer.WritePropertyName("destinationAccount");
                writer.WriteStringValue(DestinationAccount);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ObjectReplicationPolicy DeserializeObjectReplicationPolicy(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> policyId = default;
            Optional<DateTimeOffset> enabledTime = default;
            Optional<string> sourceAccount = default;
            Optional<string> destinationAccount = default;
            Optional<IList<ObjectReplicationPolicyRule>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policyId"))
                        {
                            policyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabledTime"))
                        {
                            enabledTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceAccount"))
                        {
                            sourceAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destinationAccount"))
                        {
                            destinationAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rules"))
                        {
                            List<ObjectReplicationPolicyRule> array = new List<ObjectReplicationPolicyRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ObjectReplicationPolicyRule.DeserializeObjectReplicationPolicyRule(item));
                            }
                            rules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ObjectReplicationPolicy(id.Value, name.Value, type.Value, policyId.Value, Optional.ToNullable(enabledTime), sourceAccount.Value, destinationAccount.Value, Optional.ToList(rules));
        }
    }
}
