// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using model_flattening.Models;

namespace model_flattening
{
    internal partial class ServiceRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePutArrayRequest(IEnumerable<Resource> resourceArray)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/array", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (resourceArray != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in resourceArray)
                {
                    content.JsonWriter.WriteObjectValue(item);
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            return message;
        }

        /// <summary> Put External Resource as an Array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutArrayAsync(IEnumerable<Resource> resourceArray = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutArrayRequest(resourceArray);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put External Resource as an Array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutArray(IEnumerable<Resource> resourceArray = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutArrayRequest(resourceArray);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetArrayRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/array", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get External Resource as an Array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyList<FlattenedProduct>>> GetArrayAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetArrayRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<FlattenedProduct> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<FlattenedProduct> array = new List<FlattenedProduct>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(FlattenedProduct.DeserializeFlattenedProduct(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get External Resource as an Array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<FlattenedProduct>> GetArray(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetArrayRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<FlattenedProduct> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<FlattenedProduct> array = new List<FlattenedProduct>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(FlattenedProduct.DeserializeFlattenedProduct(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutWrappedArrayRequest(IEnumerable<WrappedProduct> resourceArray)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/wrappedarray", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (resourceArray != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartArray();
                foreach (var item in resourceArray)
                {
                    content.JsonWriter.WriteObjectValue(item);
                }
                content.JsonWriter.WriteEndArray();
                request.Content = content;
            }
            return message;
        }

        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutWrappedArrayAsync(IEnumerable<WrappedProduct> resourceArray = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutWrappedArrayRequest(resourceArray);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutWrappedArray(IEnumerable<WrappedProduct> resourceArray = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutWrappedArrayRequest(resourceArray);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetWrappedArrayRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/wrappedarray", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyList<ProductWrapper>>> GetWrappedArrayAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetWrappedArrayRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ProductWrapper> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<ProductWrapper> array = new List<ProductWrapper>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ProductWrapper.DeserializeProductWrapper(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<ProductWrapper>> GetWrappedArray(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetWrappedArrayRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ProductWrapper> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<ProductWrapper> array = new List<ProductWrapper>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ProductWrapper.DeserializeProductWrapper(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutDictionaryRequest(IDictionary<string, FlattenedProduct> resourceDictionary)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/dictionary", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (resourceDictionary != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStartObject();
                foreach (var item in resourceDictionary)
                {
                    content.JsonWriter.WritePropertyName(item.Key);
                    content.JsonWriter.WriteObjectValue(item.Value);
                }
                content.JsonWriter.WriteEndObject();
                request.Content = content;
            }
            return message;
        }

        /// <summary> Put External Resource as a Dictionary. </summary>
        /// <param name="resourceDictionary"> External Resource as a Dictionary to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutDictionaryAsync(IDictionary<string, FlattenedProduct> resourceDictionary = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutDictionaryRequest(resourceDictionary);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put External Resource as a Dictionary. </summary>
        /// <param name="resourceDictionary"> External Resource as a Dictionary to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutDictionary(IDictionary<string, FlattenedProduct> resourceDictionary = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutDictionaryRequest(resourceDictionary);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDictionaryRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/dictionary", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get External Resource as a Dictionary. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<IReadOnlyDictionary<string, FlattenedProduct>>> GetDictionaryAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDictionaryRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, FlattenedProduct> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        Dictionary<string, FlattenedProduct> dictionary = new Dictionary<string, FlattenedProduct>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, FlattenedProduct.DeserializeFlattenedProduct(property.Value));
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get External Resource as a Dictionary. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyDictionary<string, FlattenedProduct>> GetDictionary(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDictionaryRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, FlattenedProduct> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        Dictionary<string, FlattenedProduct> dictionary = new Dictionary<string, FlattenedProduct>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, FlattenedProduct.DeserializeFlattenedProduct(property.Value));
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutResourceCollectionRequest(ResourceCollection resourceComplexObject)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/resourcecollection", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (resourceComplexObject != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(resourceComplexObject);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Put External Resource as a ResourceCollection. </summary>
        /// <param name="resourceComplexObject"> External Resource as a ResourceCollection to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutResourceCollectionAsync(ResourceCollection resourceComplexObject = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutResourceCollectionRequest(resourceComplexObject);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put External Resource as a ResourceCollection. </summary>
        /// <param name="resourceComplexObject"> External Resource as a ResourceCollection to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutResourceCollection(ResourceCollection resourceComplexObject = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutResourceCollectionRequest(resourceComplexObject);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetResourceCollectionRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/resourcecollection", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get External Resource as a ResourceCollection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ResourceCollection>> GetResourceCollectionAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetResourceCollectionRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceCollection.DeserializeResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get External Resource as a ResourceCollection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ResourceCollection> GetResourceCollection(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetResourceCollectionRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceCollection.DeserializeResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutSimpleProductRequest(SimpleProduct simpleBodyProduct)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/customFlattening", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (simpleBodyProduct != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(simpleBodyProduct);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SimpleProduct>> PutSimpleProductAsync(SimpleProduct simpleBodyProduct = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutSimpleProductRequest(simpleBodyProduct);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimpleProduct value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SimpleProduct> PutSimpleProduct(SimpleProduct simpleBodyProduct = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutSimpleProductRequest(simpleBodyProduct);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimpleProduct value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostFlattenedSimpleProductRequest(string productId, string description, string maxProductDisplayName, string genericValue, string odataValue)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/customFlattening", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var model = new SimpleProduct(productId)
            {
                Description = description,
                MaxProductDisplayName = maxProductDisplayName,
                GenericValue = genericValue,
                OdataValue = odataValue
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Put Flattened Simple Product with client flattening true on the parameter. </summary>
        /// <param name="productId"> Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles. </param>
        /// <param name="description"> Description of product. </param>
        /// <param name="maxProductDisplayName"> Display name of product. </param>
        /// <param name="genericValue"> Generic URL value. </param>
        /// <param name="odataValue"> URL value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SimpleProduct>> PostFlattenedSimpleProductAsync(string productId, string description = null, string maxProductDisplayName = null, string genericValue = null, string odataValue = null, CancellationToken cancellationToken = default)
        {
            if (productId == null)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            using var message = CreatePostFlattenedSimpleProductRequest(productId, description, maxProductDisplayName, genericValue, odataValue);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimpleProduct value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put Flattened Simple Product with client flattening true on the parameter. </summary>
        /// <param name="productId"> Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles. </param>
        /// <param name="description"> Description of product. </param>
        /// <param name="maxProductDisplayName"> Display name of product. </param>
        /// <param name="genericValue"> Generic URL value. </param>
        /// <param name="odataValue"> URL value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SimpleProduct> PostFlattenedSimpleProduct(string productId, string description = null, string maxProductDisplayName = null, string genericValue = null, string odataValue = null, CancellationToken cancellationToken = default)
        {
            if (productId == null)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            using var message = CreatePostFlattenedSimpleProductRequest(productId, description, maxProductDisplayName, genericValue, odataValue);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimpleProduct value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutSimpleProductWithGroupingRequest(FlattenParameterGroup flattenParameterGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/model-flatten/customFlattening/parametergrouping/", false);
            uri.AppendPath(flattenParameterGroup.Name, true);
            uri.AppendPath("/", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var model = new SimpleProduct(flattenParameterGroup.ProductId)
            {
                Description = flattenParameterGroup.Description,
                MaxProductDisplayName = flattenParameterGroup.MaxProductDisplayName,
                GenericValue = flattenParameterGroup.GenericValue,
                OdataValue = flattenParameterGroup.OdataValue
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="flattenParameterGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SimpleProduct>> PutSimpleProductWithGroupingAsync(FlattenParameterGroup flattenParameterGroup, CancellationToken cancellationToken = default)
        {
            if (flattenParameterGroup == null)
            {
                throw new ArgumentNullException(nameof(flattenParameterGroup));
            }

            using var message = CreatePutSimpleProductWithGroupingRequest(flattenParameterGroup);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimpleProduct value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="flattenParameterGroup"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SimpleProduct> PutSimpleProductWithGrouping(FlattenParameterGroup flattenParameterGroup, CancellationToken cancellationToken = default)
        {
            if (flattenParameterGroup == null)
            {
                throw new ArgumentNullException(nameof(flattenParameterGroup));
            }

            using var message = CreatePutSimpleProductWithGroupingRequest(flattenParameterGroup);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SimpleProduct value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
