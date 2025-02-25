// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    /// <summary>The resource specific properties for the Storage Mover resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class EndpointBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IEndpointBaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IEndpointBasePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>A description for the Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="EndpointType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType _endpointType;

        /// <summary>The Endpoint resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType EndpointType { get => this._endpointType; set => this._endpointType = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20230301.IEndpointBasePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="EndpointBaseProperties" /> instance.</summary>
        public EndpointBaseProperties()
        {

        }
    }
    /// The resource specific properties for the Storage Mover resource.
    public partial interface IEndpointBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable
    {
        /// <summary>A description for the Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for the Endpoint.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The Endpoint resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Endpoint resource type.",
        SerializedName = @"endpointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType EndpointType { get; set; }
        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of this resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// The resource specific properties for the Storage Mover resource.
    internal partial interface IEndpointBasePropertiesInternal

    {
        /// <summary>A description for the Endpoint.</summary>
        string Description { get; set; }
        /// <summary>The Endpoint resource type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType EndpointType { get; set; }
        /// <summary>The provisioning state of this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}