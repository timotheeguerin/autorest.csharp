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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using ExactMatchInheritance.Models;

namespace ExactMatchInheritance
{
    /// <summary> An internal class to add extension methods to. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _exactMatchModel2sClientDiagnostics;
        private ExactMatchModel2SRestOperations _exactMatchModel2sRestClient;
        private ClientDiagnostics _exactMatchModel3sClientDiagnostics;
        private ExactMatchModel3SRestOperations _exactMatchModel3sRestClient;
        private ClientDiagnostics _exactMatchModel4sClientDiagnostics;
        private ExactMatchModel4SRestOperations _exactMatchModel4sRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
        }

        private ClientDiagnostics ExactMatchModel2sClientDiagnostics => _exactMatchModel2sClientDiagnostics ??= new ClientDiagnostics("ExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ExactMatchModel2SRestOperations ExactMatchModel2sRestClient => _exactMatchModel2sRestClient ??= new ExactMatchModel2SRestOperations(ExactMatchModel2sClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics ExactMatchModel3sClientDiagnostics => _exactMatchModel3sClientDiagnostics ??= new ClientDiagnostics("ExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ExactMatchModel3SRestOperations ExactMatchModel3sRestClient => _exactMatchModel3sRestClient ??= new ExactMatchModel3SRestOperations(ExactMatchModel3sClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics ExactMatchModel4sClientDiagnostics => _exactMatchModel4sClientDiagnostics ??= new ClientDiagnostics("ExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ExactMatchModel4SRestOperations ExactMatchModel4sRestClient => _exactMatchModel4sRestClient ??= new ExactMatchModel4SRestOperations(ExactMatchModel4sClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            ArmClient.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel2s_Put
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel2SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel2>> PutExactMatchModel2Async(string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel2SName, nameof(exactMatchModel2SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = ExactMatchModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutExactMatchModel2");
            scope.Start();
            try
            {
                var response = await ExactMatchModel2sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel2SName, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel2s_Put
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel2SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<ExactMatchModel2> PutExactMatchModel2(string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel2SName, nameof(exactMatchModel2SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = ExactMatchModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutExactMatchModel2");
            scope.Start();
            try
            {
                var response = ExactMatchModel2sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel2SName, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel3s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExactMatchModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExactMatchModel3> GetExactMatchModel3sAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExactMatchModel3>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetExactMatchModel3s");
                scope.Start();
                try
                {
                    var response = await ExactMatchModel3sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel3s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExactMatchModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExactMatchModel3> GetExactMatchModel3s(CancellationToken cancellationToken = default)
        {
            Page<ExactMatchModel3> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetExactMatchModel3s");
                scope.Start();
                try
                {
                    var response = ExactMatchModel3sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel3s_Put
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel3>> PutExactMatchModel3Async(string exactMatchModel3SName, ExactMatchModel3 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutExactMatchModel3");
            scope.Start();
            try
            {
                var response = await ExactMatchModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel3s_Put
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<ExactMatchModel3> PutExactMatchModel3(string exactMatchModel3SName, ExactMatchModel3 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutExactMatchModel3");
            scope.Start();
            try
            {
                var response = ExactMatchModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel3s_Get
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel3>> GetExactMatchModel3Async(string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetExactMatchModel3");
            scope.Start();
            try
            {
                var response = await ExactMatchModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel3s_Get
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> is null. </exception>
        public virtual Response<ExactMatchModel3> GetExactMatchModel3(string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetExactMatchModel3");
            scope.Start();
            try
            {
                var response = ExactMatchModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel4s_Put
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel4SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel4SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ExactMatchModel4>> PutExactMatchModel4Async(string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel4SName, nameof(exactMatchModel4SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = ExactMatchModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutExactMatchModel4");
            scope.Start();
            try
            {
                var response = await ExactMatchModel4sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel4SName, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ExactMatchModel4s_Put
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel4SName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel4SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<ExactMatchModel4> PutExactMatchModel4(string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel4SName, nameof(exactMatchModel4SName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = ExactMatchModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutExactMatchModel4");
            scope.Start();
            try
            {
                var response = ExactMatchModel4sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel4SName, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
