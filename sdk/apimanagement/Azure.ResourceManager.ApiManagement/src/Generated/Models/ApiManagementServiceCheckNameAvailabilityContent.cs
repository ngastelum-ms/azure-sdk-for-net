// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to the CheckNameAvailability operation. </summary>
    public partial class ApiManagementServiceCheckNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of ApiManagementServiceCheckNameAvailabilityContent. </summary>
        /// <param name="name"> The name to check for availability. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ApiManagementServiceCheckNameAvailabilityContent(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The name to check for availability. </summary>
        public string Name { get; }
    }
}
