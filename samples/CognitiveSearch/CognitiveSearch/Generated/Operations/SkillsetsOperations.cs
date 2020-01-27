// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    internal partial class SkillsetsOperations
    {
        private string searchServiceName;
        private string searchDnsSuffix;
        private string ApiVersion;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of SkillsetsOperations. </summary>
        public SkillsetsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string searchServiceName, string searchDnsSuffix = "search.windows.net", string ApiVersion = "2019-05-06")
        {
            if (searchServiceName == null)
            {
                throw new ArgumentNullException(nameof(searchServiceName));
            }
            if (searchDnsSuffix == null)
            {
                throw new ArgumentNullException(nameof(searchDnsSuffix));
            }
            if (ApiVersion == null)
            {
                throw new ArgumentNullException(nameof(ApiVersion));
            }

            this.searchServiceName = searchServiceName;
            this.searchDnsSuffix = searchDnsSuffix;
            this.ApiVersion = ApiVersion;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateCreateOrUpdateRequest(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(skillset);
            request.Content = content;
            return message;
        }
        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Skillset>> CreateOrUpdateAsync(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(skillsetName, clientRequestId, ifMatch, ifNoneMatch, skillset);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = Skillset.DeserializeSkillset(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Skillset> CreateOrUpdate(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Skillset skillset, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(skillsetName, clientRequestId, ifMatch, ifNoneMatch, skillset);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = Skillset.DeserializeSkillset(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDeleteRequest(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            return message;
        }
        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(skillsetName, clientRequestId, ifMatch, ifNoneMatch);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string skillsetName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(skillsetName, clientRequestId, ifMatch, ifNoneMatch);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGetRequest(string skillsetName, Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Skillset>> GetAsync(string skillsetName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(skillsetName, clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = Skillset.DeserializeSkillset(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Skillset> Get(string skillsetName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(skillsetName, clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = Skillset.DeserializeSkillset(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateListRequest(string select, Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/skillsets", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ListSkillsetsResult>> ListAsync(string select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(select, clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = ListSkillsetsResult.DeserializeListSkillsetsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListSkillsetsResult> List(string select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(select, clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = ListSkillsetsResult.DeserializeListSkillsetsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateCreateRequest(Guid? clientRequestId, Skillset skillset)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(searchServiceName, false);
            uri.AppendRaw(".", false);
            uri.AppendRaw(searchDnsSuffix, false);
            uri.AppendPath("/skillsets", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(skillset);
            request.Content = content;
            return message;
        }
        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Skillset>> CreateAsync(Guid? clientRequestId, Skillset skillset, CancellationToken cancellationToken = default)
        {
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.Create");
            scope.Start();
            try
            {
                using var message = CreateCreateRequest(clientRequestId, skillset);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 201:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = Skillset.DeserializeSkillset(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Skillset> Create(Guid? clientRequestId, Skillset skillset, CancellationToken cancellationToken = default)
        {
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var scope = clientDiagnostics.CreateScope("SkillsetsOperations.Create");
            scope.Start();
            try
            {
                using var message = CreateCreateRequest(clientRequestId, skillset);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 201:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = Skillset.DeserializeSkillset(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
