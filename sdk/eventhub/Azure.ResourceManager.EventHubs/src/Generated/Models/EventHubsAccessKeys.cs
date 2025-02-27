// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Namespace/EventHub Connection String. </summary>
    public partial class EventHubsAccessKeys
    {
        /// <summary> Initializes a new instance of EventHubsAccessKeys. </summary>
        internal EventHubsAccessKeys()
        {
        }

        /// <summary> Initializes a new instance of EventHubsAccessKeys. </summary>
        /// <param name="primaryConnectionString"> Primary connection string of the created namespace AuthorizationRule. </param>
        /// <param name="secondaryConnectionString"> Secondary connection string of the created namespace AuthorizationRule. </param>
        /// <param name="aliasPrimaryConnectionString"> Primary connection string of the alias if GEO DR is enabled. </param>
        /// <param name="aliasSecondaryConnectionString"> Secondary  connection string of the alias if GEO DR is enabled. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the AuthorizationRule. </param>
        internal EventHubsAccessKeys(string primaryConnectionString, string secondaryConnectionString, string aliasPrimaryConnectionString, string aliasSecondaryConnectionString, string primaryKey, string secondaryKey, string keyName)
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            AliasPrimaryConnectionString = aliasPrimaryConnectionString;
            AliasSecondaryConnectionString = aliasSecondaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
        }

        /// <summary> Primary connection string of the created namespace AuthorizationRule. </summary>
        public string PrimaryConnectionString { get; }
        /// <summary> Secondary connection string of the created namespace AuthorizationRule. </summary>
        public string SecondaryConnectionString { get; }
        /// <summary> Primary connection string of the alias if GEO DR is enabled. </summary>
        public string AliasPrimaryConnectionString { get; }
        /// <summary> Secondary  connection string of the alias if GEO DR is enabled. </summary>
        public string AliasSecondaryConnectionString { get; }
        /// <summary> A base64-encoded 256-bit primary key for signing and validating the SAS token. </summary>
        public string PrimaryKey { get; }
        /// <summary> A base64-encoded 256-bit primary key for signing and validating the SAS token. </summary>
        public string SecondaryKey { get; }
        /// <summary> A string that describes the AuthorizationRule. </summary>
        public string KeyName { get; }
    }
}
