﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Fluent.Resource.Core.CollectionActions;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace Microsoft.Azure.Management.Fluent.Resource.Core
{
    public abstract class GroupableResources<IFluentResourceT, FluentResourceT, InnerResourceT, InnerCollectionT, ManagerT> :
        CreatableResources<IFluentResourceT, FluentResourceT, InnerResourceT>,
        ISupportsGettingByGroup<IFluentResourceT>,
        ISupportsGettingById<IFluentResourceT>
        where IFluentResourceT : class, IGroupableResource
        where FluentResourceT : IFluentResourceT
        where ManagerT : IManagerBase
    {
        protected GroupableResources(InnerCollectionT innerCollection, ManagerT manager)
        {
            InnerCollection = innerCollection;
            Manager = manager;
        }

        protected InnerCollectionT InnerCollection { get; }

        protected ManagerT Manager { get; }

        #region Implementation of ISupportsGettingByGroup interface

        public abstract Task<IFluentResourceT> GetByGroupAsync(string groupName, string name);

        public IFluentResourceT GetByGroup(string groupName, string name)
        {
            return GetByGroupAsync(groupName, name).Result;
        }

        #endregion

        #region Implementation of ISupportsGettingById interface

        public async Task<IFluentResourceT> GetByIdAsync(string id)
        {
            return await GetByGroupAsync(
                    ResourceUtils.GroupFromResourceId(id),
                    ResourceUtils.NameFromResourceId(id)
                );
        }

        public IFluentResourceT GetById(string id)
        {
            return GetByIdAsync(id).Result;
        }

        public Task<IFluentResourceT> GetByIdAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<IFluentResourceT> GetByGroupAsync(string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
