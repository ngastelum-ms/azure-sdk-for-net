// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal partial class CloudServicesUpdateDomainRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of CloudServicesUpdateDomainRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public CloudServicesUpdateDomainRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateWalkUpdateDomainRequest(string resourceGroupName, string cloudServiceName, string updateDomain, UpdateDomainData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/cloudServices/", false);
            uri.AppendPath(cloudServiceName, true);
            uri.AppendPath("/updateDomains/", false);
            uri.AppendPath(updateDomain, true);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (parameters != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(parameters);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Updates the role instances in the specified update domain. </summary>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="parameters"> The update domain object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="cloudServiceName"/>, or <paramref name="updateDomain"/> is null. </exception>
        public async Task<Response> WalkUpdateDomainAsync(string resourceGroupName, string cloudServiceName, string updateDomain, UpdateDomainData parameters = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }
            if (updateDomain == null)
            {
                throw new ArgumentNullException(nameof(updateDomain));
            }

            using var message = CreateWalkUpdateDomainRequest(resourceGroupName, cloudServiceName, updateDomain, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the role instances in the specified update domain. </summary>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="parameters"> The update domain object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="cloudServiceName"/>, or <paramref name="updateDomain"/> is null. </exception>
        public Response WalkUpdateDomain(string resourceGroupName, string cloudServiceName, string updateDomain, UpdateDomainData parameters = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }
            if (updateDomain == null)
            {
                throw new ArgumentNullException(nameof(updateDomain));
            }

            using var message = CreateWalkUpdateDomainRequest(resourceGroupName, cloudServiceName, updateDomain, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetUpdateDomainRequest(string resourceGroupName, string cloudServiceName, string updateDomain)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/cloudServices/", false);
            uri.AppendPath(cloudServiceName, true);
            uri.AppendPath("/updateDomains/", false);
            uri.AppendPath(updateDomain, true);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the specified update domain of a cloud service. Use nextLink property in the response to get the next page of update domains. Do this till nextLink is null to fetch all the update domains. </summary>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="cloudServiceName"/>, or <paramref name="updateDomain"/> is null. </exception>
        public async Task<Response<UpdateDomainData>> GetUpdateDomainAsync(string resourceGroupName, string cloudServiceName, string updateDomain, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }
            if (updateDomain == null)
            {
                throw new ArgumentNullException(nameof(updateDomain));
            }

            using var message = CreateGetUpdateDomainRequest(resourceGroupName, cloudServiceName, updateDomain);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = UpdateDomainData.DeserializeUpdateDomainData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified update domain of a cloud service. Use nextLink property in the response to get the next page of update domains. Do this till nextLink is null to fetch all the update domains. </summary>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="updateDomain"> Specifies an integer value that identifies the update domain. Update domains are identified with a zero-based index: the first update domain has an ID of 0, the second has an ID of 1, and so on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="cloudServiceName"/>, or <paramref name="updateDomain"/> is null. </exception>
        public Response<UpdateDomainData> GetUpdateDomain(string resourceGroupName, string cloudServiceName, string updateDomain, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }
            if (updateDomain == null)
            {
                throw new ArgumentNullException(nameof(updateDomain));
            }

            using var message = CreateGetUpdateDomainRequest(resourceGroupName, cloudServiceName, updateDomain);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = UpdateDomainData.DeserializeUpdateDomainData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListUpdateDomainsRequest(string resourceGroupName, string cloudServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/cloudServices/", false);
            uri.AppendPath(cloudServiceName, true);
            uri.AppendPath("/updateDomains", false);
            uri.AppendQuery("api-version", "2021-03-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response<UpdateDomainListResult>> ListUpdateDomainsAsync(string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsRequest(resourceGroupName, cloudServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="cloudServiceName"/> is null. </exception>
        public Response<UpdateDomainListResult> ListUpdateDomains(string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsRequest(resourceGroupName, cloudServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListUpdateDomainsNextPageRequest(string nextLink, string resourceGroupName, string cloudServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public async Task<Response<UpdateDomainListResult>> ListUpdateDomainsNextPageAsync(string nextLink, string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsNextPageRequest(nextLink, resourceGroupName, cloudServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all update domains in a cloud service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the resource group. </param>
        /// <param name="cloudServiceName"> Name of the cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="cloudServiceName"/> is null. </exception>
        public Response<UpdateDomainListResult> ListUpdateDomainsNextPage(string nextLink, string resourceGroupName, string cloudServiceName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (cloudServiceName == null)
            {
                throw new ArgumentNullException(nameof(cloudServiceName));
            }

            using var message = CreateListUpdateDomainsNextPageRequest(nextLink, resourceGroupName, cloudServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        UpdateDomainListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = UpdateDomainListResult.DeserializeUpdateDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
