// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Error response. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error details. </param>
        internal ErrorResponse(ErrorDefinition error)
        {
            Error = error;
        }

        /// <summary> The error details. </summary>
        public ErrorDefinition Error { get; }
    }
}
