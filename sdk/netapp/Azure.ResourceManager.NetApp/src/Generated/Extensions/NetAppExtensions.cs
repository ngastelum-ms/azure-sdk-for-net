// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NetApp. </summary>
    public static partial class NetAppExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of SubscriptionQuotaItemResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <returns> An object representing collection of SubscriptionQuotaItemResources and their operations over a SubscriptionQuotaItemResource. </returns>
        public static SubscriptionQuotaItemCollection GetSubscriptionQuotaItems(this SubscriptionResource subscriptionResource, AzureLocation location)
        {
            return GetExtensionClient(subscriptionResource).GetSubscriptionQuotaItems(location);
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}
        /// Operation Id: NetAppResourceQuotaLimits_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaLimitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaLimitName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SubscriptionQuotaItemResource>> GetSubscriptionQuotaItemAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetSubscriptionQuotaItems(location).GetAsync(quotaLimitName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}
        /// Operation Id: NetAppResourceQuotaLimits_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaLimitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaLimitName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SubscriptionQuotaItemResource> GetSubscriptionQuotaItem(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetSubscriptionQuotaItems(location).Get(quotaLimitName, cancellationToken);
        }

        /// <summary>
        /// Check if a resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability
        /// Operation Id: NetAppResource_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckAvailabilityResponse>> CheckNameAvailabilityNetAppResourceAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ResourceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityNetAppResourceAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a resource name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability
        /// Operation Id: NetAppResource_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<CheckAvailabilityResponse> CheckNameAvailabilityNetAppResource(this SubscriptionResource subscriptionResource, AzureLocation location, ResourceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityNetAppResource(location, content, cancellationToken);
        }

        /// <summary>
        /// Check if a file path is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability
        /// Operation Id: NetAppResource_CheckFilePathAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckAvailabilityResponse>> CheckFilePathAvailabilityNetAppResourceAsync(this SubscriptionResource subscriptionResource, AzureLocation location, FilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckFilePathAvailabilityNetAppResourceAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a file path is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability
        /// Operation Id: NetAppResource_CheckFilePathAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<CheckAvailabilityResponse> CheckFilePathAvailabilityNetAppResource(this SubscriptionResource subscriptionResource, AzureLocation location, FilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckFilePathAvailabilityNetAppResource(location, content, cancellationToken);
        }

        /// <summary>
        /// Check if a quota is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability
        /// Operation Id: NetAppResource_CheckQuotaAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckAvailabilityResponse>> CheckQuotaAvailabilityNetAppResourceAsync(this SubscriptionResource subscriptionResource, AzureLocation location, QuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckQuotaAvailabilityNetAppResourceAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a quota is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability
        /// Operation Id: NetAppResource_CheckQuotaAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<CheckAvailabilityResponse> CheckQuotaAvailabilityNetAppResource(this SubscriptionResource subscriptionResource, AzureLocation location, QuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckQuotaAvailabilityNetAppResource(location, content, cancellationToken);
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NetAppAccountResource> GetNetAppAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetNetAppAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NetAppAccountResource> GetNetAppAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetNetAppAccounts(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of NetAppAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of NetAppAccountResources and their operations over a NetAppAccountResource. </returns>
        public static NetAppAccountCollection GetNetAppAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetNetAppAccounts();
        }

        /// <summary>
        /// Get the NetApp account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<NetAppAccountResource>> GetNetAppAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetNetAppAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the NetApp account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the NetApp account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<NetAppAccountResource> GetNetAppAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetNetAppAccounts().Get(accountName, cancellationToken);
        }

        #region SubscriptionQuotaItemResource
        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionQuotaItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionQuotaItemResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionQuotaItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionQuotaItemResource" /> object. </returns>
        public static SubscriptionQuotaItemResource GetSubscriptionQuotaItemResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SubscriptionQuotaItemResource.ValidateResourceId(id);
                return new SubscriptionQuotaItemResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppAccountResource.CreateResourceIdentifier" /> to create a <see cref="NetAppAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppAccountResource" /> object. </returns>
        public static NetAppAccountResource GetNetAppAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppAccountResource.ValidateResourceId(id);
                return new NetAppAccountResource(client, id);
            }
            );
        }
        #endregion

        #region CapacityPoolResource
        /// <summary>
        /// Gets an object representing a <see cref="CapacityPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CapacityPoolResource.CreateResourceIdentifier" /> to create a <see cref="CapacityPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CapacityPoolResource" /> object. </returns>
        public static CapacityPoolResource GetCapacityPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CapacityPoolResource.ValidateResourceId(id);
                return new CapacityPoolResource(client, id);
            }
            );
        }
        #endregion

        #region VolumeResource
        /// <summary>
        /// Gets an object representing a <see cref="VolumeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VolumeResource.CreateResourceIdentifier" /> to create a <see cref="VolumeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VolumeResource" /> object. </returns>
        public static VolumeResource GetVolumeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VolumeResource.ValidateResourceId(id);
                return new VolumeResource(client, id);
            }
            );
        }
        #endregion

        #region SnapshotResource
        /// <summary>
        /// Gets an object representing a <see cref="SnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SnapshotResource.CreateResourceIdentifier" /> to create a <see cref="SnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SnapshotResource" /> object. </returns>
        public static SnapshotResource GetSnapshotResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SnapshotResource.ValidateResourceId(id);
                return new SnapshotResource(client, id);
            }
            );
        }
        #endregion

        #region SnapshotPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="SnapshotPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SnapshotPolicyResource.CreateResourceIdentifier" /> to create a <see cref="SnapshotPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SnapshotPolicyResource" /> object. </returns>
        public static SnapshotPolicyResource GetSnapshotPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SnapshotPolicyResource.ValidateResourceId(id);
                return new SnapshotPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppAccountCapacityPoolVolumeBackupResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppAccountCapacityPoolVolumeBackupResource.CreateResourceIdentifier" /> to create a <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> object. </returns>
        public static NetAppAccountCapacityPoolVolumeBackupResource GetNetAppAccountCapacityPoolVolumeBackupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppAccountCapacityPoolVolumeBackupResource.ValidateResourceId(id);
                return new NetAppAccountCapacityPoolVolumeBackupResource(client, id);
            }
            );
        }
        #endregion

        #region NetAppAccountAccountBackupResource
        /// <summary>
        /// Gets an object representing a <see cref="NetAppAccountAccountBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetAppAccountAccountBackupResource.CreateResourceIdentifier" /> to create a <see cref="NetAppAccountAccountBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetAppAccountAccountBackupResource" /> object. </returns>
        public static NetAppAccountAccountBackupResource GetNetAppAccountAccountBackupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetAppAccountAccountBackupResource.ValidateResourceId(id);
                return new NetAppAccountAccountBackupResource(client, id);
            }
            );
        }
        #endregion

        #region BackupPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="BackupPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BackupPolicyResource.CreateResourceIdentifier" /> to create a <see cref="BackupPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BackupPolicyResource" /> object. </returns>
        public static BackupPolicyResource GetBackupPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BackupPolicyResource.ValidateResourceId(id);
                return new BackupPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region VolumeQuotaRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="VolumeQuotaRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VolumeQuotaRuleResource.CreateResourceIdentifier" /> to create a <see cref="VolumeQuotaRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VolumeQuotaRuleResource" /> object. </returns>
        public static VolumeQuotaRuleResource GetVolumeQuotaRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VolumeQuotaRuleResource.ValidateResourceId(id);
                return new VolumeQuotaRuleResource(client, id);
            }
            );
        }
        #endregion

        #region VolumeGroupDetailsResource
        /// <summary>
        /// Gets an object representing a <see cref="VolumeGroupDetailsResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VolumeGroupDetailsResource.CreateResourceIdentifier" /> to create a <see cref="VolumeGroupDetailsResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VolumeGroupDetailsResource" /> object. </returns>
        public static VolumeGroupDetailsResource GetVolumeGroupDetailsResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VolumeGroupDetailsResource.ValidateResourceId(id);
                return new VolumeGroupDetailsResource(client, id);
            }
            );
        }
        #endregion

        #region SubvolumeInfoResource
        /// <summary>
        /// Gets an object representing a <see cref="SubvolumeInfoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubvolumeInfoResource.CreateResourceIdentifier" /> to create a <see cref="SubvolumeInfoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubvolumeInfoResource" /> object. </returns>
        public static SubvolumeInfoResource GetSubvolumeInfoResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SubvolumeInfoResource.ValidateResourceId(id);
                return new SubvolumeInfoResource(client, id);
            }
            );
        }
        #endregion
    }
}
