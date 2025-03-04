// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using SubClients_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="RootClient"/> to client builder. </summary>
    public static partial class LlcSubClientsClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="RootClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="cachedParameter"> The String to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        public static IAzureClientBuilder<RootClient, RootClientOptions> AddRootClient<TBuilder>(this TBuilder builder, string cachedParameter, AzureKeyCredential credential, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<RootClient, RootClientOptions>((options) => new RootClient(cachedParameter, credential, endpoint, options));
        }

        /// <summary> Registers a <see cref="RootClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<RootClient, RootClientOptions> AddRootClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<RootClient, RootClientOptions>(configuration);
        }
    }
}
