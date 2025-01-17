// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>General metadata for the parameter.</summary>
    public partial class ParameterDefinitionsValueMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadataInternal
    {

        /// <summary>Backing field for <see cref="AssignPermission" /> property.</summary>
        private bool? _assignPermission;

        /// <summary>
        /// Set to true to have Azure portal create role assignments on the resource ID or resource scope value of this parameter
        /// during policy assignment. This property is useful in case you wish to assign permissions outside the assignment scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public bool? AssignPermission { get => this._assignPermission; set => this._assignPermission = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name for the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="StrongType" /> property.</summary>
        private string _strongType;

        /// <summary>
        /// Used when assigning the policy definition through the portal. Provides a context aware list of values for the user to
        /// choose from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string StrongType { get => this._strongType; set => this._strongType = value; }

        /// <summary>Creates an new <see cref="ParameterDefinitionsValueMetadata" /> instance.</summary>
        public ParameterDefinitionsValueMetadata()
        {

        }
    }
    /// General metadata for the parameter.
    public partial interface IParameterDefinitionsValueMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// Set to true to have Azure portal create role assignments on the resource ID or resource scope value of this parameter
        /// during policy assignment. This property is useful in case you wish to assign permissions outside the assignment scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set to true to have Azure portal create role assignments on the resource ID or resource scope value of this parameter during policy assignment. This property is useful in case you wish to assign permissions outside the assignment scope.",
        SerializedName = @"assignPermissions",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AssignPermission { get; set; }
        /// <summary>The description of the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the parameter.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The display name for the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name for the parameter.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Used when assigning the policy definition through the portal. Provides a context aware list of values for the user to
        /// choose from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used when assigning the policy definition through the portal. Provides a context aware list of values for the user to choose from.",
        SerializedName = @"strongType",
        PossibleTypes = new [] { typeof(string) })]
        string StrongType { get; set; }

    }
    /// General metadata for the parameter.
    internal partial interface IParameterDefinitionsValueMetadataInternal

    {
        /// <summary>
        /// Set to true to have Azure portal create role assignments on the resource ID or resource scope value of this parameter
        /// during policy assignment. This property is useful in case you wish to assign permissions outside the assignment scope.
        /// </summary>
        bool? AssignPermission { get; set; }
        /// <summary>The description of the parameter.</summary>
        string Description { get; set; }
        /// <summary>The display name for the parameter.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Used when assigning the policy definition through the portal. Provides a context aware list of values for the user to
        /// choose from.
        /// </summary>
        string StrongType { get; set; }

    }
}