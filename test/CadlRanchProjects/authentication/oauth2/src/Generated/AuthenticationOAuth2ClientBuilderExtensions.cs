// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Authentication.OAuth2;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="OAuth2Client"/> to client builder. </summary>
    public static partial class AuthenticationOAuth2ClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="OAuth2Client"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        public static IAzureClientBuilder<OAuth2Client, OAuth2ClientOptions> AddOAuth2Client<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<OAuth2Client, OAuth2ClientOptions>((options, cred) => new OAuth2Client(cred, endpoint, options));
        }

        /// <summary> Registers a <see cref="OAuth2Client"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<OAuth2Client, OAuth2ClientOptions> AddOAuth2Client<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<OAuth2Client, OAuth2ClientOptions>(configuration);
        }
    }
}
