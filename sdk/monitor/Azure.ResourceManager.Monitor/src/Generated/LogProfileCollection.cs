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
    /// <summary> A class representing collection of LogProfile and their operations over its parent. </summary>
    public partial class LogProfileCollection : ArmCollection, IEnumerable<LogProfile>, IAsyncEnumerable<LogProfile>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LogProfilesRestOperations _logProfilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogProfileCollection"/> class for mocking. </summary>
        protected LogProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogProfileCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal LogProfileCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(LogProfile.ResourceType, out string apiVersion);
            _logProfilesRestClient = new LogProfilesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LogProfiles_CreateOrUpdate
        /// <summary> Create or update a log profile in Azure Monitoring REST API. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual LogProfileCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string logProfileName, LogProfileData parameters, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logProfilesRestClient.CreateOrUpdate(Id.SubscriptionId, logProfileName, parameters, cancellationToken);
                var operation = new LogProfileCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LogProfiles_CreateOrUpdate
        /// <summary> Create or update a log profile in Azure Monitoring REST API. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<LogProfileCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string logProfileName, LogProfileData parameters, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logProfilesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, logProfileName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new LogProfileCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LogProfiles_Get
        /// <summary> Gets the log profile. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual Response<LogProfile> Get(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _logProfilesRestClient.Get(Id.SubscriptionId, logProfileName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogProfile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LogProfiles_Get
        /// <summary> Gets the log profile. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public async virtual Task<Response<LogProfile>> GetAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _logProfilesRestClient.GetAsync(Id.SubscriptionId, logProfileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LogProfile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual Response<LogProfile> GetIfExists(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logProfilesRestClient.Get(Id.SubscriptionId, logProfileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<LogProfile>(null, response.GetRawResponse());
                return Response.FromValue(new LogProfile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public async virtual Task<Response<LogProfile>> GetIfExistsAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logProfilesRestClient.GetAsync(Id.SubscriptionId, logProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<LogProfile>(null, response.GetRawResponse());
                return Response.FromValue(new LogProfile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(logProfileName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            if (logProfileName == null)
            {
                throw new ArgumentNullException(nameof(logProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(logProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LogProfiles_List
        /// <summary> List the log profiles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogProfile" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogProfile> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LogProfile> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _logProfilesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LogProfile(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LogProfiles_List
        /// <summary> List the log profiles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogProfile" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogProfile> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LogProfile>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _logProfilesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LogProfile(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="LogProfile" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LogProfile.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="LogProfile" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LogProfileCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LogProfile.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogProfile> IEnumerable<LogProfile>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogProfile> IAsyncEnumerable<LogProfile>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, LogProfile, LogProfileData> Construct() { }
    }
}
