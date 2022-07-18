// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;). </summary>
    public readonly partial struct TlsVersion : IEquatable<TlsVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TlsVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TlsVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string One0Value = "1.0";
        private const string One1Value = "1.1";
        private const string One2Value = "1.2";

        /// <summary> 1.0. </summary>
        public static TlsVersion One0 { get; } = new TlsVersion(One0Value);
        /// <summary> 1.1. </summary>
        public static TlsVersion One1 { get; } = new TlsVersion(One1Value);
        /// <summary> 1.2. </summary>
        public static TlsVersion One2 { get; } = new TlsVersion(One2Value);
        /// <summary> Determines if two <see cref="TlsVersion"/> values are the same. </summary>
        public static bool operator ==(TlsVersion left, TlsVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TlsVersion"/> values are not the same. </summary>
        public static bool operator !=(TlsVersion left, TlsVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TlsVersion"/>. </summary>
        public static implicit operator TlsVersion(string value) => new TlsVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TlsVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TlsVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
