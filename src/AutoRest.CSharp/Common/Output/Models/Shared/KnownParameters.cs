﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace AutoRest.CSharp.Output.Models.Shared
{
    internal static class KnownParameters
    {
        private static readonly CSharpType MatchConditionsType = new(typeof(MatchConditions), true);
        private static readonly CSharpType RequestConditionsType = new(typeof(RequestConditions), true);
        private static readonly CSharpType RequestContentType = new(typeof(RequestContent));
        private static readonly CSharpType RequestContentNullableType = new(typeof(RequestContent), true);
        private static readonly CSharpType RequestContextType = new(typeof(RequestContext));
        private static readonly CSharpType RequestContextNullableType = new(typeof(RequestContext), true);

        public static readonly Parameter ClientDiagnostics = new("clientDiagnostics", "The handler for diagnostic messaging in the client.", new CSharpType(typeof(ClientDiagnostics)), null, ValidationType.AssertNotNull, null);
        public static readonly Parameter Pipeline = new("pipeline", "The HTTP pipeline for sending and receiving REST requests and responses", new CSharpType(typeof(HttpPipeline)), null, ValidationType.AssertNotNull, null);
        public static readonly Parameter KeyAuth = new("keyCredential", "The key credential to copy", new CSharpType(typeof(AzureKeyCredential)), null, ValidationType.None, null);
        public static readonly Parameter TokenAuth = new("tokenCredential", "The token credential to copy", new CSharpType(typeof(TokenCredential)), null, ValidationType.None, null);
        public static readonly Parameter Endpoint = new("endpoint", "Service endpoint", new CSharpType(typeof(Uri)), null, ValidationType.None, null, RequestLocation: RequestLocation.Uri);

        public static readonly Parameter PageSizeHint = new("pageSizeHint", "The number of items per <see cref=\"Page{T}\"/> that should be requested (from service operations that support it). It's not guaranteed that the value will be respected.", new CSharpType(typeof(int), true), null, ValidationType.None, null);
        public static readonly Parameter NextLink = new("nextLink", "Continuation token", typeof(string), null, ValidationType.None, null);

        public static readonly Parameter RequestContent = new("content", "The content to send as the body of the request.", RequestContentType, null, ValidationType.AssertNotNull, null, RequestLocation: RequestLocation.Body);
        public static readonly Parameter RequestContentNullable = new("content", "The content to send as the body of the request.", RequestContentNullableType, /*Constant.Default(RequestContentNullableType)*/null, ValidationType.None, null, RequestLocation: RequestLocation.Body);

        public static readonly Parameter MatchConditionsParameter = new("matchConditions", "The content to send as the request conditions of the request.", MatchConditionsType, Constant.Default(RequestConditionsType), ValidationType.None, null, RequestLocation: RequestLocation.Header);
        public static readonly Parameter RequestConditionsParameter = new("requestConditions", "The content to send as the request conditions of the request.", RequestConditionsType, Constant.Default(RequestConditionsType), ValidationType.None, null, RequestLocation: RequestLocation.Header);

        public static readonly Parameter RequestContext = new("context", "The request context, which can override default behaviors of the client pipeline on a per-call basis.", RequestContextNullableType, Constant.Default(RequestContextNullableType), ValidationType.None, null);
        public static readonly Parameter RequestContextRequired = new("context", "The request context, which can override default behaviors of the client pipeline on a per-call basis.", RequestContextType, null, ValidationType.None, null);

        public static readonly Parameter WaitForCompletion = new("waitUntil", "<see cref=\"Azure.WaitUntil.Completed\"/> if the method should wait to return until the long-running operation has completed on the service; <see cref=\"Azure.WaitUntil.Started\"/> if it should return after starting the operation. For more information on long-running operations, please see <see href=\"https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md\"> Azure.Core Long-Running Operation samples</see>.", new CSharpType(typeof(WaitUntil)), null, ValidationType.None, null);

        public static readonly Parameter CancellationTokenParameter = new("cancellationToken", "The cancellation token to use", new CSharpType(typeof(CancellationToken)), Constant.NewInstanceOf(typeof(CancellationToken)), ValidationType.None, null);
        public static readonly Parameter EnumeratorCancellationTokenParameter = new("cancellationToken", "Enumerator cancellation token", typeof(CancellationToken), Constant.NewInstanceOf(typeof(CancellationToken)), ValidationType.None, null) { Attributes = new[] { new CSharpAttribute(typeof(EnumeratorCancellationAttribute)) } };
    }
}
