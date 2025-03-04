// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> The format of the synonym map. Only the &apos;solr&apos; format is currently supported. </summary>
    public readonly partial struct SynonymMapFormat : IEquatable<SynonymMapFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynonymMapFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynonymMapFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SolrValue = "solr";

        /// <summary> solr. </summary>
        public static SynonymMapFormat Solr { get; } = new SynonymMapFormat(SolrValue);
        /// <summary> Determines if two <see cref="SynonymMapFormat"/> values are the same. </summary>
        public static bool operator ==(SynonymMapFormat left, SynonymMapFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynonymMapFormat"/> values are not the same. </summary>
        public static bool operator !=(SynonymMapFormat left, SynonymMapFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynonymMapFormat"/>. </summary>
        public static implicit operator SynonymMapFormat(string value) => new SynonymMapFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynonymMapFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynonymMapFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
