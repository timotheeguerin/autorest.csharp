// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtResourceName
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkResource" /> and their operations.
    /// Each <see cref="NetworkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkCollection" /> instance call the GetNetworks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkCollection : ArmCollection, IEnumerable<NetworkResource>, IAsyncEnumerable<NetworkResource>
    {
        private readonly ClientDiagnostics _networkNetworkResourcesClientDiagnostics;
        private readonly NetworkResourcesRestOperations _networkNetworkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCollection"/> class for mocking. </summary>
        protected NetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkNetworkResourcesClientDiagnostics = new ClientDiagnostics("MgmtResourceName", NetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkResource.ResourceType, out string networkNetworkResourcesApiVersion);
            _networkNetworkResourcesRestClient = new NetworkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkNetworkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources/{networkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkResources_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkResourceName"> The String to use. </param>
        /// <param name="data"> The Network to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkResourceName, NetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkResourceName, nameof(networkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkNetworkResourcesClientDiagnostics.CreateScope("NetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkNetworkResourcesRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, networkResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtResourceNameArmOperation<NetworkResource>(Response.FromValue(new NetworkResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources/{networkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkResources_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkResourceName"> The String to use. </param>
        /// <param name="data"> The Network to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkResource> CreateOrUpdate(WaitUntil waitUntil, string networkResourceName, NetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkResourceName, nameof(networkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkNetworkResourcesClientDiagnostics.CreateScope("NetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkNetworkResourcesRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, networkResourceName, data, cancellationToken);
                var operation = new MgmtResourceNameArmOperation<NetworkResource>(Response.FromValue(new NetworkResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources/{networkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkResourceName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkResourceName"/> is null. </exception>
        public virtual async Task<Response<NetworkResource>> GetAsync(string networkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkResourceName, nameof(networkResourceName));

            using var scope = _networkNetworkResourcesClientDiagnostics.CreateScope("NetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkNetworkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources/{networkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkResourceName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkResourceName"/> is null. </exception>
        public virtual Response<NetworkResource> Get(string networkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkResourceName, nameof(networkResourceName));

            using var scope = _networkNetworkResourcesClientDiagnostics.CreateScope("NetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _networkNetworkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkNetworkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new NetworkResource(Client, NetworkData.DeserializeNetworkData(e)), _networkNetworkResourcesClientDiagnostics, Pipeline, "NetworkCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkResources_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkNetworkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new NetworkResource(Client, NetworkData.DeserializeNetworkData(e)), _networkNetworkResourcesClientDiagnostics, Pipeline, "NetworkCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources/{networkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkResourceName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkResourceName, nameof(networkResourceName));

            using var scope = _networkNetworkResourcesClientDiagnostics.CreateScope("NetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkNetworkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/networkResources/{networkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkResourceName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkResourceName, nameof(networkResourceName));

            using var scope = _networkNetworkResourcesClientDiagnostics.CreateScope("NetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkNetworkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkResource> IEnumerable<NetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkResource> IAsyncEnumerable<NetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
