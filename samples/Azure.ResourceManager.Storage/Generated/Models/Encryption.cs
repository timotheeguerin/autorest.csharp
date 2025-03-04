// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The encryption settings on the storage account. </summary>
    public partial class Encryption
    {
        /// <summary> Initializes a new instance of Encryption. </summary>
        /// <param name="keySource"> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </param>
        public Encryption(KeySource keySource)
        {
            KeySource = keySource;
        }

        /// <summary> Initializes a new instance of Encryption. </summary>
        /// <param name="services"> List of services which support encryption. </param>
        /// <param name="keySource"> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </param>
        /// <param name="requireInfrastructureEncryption"> A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest. </param>
        /// <param name="keyVaultProperties"> Properties provided by key vault. </param>
        /// <param name="encryptionIdentity"> The identity to be used with service-side encryption at rest. </param>
        internal Encryption(EncryptionServices services, KeySource keySource, bool? requireInfrastructureEncryption, KeyVaultProperties keyVaultProperties, EncryptionIdentity encryptionIdentity)
        {
            Services = services;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
            KeyVaultProperties = keyVaultProperties;
            EncryptionIdentity = encryptionIdentity;
        }

        /// <summary> List of services which support encryption. </summary>
        public EncryptionServices Services { get; set; }
        /// <summary> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault. </summary>
        public KeySource KeySource { get; set; }
        /// <summary> A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest. </summary>
        public bool? RequireInfrastructureEncryption { get; set; }
        /// <summary> Properties provided by key vault. </summary>
        public KeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The identity to be used with service-side encryption at rest. </summary>
        internal EncryptionIdentity EncryptionIdentity { get; set; }
        /// <summary> Resource identifier of the UserAssigned identity to be associated with server-side encryption on the storage account. </summary>
        public string EncryptionUserAssignedIdentity
        {
            get => EncryptionIdentity is null ? default : EncryptionIdentity.EncryptionUserAssignedIdentity;
            set
            {
                if (EncryptionIdentity is null)
                    EncryptionIdentity = new EncryptionIdentity();
                EncryptionIdentity.EncryptionUserAssignedIdentity = value;
            }
        }
    }
}
