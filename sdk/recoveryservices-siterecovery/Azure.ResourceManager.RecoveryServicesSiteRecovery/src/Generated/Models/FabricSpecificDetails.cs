// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Fabric specific details.
    /// Please note <see cref="FabricSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SiteRecoveryFabricProviderSpecificDetails"/>, <see cref="HyperVSiteDetails"/>, <see cref="InMageRcmFabricSpecificDetails"/>, <see cref="VmmFabricDetails"/>, <see cref="VMwareDetails"/> and <see cref="VMwareV2FabricSpecificDetails"/>.
    /// </summary>
    public abstract partial class FabricSpecificDetails
    {
        /// <summary> Initializes a new instance of FabricSpecificDetails. </summary>
        protected FabricSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of FabricSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal FabricSpecificDetails(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}
