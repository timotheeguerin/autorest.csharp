﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using Azure.Core;
using NUnit.Framework;
using paging_LowLevel;
using CustomPagingClient = custom_baseUrl_paging_LowLevel.PagingClient;

namespace AutoRest.TestServer.Tests
{
    public class PagingTests : TestServerLowLevelTestBase
    {
        [Test]
        public Task PagingCustomUrlPartialNextLink() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "Product";

            // host is not a full hostname for CustomPagingOperations; it is a partial host
            var host = endpoint.ToString().Replace("http://", String.Empty);
            var linkPart = "/paging/customurl/partialnextlink/page/";

            var pageableAsync = new CustomPagingClient(Key, host, null).GetPagesPartialUrlAsync(string.Empty, new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
            }
            Assert.AreEqual(2, id);

            id = 1;
            var pageable = new CustomPagingClient(Key, host, null).GetPagesPartialUrl(string.Empty, new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
            }
            Assert.AreEqual(2, id);
        });

        [Test]
        public Task PagingCustomUrlPartialOperationNextLink() => Test(async (endpoint) =>
        {
            var id = 1;
            var accountName = "";
            var product = "Product";
            // host is not a full hostname for CustomPagingOperations; it is a partial host
            var host = endpoint.ToString().Replace("http://", String.Empty);
            var linkPart = "partialnextlinkop/page/";

            var pageableAsync = new CustomPagingClient(Key, host, null).GetPagesPartialUrlOperationAsync(accountName, new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
            }
            Assert.AreEqual(2, id);

            id = 1;
            var pageable = new CustomPagingClient(Key, host, null).GetPagesPartialUrlOperation(accountName, new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
            }
            Assert.AreEqual(2, id);
        });


        [Test]
        public Task PagingFragment() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "product";
            var tenant = "test_user";
            var linkPart = "next?page=";

            id = 1;
            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesFragmentNextLinkAsync(tenant, "1.6", new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);

            id = 1;
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePagesFragmentNextLink(tenant, "1.6", new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);
        });

        [Test]
        public Task PagingMultiple_Continuation() => Test(async (endpoint) =>
        {
            var client = new PagingClient(Key, endpoint, null);
            var pages = client.GetMultiplePages().AsPages().ToArray();

            for (int i = 1; i < pages.Length; i++)
            {
                var expectedPages = pages.Skip(i).ToArray();
                var actualPages = client.GetMultiplePages().AsPages(pages[i - 1].ContinuationToken).ToArray();

                Assert.That(expectedPages, Is.EquivalentTo(actualPages).Using<Page<BinaryData>>((p1, p2) =>
                    p1.Values.Count == p2.Values.Count && p1.ContinuationToken == p2.ContinuationToken));
            }

            for (int i = 1; i < pages.Length; i++)
            {
                var expectedPages = pages.Skip(i).ToArray();
                var actualPages = new List<Page<BinaryData>>();
                await foreach (var page in client.GetMultiplePagesAsync().AsPages(pages[i - 1].ContinuationToken))
                {
                    actualPages.Add(page);
                }

                Assert.That(expectedPages, Is.EquivalentTo(actualPages).Using<Page<BinaryData>>((p1, p2) =>
                    p1.Values.Count == p2.Values.Count && p1.ContinuationToken == p2.ContinuationToken));
            }
        }, ignoreScenario: true);

        [Test]
        public Task PagingMultiple() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/page/";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesAsync(null, null);
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);

            id = 1;
            product = "Product";
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePages(null, null);
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);
        });

        [Ignore("Example")]
        [Test]
        public Task PagingMultipleExample() => Test(async (endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesAsync(null, null);
            int id = 1;
            await foreach (var data in pageableAsync)
            {
                JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
                Assert.AreEqual(id, result.GetProperty("properties").GetProperty("id").GetInt32());
                Assert.IsTrue("product".Equals(result.GetProperty("properties").GetProperty("name").GetString(), StringComparison.OrdinalIgnoreCase));
                id++;
            }

            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePages(null, null);
            id = 1;
            foreach (var data in pageable)
            {
                JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
                Assert.AreEqual(id, result.GetProperty("properties").GetProperty("id").GetInt32());
                Assert.IsTrue("product".Equals(result.GetProperty("properties").GetProperty("name").GetString(), StringComparison.OrdinalIgnoreCase));
                id++;
            }
        });

        [Test]
        public Task PagingMultipleWithQueryParameters() => Test(async (endpoint) =>
        {
            var value = 100;
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/nextOperationWithQueryParams";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetWithQueryParamsAsync(value, new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith(linkPart, page.ContinuationToken);
                    id++;
                }
            }
            Assert.AreEqual(2, id);

            id = 1;
            var pageable = new PagingClient(Key, endpoint, null).GetWithQueryParams(value, new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith(linkPart, page.ContinuationToken);
                    id++;
                }
            }
            Assert.AreEqual(2, id);
        });

        [Test]
        public Task PagingMultipleFailure() => Test((endpoint) =>
        {
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/failure/page/";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesFailureAsync(new());
            Assert.ThrowsAsync<RequestFailedException>(async () =>
            {
                await foreach (var page in pageableAsync.AsPages())
                {
                    Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                    Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
            });
            Assert.AreEqual(2, id);

            id = 1;
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePagesFailure(new());
            Assert.Throws<RequestFailedException>(() =>
            {
                foreach (var page in pageable.AsPages())
                {
                    Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                    Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
            });
            Assert.AreEqual(2, id);
        });

        [Test]
        public Task PagingMultipleFailureUri() => Test((endpoint) =>
        {
            var id = 1;
            var product = "Product";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesFailureUriAsync(new());
            Assert.ThrowsAsync<RequestFailedException>(async () =>
            {
                await foreach (var page in pageableAsync.AsPages())
                {
                    Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                    Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                    Assert.AreEqual("*&*#&$", page.ContinuationToken);
                    id++;
                }
            });
            Assert.AreEqual(2, id);

            id = 1;
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePagesFailureUri(new());
            Assert.Throws<RequestFailedException>(() =>
            {
                foreach (var page in pageable.AsPages())
                {
                    Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                    Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                    Assert.AreEqual("*&*#&$", page.ContinuationToken);
                    id++;
                }
            });
            Assert.AreEqual(2, id);
        });

        [Test]
        public Task PagingMultipleLRO() => Test(async (endpoint) =>
        {
            var lro = await new PagingClient(Key, endpoint, null).GetMultiplePagesLROAsync(WaitUntil.Started, "id");

            AsyncPageable<BinaryData> pageable = await lro.WaitForCompletionAsync();

            var product = "Product";
            int id = 1;
            await foreach (var item in pageable)
            {
                Assert.AreEqual(id, item.ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, item.ToObjectFromJson<Product>().Properties.Name);

                if (product == "Product")
                {
                    product = "product";
                }
                id += 1;
            }
        });

        [Ignore("Example")]
        [Test]
        public Task PagingMultipleLROExample() => Test((endpoint) =>
        {
            var lro = new PagingClient(Key, endpoint, null).GetMultiplePagesLRO(WaitUntil.Started, "id");

            var response = lro.WaitForCompletion();
            int id = 1;
            foreach (var data in response.Value)
            {
                JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
                Assert.AreEqual(id, result.GetProperty("properties").GetProperty("id").GetInt32());
                Assert.IsTrue("product".Equals(result.GetProperty("properties").GetProperty("name").GetString(), StringComparison.OrdinalIgnoreCase));
                id++;
            }
        });

        [Test]
        public Task PagingMultiplePath() => Test(async (endpoint) =>
        {
            var id = 1;
            var pageNumber = 1;
            var product = "Product";
            var offset = 100;
            var linkPart = $"/paging/multiple/withpath/page/{offset}/";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesWithOffsetAsync(offset);
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (pageNumber == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++pageNumber}", page.ContinuationToken);
                }
                if (product == "Product")
                {
                    id += offset;
                    product = "product";
                }

                id++;
            }
            Assert.AreEqual(10, pageNumber);

            id = 1;
            pageNumber = 1;
            product = "Product";
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePagesWithOffset(offset);
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (pageNumber == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++pageNumber}", page.ContinuationToken);
                }
                if (product == "Product")
                {
                    id += offset;
                    product = "product";
                }

                id++;
            }
            Assert.AreEqual(10, pageNumber);
        });

        [Test]
        public Task PagingMultipleRetryFirst() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/page/";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesRetryFirstAsync(new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);

            id = 1;
            product = "Product";
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePagesRetryFirst(new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);
        });

        [Test]
        public Task PagingMultipleRetrySecond() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/retrysecond/page/";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetMultiplePagesRetrySecondAsync(new());
            await foreach (var page in pageableAsync.AsPages())
            {
                var tempId = id == 2 ? 1 : id;
                Assert.AreEqual(tempId, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                var tempProduct = id == 2 ? "Product" : product;
                Assert.AreEqual(tempProduct, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);

            id = 1;
            product = "Product";
            var pageable = new PagingClient(Key, endpoint, null).GetMultiplePagesRetrySecond(new());
            foreach (var page in pageable.AsPages())
            {
                var tempId = id == 2 ? 1 : id;
                Assert.AreEqual(tempId, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                var tempProduct = id == 2 ? "Product" : product;
                Assert.AreEqual(tempProduct, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);
        });

        [Test]
        public Task PagingNextLinkNameNull() => Test(async (endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null).GetNullNextLinkNamePagesAsync(new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
            }

            var pageable = new PagingClient(Key, endpoint, null).GetNullNextLinkNamePages(new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
            }
        });

        [Test]
        public Task PagingNoItemName() => Test(async (endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null).GetNoItemNamePagesAsync(new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                Assert.IsNull(page.ContinuationToken);
            }

            var pageable = new PagingClient(Key, endpoint, null).GetNoItemNamePages(new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                Assert.IsNull(page.ContinuationToken);
            }
        });

        [Test]
        public Task PagingReturnModelWithXMSClientName() => Test(async (endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null).GetPagingModelWithItemNameWithXMSClientNameAsync(new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                Assert.IsNull(page.ContinuationToken);
            }

            var pageable = new PagingClient(Key, endpoint, null).GetPagingModelWithItemNameWithXMSClientName(new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                Assert.IsNull(page.ContinuationToken);
            }
        });

        [Test]
        public Task PagingOdataMultiple() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/odata/page/";

            var pageableAsync = new PagingClient(Key, endpoint, null).GetOdataMultiplePagesAsync(null, null);
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);

            id = 1;
            product = "Product";
            var pageable = new PagingClient(Key, endpoint, null).GetOdataMultiplePages(null, null);
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(id, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual(product, page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                if (id == 10)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    StringAssert.EndsWith($"{linkPart}{++id}", page.ContinuationToken);
                }
                product = "product";
            }
            Assert.AreEqual(10, id);
        });

        [Test]
        public Task PagingSingle() => Test(async (endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null).GetSinglePagesAsync(new());
            await foreach (var page in pageableAsync.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                Assert.IsNull(page.ContinuationToken);
            }

            var pageable = new PagingClient(Key, endpoint, null).GetSinglePages(new());
            foreach (var page in pageable.AsPages())
            {
                Assert.AreEqual(1, page.Values.First().ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", page.Values.First().ToObjectFromJson<Product>().Properties.Name);
                Assert.IsNull(page.ContinuationToken);
            }
        });

        [Ignore("Example")]
        [Test]
        public Task PagingSingleExample() => Test(async (endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null);
            await foreach (var data in pageableAsync.GetSinglePagesAsync())
            {
                JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
                Assert.AreEqual(1, result.GetProperty("properties").GetProperty("id").GetInt32());
                Assert.AreEqual("Product", result.GetProperty("properties").GetProperty("name"));
            }

            var pageable = new PagingClient(Key, endpoint, null);
            foreach (var data in pageable.GetSinglePages())
            {
                JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
                Assert.AreEqual(1, result.GetProperty("properties").GetProperty("id").GetInt32());
                Assert.AreEqual("Product", result.GetProperty("properties").GetProperty("name"));
            }
        });

        [Test]
        public Task PagingSingleFailure() => Test((endpoint) =>
        {
            var pageableAsync = new PagingClient(Key, endpoint, null).GetSinglePagesFailureAsync(new());
            Assert.ThrowsAsync<RequestFailedException>(async () => { await foreach (var page in pageableAsync.AsPages()) { } });

            var pageable = new PagingClient(Key, endpoint, null).GetSinglePagesFailure(new());
            Assert.Throws<RequestFailedException>(() => { foreach (var page in pageable.AsPages()) { } });
        });

        [Test]
        public Task PagingDuplicateParameters() => Test(async (endpoint) =>
        {
            var id = 1;
            var product = "Product";
            var linkPart = "/paging/multiple/duplicateParams/2?%24filter=serviceReturned&%24skiptoken=bar";

            var pageableAsync = new PagingClient(Key, endpoint, null).DuplicateParamsAsync("foo");
            await foreach (var page in pageableAsync.AsPages())
            {
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    Assert.AreEqual(id, page.Values.Single().ToObjectFromJson<Product>().Properties.Id);
                    Assert.AreEqual(product, page.Values.Single().ToObjectFromJson<Product>().Properties.Name);
                    StringAssert.EndsWith(linkPart, page.ContinuationToken);
                    id++;
                }
            }
            Assert.AreEqual(2, id);

            id = 1;
            var pageable = new PagingClient(Key, endpoint, null).DuplicateParams("foo");
            foreach (var page in pageable.AsPages())
            {
                if (id == 2)
                {
                    Assert.IsNull(page.ContinuationToken);
                }
                else
                {
                    Assert.AreEqual(id, page.Values.Single().ToObjectFromJson<Product>().Properties.Id);
                    Assert.AreEqual(product, page.Values.Single().ToObjectFromJson<Product>().Properties.Name);
                    StringAssert.EndsWith(linkPart, page.ContinuationToken);
                    id++;
                }
            }
            Assert.AreEqual(2, id);
        });

        [Test]
        public Task PagingFirstResponseEmpty() => Test(async (endpoint) =>
        {
            var result = new PagingClient(Key, endpoint, null).FirstResponseEmptyAsync(new());
            int count = 0;
            await foreach (var product in result)
            {
                count++;
                Assert.AreEqual(1, product.ToObjectFromJson<Product>().Properties.Id);
                Assert.AreEqual("Product", product.ToObjectFromJson<Product>().Properties.Name);
            }
            Assert.AreEqual(1, count);
        });

        [Test]
        public void RestClientDroppedMethods()
        {
            var client = typeof(PagingClient);
            Assert.IsNull(client.GetMethod("CreateNextFragmentNextPageRequest", BindingFlags.Instance | BindingFlags.NonPublic), "CreateNextFragmentNextPageRequest should not be generated");
            Assert.IsNull(client.GetMethod("NextFragmentNextPageAsync", BindingFlags.Instance | BindingFlags.NonPublic), "NextFragmentNextPageAsync should not be generated");
            Assert.IsNull(client.GetMethod("NextFragmentNextPage", BindingFlags.Instance | BindingFlags.NonPublic), "NextFragmentNextPage should not be generated");
        }

        [Test]
        public void ClientDroppedMethods()
        {
            var client = typeof(PagingClient);
            Assert.IsNull(client.GetMethod("NextFragmentAsync", BindingFlags.Instance | BindingFlags.NonPublic), "NextFragmentAsync should not be generated");
            Assert.IsNull(client.GetMethod("NextFragment", BindingFlags.Instance | BindingFlags.NonPublic), "NextFragment should not be generated");
        }

        internal class Product
        {
            [JsonPropertyName("properties")]
            public ProductProperties Properties { get; set; }
        }

        internal class ProductProperties
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }
    }
}
