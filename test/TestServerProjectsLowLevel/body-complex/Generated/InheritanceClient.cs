// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_complex_LowLevel
{
    /// <summary> The Inheritance service client. </summary>
    public partial class InheritanceClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of InheritanceClient for mocking. </summary>
        protected InheritanceClient()
        {
        }

        /// <summary> Initializes a new instance of InheritanceClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public InheritanceClient(AzureKeyCredential credential, Uri endpoint = null, AutoRestComplexTestServiceClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            endpoint ??= new Uri("http://localhost:3000");
            options ??= new AutoRestComplexTestServiceClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Get complex types that extend others. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   color: string,
        ///   hates: [
        ///     {
        ///       id: number,
        ///       name: string,
        ///       food: string
        ///     }
        ///   ],
        ///   id: number,
        ///   name: string,
        ///   breed: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetValidAsync(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("InheritanceClient.GetValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetValidRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that extend others. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   color: string,
        ///   hates: [
        ///     {
        ///       id: number,
        ///       name: string,
        ///       food: string
        ///     }
        ///   ],
        ///   id: number,
        ///   name: string,
        ///   breed: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetValid(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("InheritanceClient.GetValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetValidRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that extend others. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   color: string,
        ///   hates: [
        ///     {
        ///       id: number,
        ///       name: string,
        ///       food: string
        ///     }
        ///   ],
        ///   id: number,
        ///   name: string,
        ///   breed: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> PutValidAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _clientDiagnostics.CreateScope("InheritanceClient.PutValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that extend others. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   color: string,
        ///   hates: [
        ///     {
        ///       id: number,
        ///       name: string,
        ///       food: string
        ///     }
        ///   ],
        ///   id: number,
        ///   name: string,
        ///   breed: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   status: number,
        ///   message: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response PutValid(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _clientDiagnostics.CreateScope("InheritanceClient.PutValid");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutValidRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetValidRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/inheritance/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreatePutValidRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/complex/inheritance/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
