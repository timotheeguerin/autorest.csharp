// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetVMProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OsProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OsProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Optional.IsDefined(DiagnosticsProfile))
            {
                writer.WritePropertyName("diagnosticsProfile"u8);
                writer.WriteObjectValue(DiagnosticsProfile);
            }
            if (Optional.IsDefined(ExtensionProfile))
            {
                writer.WritePropertyName("extensionProfile"u8);
                writer.WriteObjectValue(ExtensionProfile);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteStringValue(Priority.Value.ToString());
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy"u8);
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(BillingProfile))
            {
                writer.WritePropertyName("billingProfile"u8);
                writer.WriteObjectValue(BillingProfile);
            }
            if (Optional.IsDefined(ScheduledEventsProfile))
            {
                writer.WritePropertyName("scheduledEventsProfile"u8);
                writer.WriteObjectValue(ScheduledEventsProfile);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetVMProfile DeserializeVirtualMachineScaleSetVMProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualMachineScaleSetOSProfile> osProfile = default;
            Optional<VirtualMachineScaleSetStorageProfile> storageProfile = default;
            Optional<VirtualMachineScaleSetNetworkProfile> networkProfile = default;
            Optional<SecurityProfile> securityProfile = default;
            Optional<DiagnosticsProfile> diagnosticsProfile = default;
            Optional<VirtualMachineScaleSetExtensionProfile> extensionProfile = default;
            Optional<string> licenseType = default;
            Optional<VirtualMachinePriorityType> priority = default;
            Optional<VirtualMachineEvictionPolicyType> evictionPolicy = default;
            Optional<BillingProfile> billingProfile = default;
            Optional<ScheduledEventsProfile> scheduledEventsProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = VirtualMachineScaleSetOSProfile.DeserializeVirtualMachineScaleSetOSProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = VirtualMachineScaleSetStorageProfile.DeserializeVirtualMachineScaleSetStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = VirtualMachineScaleSetNetworkProfile.DeserializeVirtualMachineScaleSetNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("securityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityProfile = SecurityProfile.DeserializeSecurityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("diagnosticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticsProfile = DiagnosticsProfile.DeserializeDiagnosticsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("extensionProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionProfile = VirtualMachineScaleSetExtensionProfile.DeserializeVirtualMachineScaleSetExtensionProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = new VirtualMachinePriorityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evictionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evictionPolicy = new VirtualMachineEvictionPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfile = BillingProfile.DeserializeBillingProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("scheduledEventsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledEventsProfile = ScheduledEventsProfile.DeserializeScheduledEventsProfile(property.Value);
                    continue;
                }
            }
            return new VirtualMachineScaleSetVMProfile(osProfile.Value, storageProfile.Value, networkProfile.Value, securityProfile.Value, diagnosticsProfile.Value, extensionProfile.Value, licenseType.Value, Optional.ToNullable(priority), Optional.ToNullable(evictionPolicy), billingProfile.Value, scheduledEventsProfile.Value);
        }
    }
}
