// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="NotificationHubResource" /> and their operations.
    /// Each <see cref="NotificationHubResource" /> in the collection will belong to the same instance of <see cref="NamespaceResource" />.
    /// To get a <see cref="NotificationHubResourceCollection" /> instance call the GetNotificationHubResources method from an instance of <see cref="NamespaceResource" />.
    /// </summary>
    public partial class NotificationHubResourceCollection : ArmCollection, IEnumerable<NotificationHubResource>, IAsyncEnumerable<NotificationHubResource>
    {
        private readonly ClientDiagnostics _notificationHubResourceNotificationHubsClientDiagnostics;
        private readonly NotificationHubsRestOperations _notificationHubResourceNotificationHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NotificationHubResourceCollection"/> class for mocking. </summary>
        protected NotificationHubResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NotificationHubResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NotificationHubResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _notificationHubResourceNotificationHubsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NotificationHubs", NotificationHubResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NotificationHubResource.ResourceType, out string notificationHubResourceNotificationHubsApiVersion);
            _notificationHubResourceNotificationHubsRestClient = new NotificationHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationHubResourceNotificationHubsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates/Update a NotificationHub in a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
        /// Operation Id: NotificationHubs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="notificationHubName"> The notification hub name. </param>
        /// <param name="content"> Parameters supplied to the create/update a NotificationHub Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<NotificationHubResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string notificationHubName, NotificationHubResourceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationHubName, nameof(notificationHubName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _notificationHubResourceNotificationHubsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationHubName, content, cancellationToken).ConfigureAwait(false);
                var operation = new NotificationHubsArmOperation<NotificationHubResource>(Response.FromValue(new NotificationHubResource(Client, response), response.GetRawResponse()));
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
        /// Creates/Update a NotificationHub in a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
        /// Operation Id: NotificationHubs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="notificationHubName"> The notification hub name. </param>
        /// <param name="content"> Parameters supplied to the create/update a NotificationHub Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<NotificationHubResource> CreateOrUpdate(WaitUntil waitUntil, string notificationHubName, NotificationHubResourceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationHubName, nameof(notificationHubName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _notificationHubResourceNotificationHubsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationHubName, content, cancellationToken);
                var operation = new NotificationHubsArmOperation<NotificationHubResource>(Response.FromValue(new NotificationHubResource(Client, response), response.GetRawResponse()));
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
        /// Lists the notification hubs associated with a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
        /// Operation Id: NotificationHubs_Get
        /// </summary>
        /// <param name="notificationHubName"> The notification hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubName"/> is null. </exception>
        public virtual async Task<Response<NotificationHubResource>> GetAsync(string notificationHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationHubName, nameof(notificationHubName));

            using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _notificationHubResourceNotificationHubsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationHubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
        /// Operation Id: NotificationHubs_Get
        /// </summary>
        /// <param name="notificationHubName"> The notification hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubName"/> is null. </exception>
        public virtual Response<NotificationHubResource> Get(string notificationHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationHubName, nameof(notificationHubName));

            using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _notificationHubResourceNotificationHubsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationHubName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs
        /// Operation Id: NotificationHubs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NotificationHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NotificationHubResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NotificationHubResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _notificationHubResourceNotificationHubsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationHubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NotificationHubResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _notificationHubResourceNotificationHubsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationHubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the notification hubs associated with a namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs
        /// Operation Id: NotificationHubs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NotificationHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NotificationHubResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NotificationHubResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _notificationHubResourceNotificationHubsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationHubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NotificationHubResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _notificationHubResourceNotificationHubsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationHubResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
        /// Operation Id: NotificationHubs_Get
        /// </summary>
        /// <param name="notificationHubName"> The notification hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string notificationHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationHubName, nameof(notificationHubName));

            using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _notificationHubResourceNotificationHubsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
        /// Operation Id: NotificationHubs_Get
        /// </summary>
        /// <param name="notificationHubName"> The notification hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="notificationHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationHubName"/> is null. </exception>
        public virtual Response<bool> Exists(string notificationHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(notificationHubName, nameof(notificationHubName));

            using var scope = _notificationHubResourceNotificationHubsClientDiagnostics.CreateScope("NotificationHubResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _notificationHubResourceNotificationHubsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, notificationHubName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NotificationHubResource> IEnumerable<NotificationHubResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NotificationHubResource> IAsyncEnumerable<NotificationHubResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
