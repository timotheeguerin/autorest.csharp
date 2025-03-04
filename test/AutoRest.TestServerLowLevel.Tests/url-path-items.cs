﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using NUnit.Framework;
using url_LowLevel;

namespace AutoRest.TestServer.Tests
{
    public class UrlPathItemsTests : TestServerLowLevelTestBase
    {
        [Test]
        public Task UrlPathItemGetAll() => TestStatus(async (host) =>
            await new PathItemsClient(globalStringPath: "globalStringPath",
                    globalStringQuery: "globalStringQuery",
                    credential: Key,
                    endpoint: host,
                    options: null)
                .GetAllWithValuesAsync(
                    pathItemStringPath: "pathItemStringPath",
                    pathItemStringQuery: "pathItemStringQuery",
                    localStringPath: "localStringPath",
                    localStringQuery: "localStringQuery"));

        [Test]
        public Task UrlPathItemGetPathItemAndLocalNull() => TestStatus(async (host) =>
            await new PathItemsClient(globalStringPath: "globalStringPath",
                    globalStringQuery: "globalStringQuery",
                    credential: Key,
                    endpoint: host,
                    options: null)
                .GetLocalPathItemQueryNullAsync(
                    pathItemStringPath: "pathItemStringPath",
                    pathItemStringQuery: null,
                    localStringPath: "localStringPath",
                    localStringQuery: null));

        [Test]
        public Task UrlPathItemGetGlobalNull() => TestStatus(async (host) =>
            await new PathItemsClient(globalStringPath: "globalStringPath",
                    endpoint: host,
                    credential: Key,
                    globalStringQuery: null,
                    options: null)
                .GetGlobalQueryNullAsync(
                    pathItemStringPath: "pathItemStringPath",
                    pathItemStringQuery: "pathItemStringQuery",
                    localStringPath: "localStringPath",
                    localStringQuery: "localStringQuery"));

        [Test]
        public Task UrlPathItemGetGlobalAndLocalNull() => TestStatus(async (host) =>
            await new PathItemsClient(
                    globalStringPath: "globalStringPath",
                    endpoint: host,
                    credential: Key,
                    globalStringQuery: null,
                    options: null)
                .GetGlobalAndLocalQueryNullAsync(
                pathItemStringPath: "pathItemStringPath",
                pathItemStringQuery: "pathItemStringQuery",
                localStringPath: "localStringPath",
                localStringQuery: null));
    }
}
