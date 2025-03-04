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

namespace media_types_LowLevel.Samples
{
    public class Samples_MediaTypesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.AnalyzeBody(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.AnalyzeBody(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.AnalyzeBodyAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.AnalyzeBodyAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeBodyNoAcceptHeader()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.AnalyzeBodyNoAcceptHeader(RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeBodyNoAcceptHeader_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.AnalyzeBodyNoAcceptHeader(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeBodyNoAcceptHeader_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.AnalyzeBodyNoAcceptHeaderAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeBodyNoAcceptHeader_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.AnalyzeBodyNoAcceptHeaderAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ContentTypeWithEncoding()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = client.ContentTypeWithEncoding(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ContentTypeWithEncoding_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = client.ContentTypeWithEncoding(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ContentTypeWithEncoding_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = await client.ContentTypeWithEncodingAsync(RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ContentTypeWithEncoding_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = await client.ContentTypeWithEncodingAsync(RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BinaryBodyWithTwoContentTypes()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.BinaryBodyWithTwoContentTypes(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BinaryBodyWithTwoContentTypes_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.BinaryBodyWithTwoContentTypes(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BinaryBodyWithTwoContentTypes_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.BinaryBodyWithTwoContentTypesAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BinaryBodyWithTwoContentTypes_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.BinaryBodyWithTwoContentTypesAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BinaryBodyWithThreeContentTypes()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.BinaryBodyWithThreeContentTypes(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_BinaryBodyWithThreeContentTypes_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = client.BinaryBodyWithThreeContentTypes(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BinaryBodyWithThreeContentTypes_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.BinaryBodyWithThreeContentTypesAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_BinaryBodyWithThreeContentTypes_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = File.OpenRead("<filePath>");

            Response response = await client.BinaryBodyWithThreeContentTypesAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutTextAndJsonBody()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = client.PutTextAndJsonBody(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_PutTextAndJsonBody_AllParameters()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = client.PutTextAndJsonBody(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutTextAndJsonBody_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = await client.PutTextAndJsonBodyAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_PutTextAndJsonBody_AllParameters_Async()
        {
            var credential = new AzureKeyCredential("<key>");
            var client = new MediaTypesClient(credential);

            var data = "<String>";

            Response response = await client.PutTextAndJsonBodyAsync(RequestContent.Create(data), ContentType.ApplicationOctetStream, new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
