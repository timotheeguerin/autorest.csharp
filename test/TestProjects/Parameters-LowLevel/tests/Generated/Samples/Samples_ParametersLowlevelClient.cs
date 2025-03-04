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

namespace Parameters_LowLevel.Samples
{
    public class Samples_ParametersLowlevelClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyResponseBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyResponseBody(1234);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyResponseBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyResponseBody(1234, 1234, 12, "start", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyResponseBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyResponseBodyAsync(1234);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyResponseBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyResponseBodyAsync(1234, 1234, 12, "start", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyResponseBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new { };

            Response response = client.RequestBodyResponseBody(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyResponseBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new
            {
                Code = "<Code>",
                Status = "<Status>",
            };

            Response response = client.RequestBodyResponseBody(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("Code").ToString());
            Console.WriteLine(result.GetProperty("Status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyResponseBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new { };

            Response response = await client.RequestBodyResponseBodyAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyResponseBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new
            {
                Code = "<Code>",
                Status = "<Status>",
            };

            Response response = await client.RequestBodyResponseBodyAsync(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("Code").ToString());
            Console.WriteLine(result.GetProperty("Status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteNoRequestBodyResponseBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.DeleteNoRequestBodyResponseBody("<resourceName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteNoRequestBodyResponseBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.DeleteNoRequestBodyResponseBody("<resourceName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteNoRequestBodyResponseBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.DeleteNoRequestBodyResponseBodyAsync("<resourceName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteNoRequestBodyResponseBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.DeleteNoRequestBodyResponseBodyAsync("<resourceName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyNoResponseBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyNoResponseBody();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyNoResponseBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyNoResponseBody(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyNoResponseBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyNoResponseBodyAsync();
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyNoResponseBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyNoResponseBodyAsync(new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyNoResponseBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = "<String>";

            Response response = client.RequestBodyNoResponseBody(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyNoResponseBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = "<String>";

            Response response = client.RequestBodyNoResponseBody(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyNoResponseBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = "<String>";

            Response response = await client.RequestBodyNoResponseBodyAsync(RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyNoResponseBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = "<String>";

            Response response = await client.RequestBodyNoResponseBodyAsync(RequestContent.Create(data), new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParameters(1234, 1234);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParameters_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParameters(1234, 1234, "start", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersAsync(1234, 1234);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParameters_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersAsync(1234, 1234, "start", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParametersWithMixedSequence()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParametersWithMixedSequence(1234);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParametersWithMixedSequence_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParametersWithMixedSequence(1234, "start", 12, new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParametersWithMixedSequence_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersWithMixedSequenceAsync(1234);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParametersWithMixedSequence_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersWithMixedSequenceAsync(1234, "start", 12, new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathBodyParametersWithMixedSequence()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new { };

            Response response = client.OptionalPathBodyParametersWithMixedSequence("<name>", 1234, RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathBodyParametersWithMixedSequence_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new
            {
                Code = "<Code>",
                Status = "<Status>",
            };

            Response response = client.OptionalPathBodyParametersWithMixedSequence("<name>", 1234, RequestContent.Create(data), 123, 1234, 50, new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathBodyParametersWithMixedSequence_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new { };

            Response response = await client.OptionalPathBodyParametersWithMixedSequenceAsync("<name>", 1234, RequestContent.Create(data));
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathBodyParametersWithMixedSequence_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new ParametersLowlevelClient(credential);

            var data = new
            {
                Code = "<Code>",
                Status = "<Status>",
            };

            Response response = await client.OptionalPathBodyParametersWithMixedSequenceAsync("<name>", 1234, RequestContent.Create(data), 123, 1234, 50, new RequestContext());
            Console.WriteLine(response.Status);
        }
    }
}
