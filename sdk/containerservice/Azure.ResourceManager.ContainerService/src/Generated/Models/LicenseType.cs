// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The license type to use for Windows VMs. See [Azure Hybrid User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details. </summary>
    public readonly partial struct LicenseType : IEquatable<LicenseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LicenseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LicenseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string WindowsServerValue = "Windows_Server";

        /// <summary> No additional licensing is applied. </summary>
        public static LicenseType None { get; } = new LicenseType(NoneValue);
        /// <summary> Enables Azure Hybrid User Benefits for Windows VMs. </summary>
        public static LicenseType WindowsServer { get; } = new LicenseType(WindowsServerValue);
        /// <summary> Determines if two <see cref="LicenseType"/> values are the same. </summary>
        public static bool operator ==(LicenseType left, LicenseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LicenseType"/> values are not the same. </summary>
        public static bool operator !=(LicenseType left, LicenseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LicenseType"/>. </summary>
        public static implicit operator LicenseType(string value) => new LicenseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LicenseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LicenseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
