// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The TransferCallResponse. </summary>
    public partial class TransferCallResponse
    {
        /// <summary> Initializes a new instance of TransferCallResponse. </summary>
        /// <param name="status"> The status of the operation. </param>
        internal TransferCallResponse(CallingOperationStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of TransferCallResponse. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        internal TransferCallResponse(string operationId, CallingOperationStatus status, string operationContext, CallingOperationResultDetails resultDetails)
        {
            OperationId = operationId;
            Status = status;
            OperationContext = operationContext;
            ResultDetails = resultDetails;
        }

        /// <summary> The operation id. </summary>
        public string OperationId { get; }
        /// <summary> The status of the operation. </summary>
        public CallingOperationStatus Status { get; }
        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
        /// <summary> The result info for the operation. </summary>
        public CallingOperationResultDetails ResultDetails { get; }
    }
}
