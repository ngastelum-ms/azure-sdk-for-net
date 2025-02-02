// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Long Running Git Operation Results. </summary>
    public partial class OperationResultContract : ResourceData
    {
        /// <summary> Initializes a new instance of OperationResultContract. </summary>
        public OperationResultContract()
        {
            ActionLog = new ChangeTrackingList<OperationResultLogItemContract>();
        }

        /// <summary> Initializes a new instance of OperationResultContract. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="idPropertiesId"> Operation result identifier. </param>
        /// <param name="status"> Status of an async operation. </param>
        /// <param name="started">
        /// Start time of an async operation. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </param>
        /// <param name="updated">
        /// Last update time of an async operation. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </param>
        /// <param name="resultInfo"> Optional result info. </param>
        /// <param name="error"> Error Body Contract. </param>
        /// <param name="actionLog"> This property if only provided as part of the TenantConfiguration_Validate operation. It contains the log the entities which will be updated/created/deleted as part of the TenantConfiguration_Deploy operation. </param>
        internal OperationResultContract(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string idPropertiesId, AsyncOperationStatus? status, DateTimeOffset? started, DateTimeOffset? updated, string resultInfo, ErrorResponseBody error, IReadOnlyList<OperationResultLogItemContract> actionLog) : base(id, name, resourceType, systemData)
        {
            IdPropertiesId = idPropertiesId;
            Status = status;
            Started = started;
            Updated = updated;
            ResultInfo = resultInfo;
            Error = error;
            ActionLog = actionLog;
        }

        /// <summary> Operation result identifier. </summary>
        public string IdPropertiesId { get; set; }
        /// <summary> Status of an async operation. </summary>
        public AsyncOperationStatus? Status { get; set; }
        /// <summary>
        /// Start time of an async operation. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </summary>
        public DateTimeOffset? Started { get; set; }
        /// <summary>
        /// Last update time of an async operation. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// 
        /// </summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary> Optional result info. </summary>
        public string ResultInfo { get; set; }
        /// <summary> Error Body Contract. </summary>
        public ErrorResponseBody Error { get; set; }
        /// <summary> This property if only provided as part of the TenantConfiguration_Validate operation. It contains the log the entities which will be updated/created/deleted as part of the TenantConfiguration_Deploy operation. </summary>
        public IReadOnlyList<OperationResultLogItemContract> ActionLog { get; }
    }
}
