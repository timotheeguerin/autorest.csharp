// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A Class representing an ImmutabilityPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ImmutabilityPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetImmutabilityPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="BlobContainerResource" /> using the GetImmutabilityPolicy method.
    /// </summary>
    public partial class ImmutabilityPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ImmutabilityPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string containerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _immutabilityPolicyBlobContainersClientDiagnostics;
        private readonly BlobContainersRestOperations _immutabilityPolicyBlobContainersRestClient;
        private readonly ImmutabilityPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ImmutabilityPolicyResource"/> class for mocking. </summary>
        protected ImmutabilityPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ImmutabilityPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ImmutabilityPolicyResource(ArmClient client, ImmutabilityPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ImmutabilityPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ImmutabilityPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _immutabilityPolicyBlobContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string immutabilityPolicyBlobContainersApiVersion);
            _immutabilityPolicyBlobContainersRestClient = new BlobContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, immutabilityPolicyBlobContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/blobServices/containers/immutabilityPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ImmutabilityPolicyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the existing immutability policy along with the corresponding ETag in response headers and body.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/{immutabilityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_GetImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ImmutabilityPolicyResource>> GetAsync(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _immutabilityPolicyBlobContainersRestClient.GetImmutabilityPolicyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ImmutabilityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the existing immutability policy along with the corresponding ETag in response headers and body.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/{immutabilityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_GetImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ImmutabilityPolicyResource> Get(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _immutabilityPolicyBlobContainersRestClient.GetImmutabilityPolicy(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ImmutabilityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Aborts an unlocked immutability policy. The response of delete has immutabilityPeriodSinceCreationInDays set to 0. ETag in If-Match is required for this operation. Deleting a locked immutability policy is not allowed, the only way is to delete the container after deleting all expired blobs inside the policy locked container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/{immutabilityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_DeleteImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<ArmOperation<ImmutabilityPolicyResource>> DeleteAsync(WaitUntil waitUntil, string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = await _immutabilityPolicyBlobContainersRestClient.DeleteImmutabilityPolicyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<ImmutabilityPolicyResource>(Response.FromValue(new ImmutabilityPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Aborts an unlocked immutability policy. The response of delete has immutabilityPeriodSinceCreationInDays set to 0. ETag in If-Match is required for this operation. Deleting a locked immutability policy is not allowed, the only way is to delete the container after deleting all expired blobs inside the policy locked container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/{immutabilityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_DeleteImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual ArmOperation<ImmutabilityPolicyResource> Delete(WaitUntil waitUntil, string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = _immutabilityPolicyBlobContainersRestClient.DeleteImmutabilityPolicy(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, cancellationToken);
                var operation = new StorageArmOperation<ImmutabilityPolicyResource>(Response.FromValue(new ImmutabilityPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an unlocked immutability policy. ETag in If-Match is honored if given but not required for this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/{immutabilityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_CreateOrUpdateImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The ImmutabilityPolicy Properties that will be created or updated to a blob container. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ImmutabilityPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ImmutabilityPolicyData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _immutabilityPolicyBlobContainersRestClient.CreateOrUpdateImmutabilityPolicyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<ImmutabilityPolicyResource>(Response.FromValue(new ImmutabilityPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an unlocked immutability policy. ETag in If-Match is honored if given but not required for this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/{immutabilityPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_CreateOrUpdateImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The ImmutabilityPolicy Properties that will be created or updated to a blob container. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ImmutabilityPolicyResource> CreateOrUpdate(WaitUntil waitUntil, ImmutabilityPolicyData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _immutabilityPolicyBlobContainersRestClient.CreateOrUpdateImmutabilityPolicy(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, data, ifMatch, cancellationToken);
                var operation = new StorageArmOperation<ImmutabilityPolicyResource>(Response.FromValue(new ImmutabilityPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Sets the ImmutabilityPolicy to Locked state. The only action allowed on a Locked policy is ExtendImmutabilityPolicy action. ETag in If-Match is required for this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/default/lock</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_LockImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<Response<ImmutabilityPolicyResource>> LockImmutabilityPolicyAsync(string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.LockImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _immutabilityPolicyBlobContainersRestClient.LockImmutabilityPolicyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ImmutabilityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets the ImmutabilityPolicy to Locked state. The only action allowed on a Locked policy is ExtendImmutabilityPolicy action. ETag in If-Match is required for this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/default/lock</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_LockImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual Response<ImmutabilityPolicyResource> LockImmutabilityPolicy(string ifMatch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.LockImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _immutabilityPolicyBlobContainersRestClient.LockImmutabilityPolicy(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, cancellationToken);
                return Response.FromValue(new ImmutabilityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Extends the immutabilityPeriodSinceCreationInDays of a locked immutabilityPolicy. The only action allowed on a Locked policy will be this action. ETag in If-Match is required for this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/default/extend</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_ExtendImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="data"> The ImmutabilityPolicy Properties that will be extended for a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual async Task<Response<ImmutabilityPolicyResource>> ExtendImmutabilityPolicyAsync(string ifMatch, ImmutabilityPolicyData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.ExtendImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = await _immutabilityPolicyBlobContainersRestClient.ExtendImmutabilityPolicyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ImmutabilityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Extends the immutabilityPeriodSinceCreationInDays of a locked immutabilityPolicy. The only action allowed on a Locked policy will be this action. ETag in If-Match is required for this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/immutabilityPolicies/default/extend</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BlobContainers_ExtendImmutabilityPolicy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> The entity state (ETag) version of the immutability policy to update. A value of &quot;*&quot; can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied. </param>
        /// <param name="data"> The ImmutabilityPolicy Properties that will be extended for a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> is null. </exception>
        public virtual Response<ImmutabilityPolicyResource> ExtendImmutabilityPolicy(string ifMatch, ImmutabilityPolicyData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ifMatch, nameof(ifMatch));

            using var scope = _immutabilityPolicyBlobContainersClientDiagnostics.CreateScope("ImmutabilityPolicyResource.ExtendImmutabilityPolicy");
            scope.Start();
            try
            {
                var response = _immutabilityPolicyBlobContainersRestClient.ExtendImmutabilityPolicy(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, ifMatch, data, cancellationToken);
                return Response.FromValue(new ImmutabilityPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
