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

namespace ServiceVersionOverride.Samples
{
    public class Samples_ServiceVersionOverrideClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Operation()
        {
            var client = new ServiceVersionOverrideClient();

            Response response = client.Operation("<notApiVersionEnum>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Operation_AllParameters()
        {
            var client = new ServiceVersionOverrideClient();

            Response response = client.Operation("<notApiVersionEnum>", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Operation_Async()
        {
            var client = new ServiceVersionOverrideClient();

            Response response = await client.OperationAsync("<notApiVersionEnum>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Operation_AllParameters_Async()
        {
            var client = new ServiceVersionOverrideClient();

            Response response = await client.OperationAsync("<notApiVersionEnum>", new RequestContext());
            Console.WriteLine(response.Status);
        }
    }
}
