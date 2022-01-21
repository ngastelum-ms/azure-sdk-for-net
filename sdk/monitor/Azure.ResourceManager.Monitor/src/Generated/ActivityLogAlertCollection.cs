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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of ActivityLogAlert and their operations over its parent. </summary>
    public partial class ActivityLogAlertCollection : ArmCollection, IEnumerable<ActivityLogAlert>, IAsyncEnumerable<ActivityLogAlert>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ActivityLogAlertsRestOperations _activityLogAlertsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ActivityLogAlertCollection"/> class for mocking. </summary>
        protected ActivityLogAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ActivityLogAlertCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ActivityLogAlertCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ActivityLogAlert.ResourceType, out string apiVersion);
            _activityLogAlertsRestClient = new ActivityLogAlertsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/activityLogAlerts/{activityLogAlertName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ActivityLogAlerts_CreateOrUpdate
        /// <summary> Create a new activity log alert or update an existing one. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="activityLogAlert"> The activity log alert to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> or <paramref name="activityLogAlert"/> is null. </exception>
        public virtual ActivityLogAlertCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string activityLogAlertName, ActivityLogAlertData activityLogAlert, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }
            if (activityLogAlert == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlert));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _activityLogAlertsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, activityLogAlert, cancellationToken);
                var operation = new ActivityLogAlertCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/activityLogAlerts/{activityLogAlertName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ActivityLogAlerts_CreateOrUpdate
        /// <summary> Create a new activity log alert or update an existing one. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="activityLogAlert"> The activity log alert to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> or <paramref name="activityLogAlert"/> is null. </exception>
        public async virtual Task<ActivityLogAlertCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string activityLogAlertName, ActivityLogAlertData activityLogAlert, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }
            if (activityLogAlert == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlert));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _activityLogAlertsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, activityLogAlert, cancellationToken).ConfigureAwait(false);
                var operation = new ActivityLogAlertCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/activityLogAlerts/{activityLogAlertName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ActivityLogAlerts_Get
        /// <summary> Get an activity log alert. </summary>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual Response<ActivityLogAlert> Get(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _activityLogAlertsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlert(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/activityLogAlerts/{activityLogAlertName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ActivityLogAlerts_Get
        /// <summary> Get an activity log alert. </summary>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public async virtual Task<Response<ActivityLogAlert>> GetAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _activityLogAlertsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ActivityLogAlert(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual Response<ActivityLogAlert> GetIfExists(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _activityLogAlertsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ActivityLogAlert>(null, response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlert(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public async virtual Task<Response<ActivityLogAlert>> GetIfExistsAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _activityLogAlertsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, activityLogAlertName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ActivityLogAlert>(null, response.GetRawResponse());
                return Response.FromValue(new ActivityLogAlert(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public virtual Response<bool> Exists(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(activityLogAlertName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityLogAlertName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(activityLogAlertName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/activityLogAlerts
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ActivityLogAlerts_ListByResourceGroup
        /// <summary> Get a list of all activity log alerts in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ActivityLogAlert" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ActivityLogAlert> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ActivityLogAlert> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _activityLogAlertsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ActivityLogAlert(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/activityLogAlerts
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ActivityLogAlerts_ListByResourceGroup
        /// <summary> Get a list of all activity log alerts in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ActivityLogAlert" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ActivityLogAlert> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ActivityLogAlert>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _activityLogAlertsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ActivityLogAlert(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="ActivityLogAlert" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ActivityLogAlert.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ActivityLogAlert" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ActivityLogAlertCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ActivityLogAlert.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ActivityLogAlert> IEnumerable<ActivityLogAlert>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ActivityLogAlert> IAsyncEnumerable<ActivityLogAlert>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ActivityLogAlert, ActivityLogAlertData> Construct() { }
    }
}
