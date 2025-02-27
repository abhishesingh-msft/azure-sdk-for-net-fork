// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for Get ServiceTagInformation API service call. Retrieves the list of service tag information resources. </summary>
    internal partial class ServiceTagInformationListResult
    {
        /// <summary> Initializes a new instance of ServiceTagInformationListResult. </summary>
        internal ServiceTagInformationListResult()
        {
            Value = new ChangeTrackingList<ServiceTagInformation>();
        }

        /// <summary> Initializes a new instance of ServiceTagInformationListResult. </summary>
        /// <param name="value"> The list of service tag information resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ServiceTagInformationListResult(IReadOnlyList<ServiceTagInformation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of service tag information resources. </summary>
        public IReadOnlyList<ServiceTagInformation> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
