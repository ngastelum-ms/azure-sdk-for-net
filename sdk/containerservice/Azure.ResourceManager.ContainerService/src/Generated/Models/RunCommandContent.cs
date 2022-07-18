// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> A run command request. </summary>
    public partial class RunCommandContent
    {
        /// <summary> Initializes a new instance of RunCommandContent. </summary>
        /// <param name="command"> The command to run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="command"/> is null. </exception>
        public RunCommandContent(string command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            Command = command;
        }

        /// <summary> The command to run. </summary>
        public string Command { get; }
        /// <summary> A base64 encoded zip file containing the files required by the command. </summary>
        public string Context { get; set; }
        /// <summary> AuthToken issued for AKS AAD Server App. </summary>
        public string ClusterToken { get; set; }
    }
}
