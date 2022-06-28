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

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="VolumeGroupDetailsResource" /> and their operations.
    /// Each <see cref="VolumeGroupDetailsResource" /> in the collection will belong to the same instance of <see cref="NetAppAccountResource" />.
    /// To get a <see cref="VolumeGroupDetailsCollection" /> instance call the GetVolumeGroupDetails method from an instance of <see cref="NetAppAccountResource" />.
    /// </summary>
    public partial class VolumeGroupDetailsCollection : ArmCollection
    {
        private readonly ClientDiagnostics _volumeGroupDetailsVolumeGroupsClientDiagnostics;
        private readonly VolumeGroupsRestOperations _volumeGroupDetailsVolumeGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VolumeGroupDetailsCollection"/> class for mocking. </summary>
        protected VolumeGroupDetailsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VolumeGroupDetailsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VolumeGroupDetailsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _volumeGroupDetailsVolumeGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", VolumeGroupDetailsResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VolumeGroupDetailsResource.ResourceType, out string volumeGroupDetailsVolumeGroupsApiVersion);
            _volumeGroupDetailsVolumeGroupsRestClient = new VolumeGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, volumeGroupDetailsVolumeGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a volume group along with specified volumes
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="details"> Volume Group object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> or <paramref name="details"/> is null. </exception>
        public virtual async Task<ArmOperation<VolumeGroupDetailsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeGroupName, VolumeGroupDetailsData details, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(details, nameof(details));

            using var scope = _volumeGroupDetailsVolumeGroupsClientDiagnostics.CreateScope("VolumeGroupDetailsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _volumeGroupDetailsVolumeGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, details, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<VolumeGroupDetailsResource>(new VolumeGroupDetailsOperationSource(Client), _volumeGroupDetailsVolumeGroupsClientDiagnostics, Pipeline, _volumeGroupDetailsVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, details).Request, response, OperationFinalStateVia.Location);
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
        /// Create a volume group along with specified volumes
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="details"> Volume Group object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> or <paramref name="details"/> is null. </exception>
        public virtual ArmOperation<VolumeGroupDetailsResource> CreateOrUpdate(WaitUntil waitUntil, string volumeGroupName, VolumeGroupDetailsData details, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(details, nameof(details));

            using var scope = _volumeGroupDetailsVolumeGroupsClientDiagnostics.CreateScope("VolumeGroupDetailsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _volumeGroupDetailsVolumeGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, details, cancellationToken);
                var operation = new NetAppArmOperation<VolumeGroupDetailsResource>(new VolumeGroupDetailsOperationSource(Client), _volumeGroupDetailsVolumeGroupsClientDiagnostics, Pipeline, _volumeGroupDetailsVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, details).Request, response, OperationFinalStateVia.Location);
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
        /// Get details of the specified volume group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<Response<VolumeGroupDetailsResource>> GetAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _volumeGroupDetailsVolumeGroupsClientDiagnostics.CreateScope("VolumeGroupDetailsCollection.Get");
            scope.Start();
            try
            {
                var response = await _volumeGroupDetailsVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VolumeGroupDetailsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified volume group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual Response<VolumeGroupDetailsResource> Get(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _volumeGroupDetailsVolumeGroupsClientDiagnostics.CreateScope("VolumeGroupDetailsCollection.Get");
            scope.Start();
            try
            {
                var response = _volumeGroupDetailsVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VolumeGroupDetailsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _volumeGroupDetailsVolumeGroupsClientDiagnostics.CreateScope("VolumeGroupDetailsCollection.Exists");
            scope.Start();
            try
            {
                var response = await _volumeGroupDetailsVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _volumeGroupDetailsVolumeGroupsClientDiagnostics.CreateScope("VolumeGroupDetailsCollection.Exists");
            scope.Start();
            try
            {
                var response = _volumeGroupDetailsVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
