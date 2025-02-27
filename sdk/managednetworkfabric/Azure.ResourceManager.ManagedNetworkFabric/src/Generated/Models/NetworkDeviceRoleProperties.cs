// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Network device properties / role for the Network Rack. </summary>
    public partial class NetworkDeviceRoleProperties
    {
        /// <summary> Initializes a new instance of NetworkDeviceRoleProperties. </summary>
        public NetworkDeviceRoleProperties()
        {
        }

        /// <summary> Initializes a new instance of NetworkDeviceRoleProperties. </summary>
        /// <param name="networkDeviceSkuName"> Name of the associated Network Device SKU. </param>
        /// <param name="roleType"> Role for the network device. </param>
        /// <param name="rackSlot"> Rack slot for the network device. </param>
        internal NetworkDeviceRoleProperties(string networkDeviceSkuName, NetworkDeviceRackRoleType? roleType, int? rackSlot)
        {
            NetworkDeviceSkuName = networkDeviceSkuName;
            RoleType = roleType;
            RackSlot = rackSlot;
        }

        /// <summary> Name of the associated Network Device SKU. </summary>
        public string NetworkDeviceSkuName { get; set; }
        /// <summary> Role for the network device. </summary>
        public NetworkDeviceRackRoleType? RoleType { get; set; }
        /// <summary> Rack slot for the network device. </summary>
        public int? RackSlot { get; set; }
    }
}
