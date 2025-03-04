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

namespace SingleTopLevelClientWithOperations_LowLevel.Samples
{
    internal class Samples_Client4
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Patch()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new TopLevelClientWithOperationClient(credential).GetClient4("<clientParameter>");

            Response response = client.Patch("<filter>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Patch_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new TopLevelClientWithOperationClient(credential).GetClient4("<clientParameter>");

            Response response = client.Patch("<filter>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Patch_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new TopLevelClientWithOperationClient(credential).GetClient4("<clientParameter>");

            Response response = await client.PatchAsync("<filter>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Patch_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new TopLevelClientWithOperationClient(credential).GetClient4("<clientParameter>");

            Response response = await client.PatchAsync("<filter>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
