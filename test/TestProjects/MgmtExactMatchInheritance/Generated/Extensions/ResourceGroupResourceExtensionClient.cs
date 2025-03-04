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
using MgmtExactMatchInheritance.Models;

namespace MgmtExactMatchInheritance
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _exactMatchModel2sClientDiagnostics;
        private ExactMatchModel2SRestOperations _exactMatchModel2sRestClient;
        private ClientDiagnostics _exactMatchModel3sClientDiagnostics;
        private ExactMatchModel3SRestOperations _exactMatchModel3sRestClient;
        private ClientDiagnostics _exactMatchModel4sClientDiagnostics;
        private ExactMatchModel4SRestOperations _exactMatchModel4sRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ExactMatchModel2sClientDiagnostics => _exactMatchModel2sClientDiagnostics ??= new ClientDiagnostics("MgmtExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExactMatchModel2SRestOperations ExactMatchModel2sRestClient => _exactMatchModel2sRestClient ??= new ExactMatchModel2SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ExactMatchModel3sClientDiagnostics => _exactMatchModel3sClientDiagnostics ??= new ClientDiagnostics("MgmtExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExactMatchModel3SRestOperations ExactMatchModel3sRestClient => _exactMatchModel3sRestClient ??= new ExactMatchModel3SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ExactMatchModel4sClientDiagnostics => _exactMatchModel4sClientDiagnostics ??= new ClientDiagnostics("MgmtExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExactMatchModel4SRestOperations ExactMatchModel4sRestClient => _exactMatchModel4sRestClient ??= new ExactMatchModel4SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ExactMatchModel1Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ExactMatchModel1Resources and their operations over a ExactMatchModel1Resource. </returns>
        public virtual ExactMatchModel1Collection GetExactMatchModel1s()
        {
            return GetCachedClient(Client => new ExactMatchModel1Collection(Client, Id));
        }

        /// <summary> Gets a collection of ExactMatchModel5Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ExactMatchModel5Resources and their operations over a ExactMatchModel5Resource. </returns>
        public virtual ExactMatchModel5Collection GetExactMatchModel5s()
        {
            return GetCachedClient(Client => new ExactMatchModel5Collection(Client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel2s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="exactMatchModel2"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExactMatchModel2>> PutExactMatchModel2Async(string exactMatchModel2SName, ExactMatchModel2 exactMatchModel2, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel2sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.PutExactMatchModel2");
            scope.Start();
            try
            {
                var response = await ExactMatchModel2sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel2SName, exactMatchModel2, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel2s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="exactMatchModel2"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExactMatchModel2> PutExactMatchModel2(string exactMatchModel2SName, ExactMatchModel2 exactMatchModel2, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel2sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.PutExactMatchModel2");
            scope.Start();
            try
            {
                var response = ExactMatchModel2sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel2SName, exactMatchModel2, cancellationToken);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExactMatchModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExactMatchModel3> GetExactMatchModel3sAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExactMatchModel3sRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ExactMatchModel3.DeserializeExactMatchModel3, ExactMatchModel3sClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetExactMatchModel3s", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExactMatchModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExactMatchModel3> GetExactMatchModel3s(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExactMatchModel3sRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, ExactMatchModel3.DeserializeExactMatchModel3, ExactMatchModel3sClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetExactMatchModel3s", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="exactMatchModel3"> The ExactMatchModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExactMatchModel3>> PutExactMatchModel3Async(string exactMatchModel3SName, ExactMatchModel3 exactMatchModel3, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.PutExactMatchModel3");
            scope.Start();
            try
            {
                var response = await ExactMatchModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, exactMatchModel3, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="exactMatchModel3"> The ExactMatchModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExactMatchModel3> PutExactMatchModel3(string exactMatchModel3SName, ExactMatchModel3 exactMatchModel3, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.PutExactMatchModel3");
            scope.Start();
            try
            {
                var response = ExactMatchModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, exactMatchModel3, cancellationToken);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExactMatchModel3>> GetExactMatchModel3Async(string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetExactMatchModel3");
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

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExactMatchModel3> GetExactMatchModel3(string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetExactMatchModel3");
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

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel4s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="exactMatchModel4"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExactMatchModel4>> PutExactMatchModel4Async(string exactMatchModel4SName, ExactMatchModel4 exactMatchModel4, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel4sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.PutExactMatchModel4");
            scope.Start();
            try
            {
                var response = await ExactMatchModel4sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel4SName, exactMatchModel4, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel4s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="exactMatchModel4"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExactMatchModel4> PutExactMatchModel4(string exactMatchModel4SName, ExactMatchModel4 exactMatchModel4, CancellationToken cancellationToken = default)
        {
            using var scope = ExactMatchModel4sClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.PutExactMatchModel4");
            scope.Start();
            try
            {
                var response = ExactMatchModel4sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel4SName, exactMatchModel4, cancellationToken);
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
