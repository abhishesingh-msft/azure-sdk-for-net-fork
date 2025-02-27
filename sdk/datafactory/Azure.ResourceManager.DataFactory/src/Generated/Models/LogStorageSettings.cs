// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> (Deprecated. Please use LogSettings) Log storage settings. </summary>
    public partial class LogStorageSettings
    {
        /// <summary> Initializes a new instance of LogStorageSettings. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public LogStorageSettings(DataFactoryLinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of LogStorageSettings. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <param name="path"> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </param>
        /// <param name="logLevel"> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </param>
        /// <param name="enableReliableLogging"> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LogStorageSettings(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> path, DataFactoryElement<string> logLevel, DataFactoryElement<bool> enableReliableLogging, IDictionary<string, BinaryData> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            LogLevel = logLevel;
            EnableReliableLogging = enableReliableLogging;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Log storage linked service reference. </summary>
        public DataFactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Path { get; set; }
        /// <summary> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> LogLevel { get; set; }
        /// <summary> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableReliableLogging { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
