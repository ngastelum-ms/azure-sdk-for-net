// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation webhook.  (see
    /// http://aka.ms/azureautomationsdk/webhookoperations for more
    /// information)
    /// </summary>
    public partial interface IWebhookOperations
    {
        /// <summary>
        /// Create the webhook identified by webhook name.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The create or update parameters for webhook.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create or update webhook operation.
        /// </returns>
        Task<WebhookCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string automationAccount, WebhookCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the webhook by name.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='webhookName'>
        /// The webhook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string automationAccount, string webhookName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the generate uri of the webhook.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the generate uri operation.
        /// </returns>
        Task<WebhookGenerateUriResponse> GenerateUriAsync(string resourceGroupName, string automationAccount, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the webhook identified by webhook name.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='webhookName'>
        /// The webhook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get webhook operation.
        /// </returns>
        Task<WebhookGetResponse> GetAsync(string resourceGroupName, string automationAccount, string webhookName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of webhooks.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The automation runbook name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list webhook operation.
        /// </returns>
        Task<WebhookListResponse> ListAsync(string resourceGroupName, string automationAccount, string runbookName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve next list of webhooks.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='nextLink'>
        /// The link to retrieve next set of items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list webhook operation.
        /// </returns>
        Task<WebhookListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Patch the webhook identified by webhook name.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The patch parameters for webhook.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get webhook operation.
        /// </returns>
        Task<WebhookGetResponse> PatchAsync(string resourceGroupName, string automationAccount, WebhookPatchParameters parameters, CancellationToken cancellationToken);
    }
}
