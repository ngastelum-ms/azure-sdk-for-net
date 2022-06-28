// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Source of key used to encrypt data in volume. Possible values (case-insensitive) are: &apos;Microsoft.NetApp&apos;. </summary>
    public readonly partial struct EncryptionKeySource : IEquatable<EncryptionKeySource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EncryptionKeySource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EncryptionKeySource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftNetAppValue = "Microsoft.NetApp";

        /// <summary> Microsoft-managed key encryption. </summary>
        public static EncryptionKeySource MicrosoftNetApp { get; } = new EncryptionKeySource(MicrosoftNetAppValue);
        /// <summary> Determines if two <see cref="EncryptionKeySource"/> values are the same. </summary>
        public static bool operator ==(EncryptionKeySource left, EncryptionKeySource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EncryptionKeySource"/> values are not the same. </summary>
        public static bool operator !=(EncryptionKeySource left, EncryptionKeySource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EncryptionKeySource"/>. </summary>
        public static implicit operator EncryptionKeySource(string value) => new EncryptionKeySource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncryptionKeySource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EncryptionKeySource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
