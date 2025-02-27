// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated sub-client.
    /// <summary> The CropProducts sub-client. </summary>
    public partial class CropProducts
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of CropProducts for mocking. </summary>
        protected CropProducts()
        {
        }

        /// <summary> Initializes a new instance of CropProducts. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal CropProducts(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Gets a specified crop Product resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropProductId"> Id of the crop Product. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropProductId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropProductId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='GetCropProductAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetCropProductAsync(string cropProductId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(cropProductId, nameof(cropProductId));

            using var scope = ClientDiagnostics.CreateScope("CropProducts.GetCropProduct");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCropProductRequest(cropProductId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a specified crop Product resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropProductId"> Id of the crop Product. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropProductId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropProductId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='GetCropProduct(string,RequestContext)']/*" />
        public virtual Response GetCropProduct(string cropProductId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(cropProductId, nameof(cropProductId));

            using var scope = ClientDiagnostics.CreateScope("CropProducts.GetCropProduct");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCropProductRequest(cropProductId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates a crop Product resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropProductId"> Id of the crop Product resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropProductId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropProductId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='CreateOrUpdateAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateAsync(string cropProductId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropProductId, nameof(cropProductId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("CropProducts.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(cropProductId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates a crop Product resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropProductId"> Id of the crop Product resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropProductId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropProductId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='CreateOrUpdate(string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdate(string cropProductId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropProductId, nameof(cropProductId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("CropProducts.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(cropProductId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a specified crop Product resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropProductId"> Id of the crop Product. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropProductId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropProductId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='DeleteAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> DeleteAsync(string cropProductId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropProductId, nameof(cropProductId));

            using var scope = ClientDiagnostics.CreateScope("CropProducts.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(cropProductId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a specified crop Product resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropProductId"> Id of the crop Product. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropProductId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropProductId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='Delete(string,RequestContext)']/*" />
        public virtual Response Delete(string cropProductId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropProductId, nameof(cropProductId));

            using var scope = ClientDiagnostics.CreateScope("CropProducts.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(cropProductId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of crop product resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropIds"> CropIds of the resource. </param>
        /// <param name="brands"> Brands of the resource. </param>
        /// <param name="products"> Products of the resource. </param>
        /// <param name="traits"> Traits of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='GetCropProductsAsync(IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetCropProductsAsync(IEnumerable<string> cropIds, IEnumerable<string> brands, IEnumerable<string> products, IEnumerable<string> traits, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetCropProductsRequest(cropIds, brands, products, traits, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetCropProductsNextPageRequest(nextLink, cropIds, brands, products, traits, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "CropProducts.GetCropProducts", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of crop product resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cropIds"> CropIds of the resource. </param>
        /// <param name="brands"> Brands of the resource. </param>
        /// <param name="products"> Products of the resource. </param>
        /// <param name="traits"> Traits of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/CropProducts.xml" path="doc/members/member[@name='GetCropProducts(IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetCropProducts(IEnumerable<string> cropIds, IEnumerable<string> brands, IEnumerable<string> products, IEnumerable<string> traits, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetCropProductsRequest(cropIds, brands, products, traits, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetCropProductsNextPageRequest(nextLink, cropIds, brands, products, traits, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "CropProducts.GetCropProducts", "value", "nextLink", context);
        }

        internal HttpMessage CreateGetCropProductsRequest(IEnumerable<string> cropIds, IEnumerable<string> brands, IEnumerable<string> products, IEnumerable<string> traits, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crop-products", false);
            if (cropIds != null && Optional.IsCollectionDefined(cropIds))
            {
                foreach (var param in cropIds)
                {
                    uri.AppendQuery("cropIds", param, true);
                }
            }
            if (brands != null && Optional.IsCollectionDefined(brands))
            {
                foreach (var param in brands)
                {
                    uri.AppendQuery("brands", param, true);
                }
            }
            if (products != null && Optional.IsCollectionDefined(products))
            {
                foreach (var param in products)
                {
                    uri.AppendQuery("products", param, true);
                }
            }
            if (traits != null && Optional.IsCollectionDefined(traits))
            {
                foreach (var param in traits)
                {
                    uri.AppendQuery("traits", param, true);
                }
            }
            if (ids != null && Optional.IsCollectionDefined(ids))
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null && Optional.IsCollectionDefined(names))
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null && Optional.IsCollectionDefined(propertyFilters))
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null && Optional.IsCollectionDefined(statuses))
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetCropProductRequest(string cropProductId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crop-products/", false);
            uri.AppendPath(cropProductId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string cropProductId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crop-products/", false);
            uri.AppendPath(cropProductId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string cropProductId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crop-products/", false);
            uri.AppendPath(cropProductId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetCropProductsNextPageRequest(string nextLink, IEnumerable<string> cropIds, IEnumerable<string> brands, IEnumerable<string> products, IEnumerable<string> traits, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
