// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using ModelsInCadl;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ModelsInCadlClient"/> to client builder. </summary>
    public static partial class ModelsInCadlClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ModelsInCadlClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Uri to use. </param>
        public static IAzureClientBuilder<ModelsInCadlClient, ModelsInCadlClientOptions> AddModelsInCadlClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ModelsInCadlClient, ModelsInCadlClientOptions>((options) => new ModelsInCadlClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="ModelsInCadlClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ModelsInCadlClient, ModelsInCadlClientOptions> AddModelsInCadlClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ModelsInCadlClient, ModelsInCadlClientOptions>(configuration);
        }
    }
}
