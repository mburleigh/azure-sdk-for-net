// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Configures the groups claim issued in a user or OAuth 2.0 access token that the app expects. </summary>
    public readonly partial struct GroupMembershipClaimTypes : IEquatable<GroupMembershipClaimTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="GroupMembershipClaimTypes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GroupMembershipClaimTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SecurityGroupValue = "SecurityGroup";
        private const string AllValue = "All";

        /// <summary> None. </summary>
        public static GroupMembershipClaimTypes None { get; } = new GroupMembershipClaimTypes(NoneValue);
        /// <summary> SecurityGroup. </summary>
        public static GroupMembershipClaimTypes SecurityGroup { get; } = new GroupMembershipClaimTypes(SecurityGroupValue);
        /// <summary> All. </summary>
        public static GroupMembershipClaimTypes All { get; } = new GroupMembershipClaimTypes(AllValue);
        /// <summary> Determines if two <see cref="GroupMembershipClaimTypes"/> values are the same. </summary>
        public static bool operator ==(GroupMembershipClaimTypes left, GroupMembershipClaimTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GroupMembershipClaimTypes"/> values are not the same. </summary>
        public static bool operator !=(GroupMembershipClaimTypes left, GroupMembershipClaimTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GroupMembershipClaimTypes"/>. </summary>
        public static implicit operator GroupMembershipClaimTypes(string value) => new GroupMembershipClaimTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GroupMembershipClaimTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GroupMembershipClaimTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
