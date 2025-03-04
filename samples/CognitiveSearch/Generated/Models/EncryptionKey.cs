// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> A customer-managed encryption key in Azure Key Vault. Keys that you create and manage can be used to encrypt or decrypt data-at-rest in Azure Cognitive Search, such as indexes and synonym maps. </summary>
    public partial class EncryptionKey
    {
        /// <summary> Initializes a new instance of EncryptionKey. </summary>
        /// <param name="keyVaultKeyName"> The name of your Azure Key Vault key to be used to encrypt your data at rest. </param>
        /// <param name="keyVaultKeyVersion"> The version of your Azure Key Vault key to be used to encrypt your data at rest. </param>
        /// <param name="keyVaultUri"> The URI of your Azure Key Vault, also referred to as DNS name, that contains the key to be used to encrypt your data at rest. An example URI might be https://my-keyvault-name.vault.azure.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultKeyName"/>, <paramref name="keyVaultKeyVersion"/> or <paramref name="keyVaultUri"/> is null. </exception>
        public EncryptionKey(string keyVaultKeyName, string keyVaultKeyVersion, string keyVaultUri)
        {
            Argument.AssertNotNull(keyVaultKeyName, nameof(keyVaultKeyName));
            Argument.AssertNotNull(keyVaultKeyVersion, nameof(keyVaultKeyVersion));
            Argument.AssertNotNull(keyVaultUri, nameof(keyVaultUri));

            KeyVaultKeyName = keyVaultKeyName;
            KeyVaultKeyVersion = keyVaultKeyVersion;
            KeyVaultUri = keyVaultUri;
        }

        /// <summary> Initializes a new instance of EncryptionKey. </summary>
        /// <param name="keyVaultKeyName"> The name of your Azure Key Vault key to be used to encrypt your data at rest. </param>
        /// <param name="keyVaultKeyVersion"> The version of your Azure Key Vault key to be used to encrypt your data at rest. </param>
        /// <param name="keyVaultUri"> The URI of your Azure Key Vault, also referred to as DNS name, that contains the key to be used to encrypt your data at rest. An example URI might be https://my-keyvault-name.vault.azure.net. </param>
        /// <param name="accessCredentials"> Optional Azure Active Directory credentials used for accessing your Azure Key Vault. Not required if using managed identity instead. </param>
        internal EncryptionKey(string keyVaultKeyName, string keyVaultKeyVersion, string keyVaultUri, AzureActiveDirectoryApplicationCredentials accessCredentials)
        {
            KeyVaultKeyName = keyVaultKeyName;
            KeyVaultKeyVersion = keyVaultKeyVersion;
            KeyVaultUri = keyVaultUri;
            AccessCredentials = accessCredentials;
        }

        /// <summary> The name of your Azure Key Vault key to be used to encrypt your data at rest. </summary>
        public string KeyVaultKeyName { get; set; }
        /// <summary> The version of your Azure Key Vault key to be used to encrypt your data at rest. </summary>
        public string KeyVaultKeyVersion { get; set; }
        /// <summary> The URI of your Azure Key Vault, also referred to as DNS name, that contains the key to be used to encrypt your data at rest. An example URI might be https://my-keyvault-name.vault.azure.net. </summary>
        public string KeyVaultUri { get; set; }
        /// <summary> Optional Azure Active Directory credentials used for accessing your Azure Key Vault. Not required if using managed identity instead. </summary>
        public AzureActiveDirectoryApplicationCredentials AccessCredentials { get; set; }
    }
}
