// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class DataCollectionRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DataCollectionEndpointId))
            {
                writer.WritePropertyName("dataCollectionEndpointId"u8);
                writer.WriteStringValue(DataCollectionEndpointId);
            }
            if (Optional.IsCollectionDefined(StreamDeclarations))
            {
                writer.WritePropertyName("streamDeclarations"u8);
                writer.WriteStartObject();
                foreach (var item in StreamDeclarations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DataSources))
            {
                writer.WritePropertyName("dataSources"u8);
                writer.WriteObjectValue(DataSources);
            }
            if (Optional.IsDefined(Destinations))
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteObjectValue(Destinations);
            }
            if (Optional.IsCollectionDefined(DataFlows))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataCollectionRuleData DeserializeDataCollectionRuleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataCollectionRuleResourceKind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> immutableId = default;
            Optional<ResourceIdentifier> dataCollectionEndpointId = default;
            Optional<DataCollectionRuleMetadata> metadata = default;
            Optional<IDictionary<string, DataStreamDeclaration>> streamDeclarations = default;
            Optional<DataCollectionRuleDataSources> dataSources = default;
            Optional<DataCollectionRuleDestinations> destinations = default;
            Optional<IList<DataFlow>> dataFlows = default;
            Optional<DataCollectionRuleProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new DataCollectionRuleResourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("immutableId"u8))
                        {
                            immutableId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataCollectionEndpointId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataCollectionEndpointId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = DataCollectionRuleMetadata.DeserializeDataCollectionRuleMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("streamDeclarations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, DataStreamDeclaration> dictionary = new Dictionary<string, DataStreamDeclaration>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, DataStreamDeclaration.DeserializeDataStreamDeclaration(property1.Value));
                            }
                            streamDeclarations = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("dataSources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSources = DataCollectionRuleDataSources.DeserializeDataCollectionRuleDataSources(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("destinations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            destinations = DataCollectionRuleDestinations.DeserializeDataCollectionRuleDestinations(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataFlows"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFlow> array = new List<DataFlow>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataFlow.DeserializeDataFlow(item));
                            }
                            dataFlows = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataCollectionRuleProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataCollectionRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(kind), identity, Optional.ToNullable(etag), description.Value, immutableId.Value, dataCollectionEndpointId.Value, metadata.Value, Optional.ToDictionary(streamDeclarations), dataSources.Value, destinations.Value, Optional.ToList(dataFlows), Optional.ToNullable(provisioningState));
        }
    }
}
