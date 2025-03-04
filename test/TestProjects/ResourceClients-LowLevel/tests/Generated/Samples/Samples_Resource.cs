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

namespace ResourceClients_LowLevel.Samples
{
    internal class Samples_Resource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetItem()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ResourceServiceClient(credential).GetResourceGroup("<groupId>").GetResource("<itemId>");

            Response response = client.GetItem();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetItem_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ResourceServiceClient(credential).GetResourceGroup("<groupId>").GetResource("<itemId>");

            Response response = client.GetItem(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetItem_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ResourceServiceClient(credential).GetResourceGroup("<groupId>").GetResource("<itemId>");

            Response response = await client.GetItemAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetItem_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ResourceServiceClient(credential).GetResourceGroup("<groupId>").GetResource("<itemId>");

            Response response = await client.GetItemAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
