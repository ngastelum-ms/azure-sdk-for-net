// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Auto save settings. </summary>
    public readonly partial struct Autosave : IEquatable<Autosave>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Autosave"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Autosave(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string LocalValue = "Local";
        private const string RemoteValue = "Remote";

        /// <summary> None. </summary>
        public static Autosave None { get; } = new Autosave(NoneValue);
        /// <summary> Local. </summary>
        public static Autosave Local { get; } = new Autosave(LocalValue);
        /// <summary> Remote. </summary>
        public static Autosave Remote { get; } = new Autosave(RemoteValue);
        /// <summary> Determines if two <see cref="Autosave"/> values are the same. </summary>
        public static bool operator ==(Autosave left, Autosave right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Autosave"/> values are not the same. </summary>
        public static bool operator !=(Autosave left, Autosave right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Autosave"/>. </summary>
        public static implicit operator Autosave(string value) => new Autosave(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Autosave other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Autosave other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
