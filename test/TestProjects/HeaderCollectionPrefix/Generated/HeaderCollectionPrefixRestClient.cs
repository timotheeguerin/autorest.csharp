// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace HeaderCollectionPrefix
{
    internal partial class HeaderCollectionPrefixRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of HeaderCollectionPrefixRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public HeaderCollectionPrefixRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal HttpMessage CreateOperationRequest(IDictionary<string, string> metadata)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Operation/", false);
            request.Uri = uri;
            if (metadata != null)
            {
                request.Headers.Add("x-ms-meta-", metadata);
            }
            return message;
        }

        /// <param name="metadata"> Optional. Include this parameter to specify that the queue&apos;s metadata be returned as part of the response body. Note that metadata requested with this parameter must be stored in accordance with the naming restrictions imposed by the 2009-09-19 version of the Queue service. Beginning with this version, all metadata names must adhere to the naming conventions for C# identifiers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<HeaderCollectionPrefixOperationHeaders>> OperationAsync(IDictionary<string, string> metadata = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationRequest(metadata);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new HeaderCollectionPrefixOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="metadata"> Optional. Include this parameter to specify that the queue&apos;s metadata be returned as part of the response body. Note that metadata requested with this parameter must be stored in accordance with the naming restrictions imposed by the 2009-09-19 version of the Queue service. Beginning with this version, all metadata names must adhere to the naming conventions for C# identifiers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<HeaderCollectionPrefixOperationHeaders> Operation(IDictionary<string, string> metadata = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationRequest(metadata);
            _pipeline.Send(message, cancellationToken);
            var headers = new HeaderCollectionPrefixOperationHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
