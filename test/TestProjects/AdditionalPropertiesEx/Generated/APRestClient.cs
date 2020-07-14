// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AdditionalPropertiesEx.Models;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace AdditionalPropertiesEx
{
    internal partial class APRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of APRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public APRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateWriteOnlyRequest(InputAdditionalPropertiesModel createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/ap_operation", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> WriteOnlyAsync(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateWriteOnlyRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response WriteOnly(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var message = CreateWriteOnlyRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReadOnlyRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/ap_operation", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OutputAdditionalPropertiesModel>> ReadOnlyAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateReadOnlyRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OutputAdditionalPropertiesModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OutputAdditionalPropertiesModel.DeserializeOutputAdditionalPropertiesModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OutputAdditionalPropertiesModel> ReadOnly(CancellationToken cancellationToken = default)
        {
            using var message = CreateReadOnlyRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OutputAdditionalPropertiesModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OutputAdditionalPropertiesModel.DeserializeOutputAdditionalPropertiesModel(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateWriteOnlyStructRequest(InputAdditionalPropertiesModelStruct createParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/ap_struct_operation", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> WriteOnlyStructAsync(InputAdditionalPropertiesModelStruct createParameters, CancellationToken cancellationToken = default)
        {
            using var message = CreateWriteOnlyStructRequest(createParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response WriteOnlyStruct(InputAdditionalPropertiesModelStruct createParameters, CancellationToken cancellationToken = default)
        {
            using var message = CreateWriteOnlyStructRequest(createParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReadOnlyStructRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/ap_struct_operation", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OutputAdditionalPropertiesModelStruct>> ReadOnlyStructAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateReadOnlyStructRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OutputAdditionalPropertiesModelStruct value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OutputAdditionalPropertiesModelStruct.DeserializeOutputAdditionalPropertiesModelStruct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OutputAdditionalPropertiesModelStruct> ReadOnlyStruct(CancellationToken cancellationToken = default)
        {
            using var message = CreateReadOnlyStructRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OutputAdditionalPropertiesModelStruct value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OutputAdditionalPropertiesModelStruct.DeserializeOutputAdditionalPropertiesModelStruct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
