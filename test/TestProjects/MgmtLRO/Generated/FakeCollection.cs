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

namespace MgmtLRO
{
    /// <summary>
    /// A class representing a collection of <see cref="FakeResource" /> and their operations.
    /// Each <see cref="FakeResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="FakeCollection" /> instance call the GetFakes method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class FakeCollection : ArmCollection, IEnumerable<FakeResource>, IAsyncEnumerable<FakeResource>
    {
        private readonly ClientDiagnostics _fakeClientDiagnostics;
        private readonly FakesRestOperations _fakeRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeCollection"/> class for mocking. </summary>
        protected FakeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FakeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeClientDiagnostics = new ClientDiagnostics("MgmtLRO", FakeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FakeResource.ResourceType, out string fakeApiVersion);
            _fakeRestClient = new FakesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fakeApiVersion);
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
        /// Create or update an fake.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="data"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FakeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fakeName, FakeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fakeClientDiagnostics.CreateScope("FakeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, fakeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtLROArmOperation<FakeResource>(new FakeOperationSource(Client), _fakeClientDiagnostics, Pipeline, _fakeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fakeName, data).Request, response, OperationFinalStateVia.Location, skipApiVersionOverride: true);
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
        /// Create or update an fake.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="data"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FakeResource> CreateOrUpdate(WaitUntil waitUntil, string fakeName, FakeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fakeClientDiagnostics.CreateScope("FakeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, fakeName, data, cancellationToken);
                var operation = new MgmtLROArmOperation<FakeResource>(new FakeOperationSource(Client), _fakeClientDiagnostics, Pipeline, _fakeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fakeName, data).Request, response, OperationFinalStateVia.Location, skipApiVersionOverride: true);
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
        /// Retrieves information about an fake.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual async Task<Response<FakeResource>> GetAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeClientDiagnostics.CreateScope("FakeCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<FakeResource> Get(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeClientDiagnostics.CreateScope("FakeCollection.Get");
            scope.Start();
            try
            {
                var response = _fakeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all fakes in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeResource> GetAllAsync(string optionalParam = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fakeRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, optionalParam);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new FakeResource(Client, FakeData.DeserializeFakeData(e)), _fakeClientDiagnostics, Pipeline, "FakeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all fakes in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeResource> GetAll(string optionalParam = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fakeRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, optionalParam);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new FakeResource(Client, FakeData.DeserializeFakeData(e)), _fakeClientDiagnostics, Pipeline, "FakeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeClientDiagnostics.CreateScope("FakeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fakeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fakes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<bool> Exists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeClientDiagnostics.CreateScope("FakeCollection.Exists");
            scope.Start();
            try
            {
                var response = _fakeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FakeResource> IEnumerable<FakeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FakeResource> IAsyncEnumerable<FakeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
