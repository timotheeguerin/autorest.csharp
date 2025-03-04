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

namespace PaginationParams_LowLevel.Samples
{
    public class Samples_PaginationParamsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPaginationParams()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.GetPaginationParams())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetPaginationParams_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.GetPaginationParams(1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPaginationParams_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.GetPaginationParamsAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetPaginationParams_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.GetPaginationParamsAsync(1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get2s()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.Get2s())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get2s_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.Get2s(1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get2s_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.Get2sAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get2s_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.Get2sAsync(1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get3s()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.Get3s())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get3s_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.Get3s(1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get3s_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.Get3sAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get3s_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.Get3sAsync(1234, 1234, 1234, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get4s()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.Get4s())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Get4s_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            foreach (var item in client.Get4s(1234, 1234, 3.14f, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get4s_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.Get4sAsync())
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Get4s_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new PaginationParamsClient(credential);

            await foreach (var item in client.Get4sAsync(1234, 1234, 3.14f, new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }
    }
}
