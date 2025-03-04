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

namespace url_multi_collectionFormat
{
    internal partial class QueriesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of QueriesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public QueriesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal HttpMessage CreateArrayStringMultiNullRequest(IEnumerable<string> arrayQuery)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/queries/array/multi/string/null", false);
            if (arrayQuery != null && Optional.IsCollectionDefined(arrayQuery))
            {
                foreach (var param in arrayQuery)
                {
                    uri.AppendQuery("arrayQuery", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> ArrayStringMultiNullAsync(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateArrayStringMultiNullRequest(arrayQuery);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response ArrayStringMultiNull(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateArrayStringMultiNullRequest(arrayQuery);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateArrayStringMultiEmptyRequest(IEnumerable<string> arrayQuery)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/queries/array/multi/string/empty", false);
            if (arrayQuery != null && Optional.IsCollectionDefined(arrayQuery))
            {
                foreach (var param in arrayQuery)
                {
                    uri.AppendQuery("arrayQuery", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> ArrayStringMultiEmptyAsync(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateArrayStringMultiEmptyRequest(arrayQuery);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response ArrayStringMultiEmpty(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateArrayStringMultiEmptyRequest(arrayQuery);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateArrayStringMultiValidRequest(IEnumerable<string> arrayQuery)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/queries/array/multi/string/valid", false);
            if (arrayQuery != null && Optional.IsCollectionDefined(arrayQuery))
            {
                foreach (var param in arrayQuery)
                {
                    uri.AppendQuery("arrayQuery", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> ArrayStringMultiValidAsync(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateArrayStringMultiValidRequest(arrayQuery);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response ArrayStringMultiValid(IEnumerable<string> arrayQuery = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateArrayStringMultiValidRequest(arrayQuery);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
