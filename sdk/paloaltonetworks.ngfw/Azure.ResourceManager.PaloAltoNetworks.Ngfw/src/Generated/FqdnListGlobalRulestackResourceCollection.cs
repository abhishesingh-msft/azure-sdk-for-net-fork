// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="FqdnListGlobalRulestackResource" /> and their operations.
    /// Each <see cref="FqdnListGlobalRulestackResource" /> in the collection will belong to the same instance of <see cref="GlobalRulestackResource" />.
    /// To get a <see cref="FqdnListGlobalRulestackResourceCollection" /> instance call the GetFqdnListGlobalRulestackResources method from an instance of <see cref="GlobalRulestackResource" />.
    /// </summary>
    public partial class FqdnListGlobalRulestackResourceCollection : ArmCollection, IEnumerable<FqdnListGlobalRulestackResource>, IAsyncEnumerable<FqdnListGlobalRulestackResource>
    {
        private readonly ClientDiagnostics _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics;
        private readonly FqdnListGlobalRulestackRestOperations _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="FqdnListGlobalRulestackResourceCollection"/> class for mocking. </summary>
        protected FqdnListGlobalRulestackResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FqdnListGlobalRulestackResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FqdnListGlobalRulestackResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", FqdnListGlobalRulestackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FqdnListGlobalRulestackResource.ResourceType, out string fqdnListGlobalRulestackResourceFqdnListGlobalRulestackApiVersion);
            _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient = new FqdnListGlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fqdnListGlobalRulestackResourceFqdnListGlobalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GlobalRulestackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GlobalRulestackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FqdnListGlobalRulestackResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, FqdnListGlobalRulestackResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics.CreateScope("FqdnListGlobalRulestackResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateOrUpdateAsync(Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<FqdnListGlobalRulestackResource>(new FqdnListGlobalRulestackResourceOperationSource(Client), _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics, Pipeline, _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FqdnListGlobalRulestackResource> CreateOrUpdate(WaitUntil waitUntil, string name, FqdnListGlobalRulestackResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics.CreateScope("FqdnListGlobalRulestackResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateOrUpdate(Id.Name, name, data, cancellationToken);
                var operation = new NgfwArmOperation<FqdnListGlobalRulestackResource>(new FqdnListGlobalRulestackResourceOperationSource(Client), _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics, Pipeline, _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Name, name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<FqdnListGlobalRulestackResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics.CreateScope("FqdnListGlobalRulestackResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FqdnListGlobalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<FqdnListGlobalRulestackResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics.CreateScope("FqdnListGlobalRulestackResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FqdnListGlobalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FqdnListGlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FqdnListGlobalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FqdnListGlobalRulestackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FqdnListGlobalRulestackResource(Client, FqdnListGlobalRulestackResourceData.DeserializeFqdnListGlobalRulestackResourceData(e)), _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics, Pipeline, "FqdnListGlobalRulestackResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FqdnListGlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FqdnListGlobalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FqdnListGlobalRulestackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FqdnListGlobalRulestackResource(Client, FqdnListGlobalRulestackResourceData.DeserializeFqdnListGlobalRulestackResourceData(e)), _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics, Pipeline, "FqdnListGlobalRulestackResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics.CreateScope("FqdnListGlobalRulestackResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> fqdn list name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackClientDiagnostics.CreateScope("FqdnListGlobalRulestackResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _fqdnListGlobalRulestackResourceFqdnListGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FqdnListGlobalRulestackResource> IEnumerable<FqdnListGlobalRulestackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FqdnListGlobalRulestackResource> IAsyncEnumerable<FqdnListGlobalRulestackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
