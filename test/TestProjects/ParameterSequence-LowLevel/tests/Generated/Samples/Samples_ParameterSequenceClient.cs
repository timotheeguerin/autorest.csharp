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

namespace ParameterSequence_LowLevel.Samples
{
    public class Samples_ParameterSequenceClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetItem()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = client.GetItem("<itemName>", "<origin>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetItem_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = client.GetItem("<itemName>", "<origin>", "<version>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetItem_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = await client.GetItemAsync("<itemName>", "<origin>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetItem_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = await client.GetItemAsync("<itemName>", "<origin>", "<version>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SelectItem()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = client.SelectItem("<itemName>", "<origin>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SelectItem_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = client.SelectItem("<itemName>", "<origin>", "<version>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SelectItem_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = await client.SelectItemAsync("<itemName>", "<origin>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SelectItem_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParameterSequenceClient(credential);

            Response response = await client.SelectItemAsync("<itemName>", "<origin>", "<version>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
