﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Moq;
using NUnit.Framework;

namespace Azure.Storage.DataMovement.Blobs.Tests
{
    [TestFixture]
    public class StorageResourceEtagManagementTests
    {
        [Test]
        public async Task BlockBlobMaintainsEtagForDownloads()
        {
            ETag etag = new ETag("foo");
            Mock<BlockBlobClient> mock = new();
            mock.Setup(b => b.GetPropertiesAsync(It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    new BlobProperties(),
                    new MockResponse(200).WithHeader(Constants.HeaderNames.ETag, etag.ToString()))));
            mock.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                    new MockResponse(201))));

            BlockBlobStorageResource storageResource = new(mock.Object);
            await storageResource.GetPropertiesAsync();
            await storageResource.ReadStreamAsync();

            mock.Verify(
                b => b.GetPropertiesAsync(It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.Verify(
                b => b.DownloadStreamingAsync(
                    It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == etag),
                    It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task PageBlobBlobMaintainsEtagForDownloads()
        {
            ETag etag = new ETag("foo");
            Mock<PageBlobClient> mock = new();
            mock.Setup(b => b.GetPropertiesAsync(It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    new BlobProperties(),
                    new MockResponse(200).WithHeader(Constants.HeaderNames.ETag, etag.ToString()))));
            mock.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                    new MockResponse(201))));

            PageBlobStorageResource storageResource = new(mock.Object);
            await storageResource.GetPropertiesAsync();
            await storageResource.ReadStreamAsync();

            mock.Verify(
                b => b.GetPropertiesAsync(It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.Verify(
                b => b.DownloadStreamingAsync(
                    It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == etag),
                    It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task AppendBlobMaintainsEtagForDownloads()
        {
            ETag etag = new ETag("foo");
            Mock<AppendBlobClient> mock = new();
            mock.Setup(b => b.GetPropertiesAsync(It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    new BlobProperties(),
                    new MockResponse(200).WithHeader(Constants.HeaderNames.ETag, etag.ToString()))));
            mock.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                    new MockResponse(201))));

            AppendBlobStorageResource storageResource = new(mock.Object);
            await storageResource.GetPropertiesAsync();
            await storageResource.ReadStreamAsync();

            mock.Verify(
                b => b.GetPropertiesAsync(It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()),
                Times.Once());
            mock.Verify(
                b => b.DownloadStreamingAsync(
                    It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == etag),
                    It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task BlockBlobUsesProvidedEtag()
        {
            ETag etag = new ETag("foo");
            Mock<BlockBlobClient> mock = new();
            mock.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                    new MockResponse(201))));

            BlockBlobStorageResource storageResource = new(mock.Object, length: default, etag);
            await storageResource.ReadStreamAsync();

            mock.Verify(
                b => b.DownloadStreamingAsync(
                    It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == etag),
                    It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task PageBlobUsesProvidedEtag()
        {
            ETag etag = new ETag("foo");
            Mock<PageBlobClient> mock = new();
            mock.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                    new MockResponse(201))));

            PageBlobStorageResource storageResource = new(mock.Object, length: default, etag);
            await storageResource.ReadStreamAsync();

            mock.Verify(
                b => b.DownloadStreamingAsync(
                    It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == etag),
                    It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task AppendBlobUsesProvidedEtag()
        {
            ETag etag = new ETag("foo");
            Mock<AppendBlobClient> mock = new();
            mock.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(Response.FromValue(
                    BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                    new MockResponse(201))));

            AppendBlobStorageResource storageResource = new(mock.Object, length: default, etag);
            await storageResource.ReadStreamAsync();

            mock.Verify(
                b => b.DownloadStreamingAsync(
                    It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == etag),
                    It.IsAny<CancellationToken>()),
                Times.Once());
            mock.VerifyNoOtherCalls();
        }

        [Test]
        public async Task ContainerProvidesETagFromList()
        {
            // Arrange

            List<BlobType> blobTypes = new() { BlobType.Block, BlobType.Page, BlobType.Append };
            Random random = new();
            List<ETag> etags = Enumerable.Range(0, blobTypes.Count)
                .Select(_ => new ETag(Convert.ToBase64String(Guid.NewGuid().ToByteArray())))
                .ToList();
            List<BlobItem> blobListItems = Enumerable.Range(0, blobTypes.Count)
                .Select(i => BlobsModelFactory.BlobItemProperties(
                    accessTierInferred: false, eTag: etags[i], blobType: blobTypes[i]))
                .Select(props => BlobsModelFactory.BlobItem(properties: props))
                .ToList();
            Mock<BlobContainerClient> mock = new();
            mock.Setup(c => c.GetBlobsAsync(It.IsAny<BlobTraits>(), It.IsAny<BlobStates>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns(AsyncPageable<BlobItem>.FromPages(new List<Page<BlobItem>>()
                {
                    Page<BlobItem>.FromValues(
                        blobListItems,
                        continuationToken: null,
                        response: null)
                }));

            // Act

            BlobStorageResourceContainer containerResource = new(mock.Object);
            List<StorageResource> children = await containerResource.GetStorageResourcesAsync().ToEnumerableAsync();

            // Assert

            // to assert each child resource is initialized with the correct etag, mock the backing client
            // and assert the client is recieving the etag in its calls.
            Assert.AreEqual(blobTypes.Count, children.Count);
            for (int i = 0; i < blobTypes.Count; i++)
            {
                ETag expectedEtag = etags[i];
                BlobType blobType = blobTypes[i];
                switch (blobType)
                {
                    case BlobType.Block:
                        BlockBlobStorageResource blockChild = children[i] as BlockBlobStorageResource;
                        Mock<BlockBlobClient> blockClient = new();
                        blockClient.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                            .Returns(Task.FromResult(Response.FromValue(
                                BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                                new MockResponse(201))));
                        blockChild.BlobClient = blockClient.Object;

                        await blockChild.ReadStreamAsync();

                        blockClient.Verify(
                            b => b.DownloadStreamingAsync(
                                It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == expectedEtag),
                                It.IsAny<CancellationToken>()),
                            Times.Once());
                        blockClient.VerifyNoOtherCalls();
                        break;

                    case BlobType.Page:
                        PageBlobStorageResource pageChild = children[i] as PageBlobStorageResource;
                        Mock<PageBlobClient> pageClient = new();
                        pageClient.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                            .Returns(Task.FromResult(Response.FromValue(
                                BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                                new MockResponse(201))));
                        pageChild.BlobClient = pageClient.Object;

                        await pageChild.ReadStreamAsync();

                        pageClient.Verify(
                            b => b.DownloadStreamingAsync(
                                It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == expectedEtag),
                                It.IsAny<CancellationToken>()),
                            Times.Once());
                        pageClient.VerifyNoOtherCalls();
                        break;

                    case BlobType.Append:
                        AppendBlobStorageResource appendChild = children[i] as AppendBlobStorageResource;
                        Mock<AppendBlobClient> appendClient = new();
                        appendClient.Setup(b => b.DownloadStreamingAsync(It.IsAny<BlobDownloadOptions>(), It.IsAny<CancellationToken>()))
                            .Returns(Task.FromResult(Response.FromValue(
                                BlobsModelFactory.BlobDownloadStreamingResult(Stream.Null, new BlobDownloadDetails()),
                                new MockResponse(201))));
                        appendChild.BlobClient = appendClient.Object;

                        await appendChild.ReadStreamAsync();

                        appendClient.Verify(
                            b => b.DownloadStreamingAsync(
                                It.Is<BlobDownloadOptions>(options => options.Conditions.IfMatch == expectedEtag),
                                It.IsAny<CancellationToken>()),
                            Times.Once());
                        appendClient.VerifyNoOtherCalls();
                        break;
                }
            }
        }
    }
}
