// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MultipleMediaTypes.Models;

namespace MultipleMediaTypes
{
    // Data plane generated client.
    /// <summary> Play with produces/consumes and media-types in general. </summary>
    public partial class MultipleMediaTypesClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of MultipleMediaTypesClient for mocking. </summary>
        protected MultipleMediaTypesClient()
        {
        }

        /// <summary> Initializes a new instance of MultipleMediaTypesClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public MultipleMediaTypesClient(Uri endpoint) : this(endpoint, new MultipleMediaTypesClientOptions())
        {
        }

        /// <summary> Initializes a new instance of MultipleMediaTypesClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public MultipleMediaTypesClient(Uri endpoint, MultipleMediaTypesClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new MultipleMediaTypesClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <param name="body"> The Bytes to use. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneBinaryBodyTwoContentTypesAsync(BinaryData,ContentType,CancellationToken)']/*" />
        public virtual async Task<Response> OneBinaryBodyTwoContentTypesAsync(BinaryData body, ContentType contentType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await OneBinaryBodyTwoContentTypesAsync(body, contentType, context).ConfigureAwait(false);
            return response;
        }

        /// <param name="body"> The Bytes to use. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneBinaryBodyTwoContentTypes(BinaryData,ContentType,CancellationToken)']/*" />
        public virtual Response OneBinaryBodyTwoContentTypes(BinaryData body, ContentType contentType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = OneBinaryBodyTwoContentTypes(body, contentType, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="OneBinaryBodyTwoContentTypesAsync(BinaryData,ContentType,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneBinaryBodyTwoContentTypesAsync(RequestContent,ContentType,RequestContext)']/*" />
        public virtual async Task<Response> OneBinaryBodyTwoContentTypesAsync(RequestContent content, ContentType contentType, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("MultipleMediaTypesClient.OneBinaryBodyTwoContentTypes");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneBinaryBodyTwoContentTypesRequest(content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="OneBinaryBodyTwoContentTypes(BinaryData,ContentType,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneBinaryBodyTwoContentTypes(RequestContent,ContentType,RequestContext)']/*" />
        public virtual Response OneBinaryBodyTwoContentTypes(RequestContent content, ContentType contentType, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("MultipleMediaTypesClient.OneBinaryBodyTwoContentTypes");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneBinaryBodyTwoContentTypesRequest(content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The String to use. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot; | &quot;text/plain&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="body"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneStringBodyThreeContentTypesAsync(string,ContentType,CancellationToken)']/*" />
        public virtual async Task<Response> OneStringBodyThreeContentTypesAsync(string body, ContentType contentType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(body, nameof(body));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await OneStringBodyThreeContentTypesAsync(body, contentType, context).ConfigureAwait(false);
            return response;
        }

        /// <param name="body"> The String to use. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot; | &quot;text/plain&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="body"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneStringBodyThreeContentTypes(string,ContentType,CancellationToken)']/*" />
        public virtual Response OneStringBodyThreeContentTypes(string body, ContentType contentType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(body, nameof(body));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = OneStringBodyThreeContentTypes(body, contentType, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="OneStringBodyThreeContentTypesAsync(string,ContentType,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot; | &quot;text/plain&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneStringBodyThreeContentTypesAsync(RequestContent,ContentType,RequestContext)']/*" />
        public virtual async Task<Response> OneStringBodyThreeContentTypesAsync(RequestContent content, ContentType contentType, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("MultipleMediaTypesClient.OneStringBodyThreeContentTypes");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneStringBodyThreeContentTypesRequest(content, contentType, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="OneStringBodyThreeContentTypes(string,ContentType,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> The Union to use. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot; | &quot;text/plain&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneStringBodyThreeContentTypes(RequestContent,ContentType,RequestContext)']/*" />
        public virtual Response OneStringBodyThreeContentTypes(RequestContent content, ContentType contentType, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("MultipleMediaTypesClient.OneStringBodyThreeContentTypes");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneStringBodyThreeContentTypesRequest(content, contentType, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The Body to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneModelBodyOneContentTypeAsync(Body,CancellationToken)']/*" />
        public virtual async Task<Response> OneModelBodyOneContentTypeAsync(Body body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await OneModelBodyOneContentTypeAsync(body.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="body"> The Body to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneModelBodyOneContentType(Body,CancellationToken)']/*" />
        public virtual Response OneModelBodyOneContentType(Body body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = OneModelBodyOneContentType(body.ToRequestContent(), context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="OneModelBodyOneContentTypeAsync(Body,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneModelBodyOneContentTypeAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> OneModelBodyOneContentTypeAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("MultipleMediaTypesClient.OneModelBodyOneContentType");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneModelBodyOneContentTypeRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] 
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="OneModelBodyOneContentType(Body,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/MultipleMediaTypesClient.xml" path="doc/members/member[@name='OneModelBodyOneContentType(RequestContent,RequestContext)']/*" />
        public virtual Response OneModelBodyOneContentType(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("MultipleMediaTypesClient.OneModelBodyOneContentType");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOneModelBodyOneContentTypeRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateOneBinaryBodyTwoContentTypesRequest(RequestContent content, ContentType contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oneBinaryBodyTwoContentTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", contentType.ToString());
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateOneStringBodyThreeContentTypesRequest(RequestContent content, ContentType contentType, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oneStringBodyThreeContentTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", contentType.ToString());
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateOneModelBodyOneContentTypeRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/oneModelBodyOneContentType", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
