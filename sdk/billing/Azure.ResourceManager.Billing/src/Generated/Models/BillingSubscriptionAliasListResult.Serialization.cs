// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    internal partial class BillingSubscriptionAliasListResult
    {
        internal static BillingSubscriptionAliasListResult DeserializeBillingSubscriptionAliasListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<BillingSubscriptionAliasData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingSubscriptionAliasData> array = new List<BillingSubscriptionAliasData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingSubscriptionAliasData.DeserializeBillingSubscriptionAliasData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BillingSubscriptionAliasListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
