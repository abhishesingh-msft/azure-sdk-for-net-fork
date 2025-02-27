// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Scanning.Samples
{
    public class Samples_PurviewClassificationRuleClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProperties()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = client.GetProperties(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetProperties_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = client.GetProperties(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProperties_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = await client.GetPropertiesAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetProperties_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = await client.GetPropertiesAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            var data = new
            {
                kind = "System",
            };

            Response response = client.CreateOrUpdate(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            var data = new
            {
                properties = new
                {
                    description = "<description>",
                    classificationName = "<classificationName>",
                    ruleStatus = "Enabled",
                },
                kind = "System",
            };

            Response response = client.CreateOrUpdate(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            var data = new
            {
                kind = "System",
            };

            Response response = await client.CreateOrUpdateAsync(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            var data = new
            {
                properties = new
                {
                    description = "<description>",
                    classificationName = "<classificationName>",
                    ruleStatus = "Enabled",
                },
                kind = "System",
            };

            Response response = await client.CreateOrUpdateAsync(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = client.Delete(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = client.Delete(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = await client.DeleteAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = await client.DeleteAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TagVersion()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = client.TagVersion(1234, "<action>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TagVersion_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = client.TagVersion(1234, "<action>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("scanResultId").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("details")[0].GetProperty("target").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TagVersion_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = await client.TagVersionAsync(1234, "<action>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TagVersion_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            Response response = await client.TagVersionAsync(1234, "<action>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("scanResultId").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("details")[0].GetProperty("target").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetVersions()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            foreach (var item in client.GetVersions(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetVersions_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            foreach (var item in client.GetVersions(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetVersions_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            await foreach (var item in client.GetVersionsAsync(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetVersions_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new PurviewClassificationRuleClient(endpoint, "<classificationRuleName>", credential);

            await foreach (var item in client.GetVersionsAsync(new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }
    }
}
