// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Fluent.Storage
{

    using Microsoft.Azure.Management.Fluent.Resource.Core.CollectionActions;
    /// <summary>
    /// Entry point for storage resource usage management API.
    /// </summary>
    public interface IUsages  :
        ISupportsListing<Microsoft.Azure.Management.Fluent.Storage.IStorageUsage>
    {
    }
}