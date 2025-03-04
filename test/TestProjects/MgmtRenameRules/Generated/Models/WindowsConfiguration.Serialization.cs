// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    public partial class WindowsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisionVmAgent))
            {
                writer.WritePropertyName("provisionVMAgent"u8);
                writer.WriteBooleanValue(ProvisionVmAgent.Value);
            }
            if (Optional.IsDefined(EnableAutomaticUpdates))
            {
                writer.WritePropertyName("enableAutomaticUpdates"u8);
                writer.WriteBooleanValue(EnableAutomaticUpdates.Value);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsCollectionDefined(AdditionalUnattendContent))
            {
                writer.WritePropertyName("additionalUnattendContent"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalUnattendContent)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PatchSettings))
            {
                writer.WritePropertyName("patchSettings"u8);
                writer.WriteObjectValue(PatchSettings);
            }
            if (Optional.IsDefined(WinRM))
            {
                writer.WritePropertyName("winRM"u8);
                writer.WriteObjectValue(WinRM);
            }
            writer.WriteEndObject();
        }

        internal static WindowsConfiguration DeserializeWindowsConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> provisionVmAgent = default;
            Optional<bool> enableAutomaticUpdates = default;
            Optional<string> timeZone = default;
            Optional<IList<AdditionalUnattendContent>> additionalUnattendContent = default;
            Optional<PatchSettings> patchSettings = default;
            Optional<WinRMConfiguration> winRM = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisionVMAgent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionVmAgent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpdates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpdates = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalUnattendContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdditionalUnattendContent> array = new List<AdditionalUnattendContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AdditionalUnattendContent.DeserializeAdditionalUnattendContent(item));
                    }
                    additionalUnattendContent = array;
                    continue;
                }
                if (property.NameEquals("patchSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchSettings = PatchSettings.DeserializePatchSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("winRM"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    winRM = WinRMConfiguration.DeserializeWinRMConfiguration(property.Value);
                    continue;
                }
            }
            return new WindowsConfiguration(Optional.ToNullable(provisionVmAgent), Optional.ToNullable(enableAutomaticUpdates), timeZone.Value, Optional.ToList(additionalUnattendContent), patchSettings.Value, winRM.Value);
        }
    }
}
