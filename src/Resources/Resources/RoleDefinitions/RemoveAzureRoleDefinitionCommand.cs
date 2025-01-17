﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ActiveDirectory;
using Microsoft.Azure.Commands.Resources.Models;
using Microsoft.Azure.Commands.Resources.Models.Authorization;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

using System;
using System.Management.Automation;

using ProjectResources = Microsoft.Azure.Commands.Resources.Properties.Resources;

namespace Microsoft.Azure.Commands.Resources
{
    /// <summary>
    /// Deletes a given role definition.
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RoleDefinition", SupportsShouldProcess = true,DefaultParameterSetName = ParameterSet.RoleDefinitionId), OutputType(typeof(bool))]
    public class RemoveAzureRoleDefinitionCommand : ResourcesBaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.RoleDefinitionId,
            HelpMessage = "Role definition id")]
        [ValidateGuidNotEmpty]
        public Guid Id { get; set; }

        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.RoleDefinitionName,
            HelpMessage = "Role definition name. For e.g. Reader, Contributor, Virtual Machine Contributor.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = ParameterSet.InputObject, HelpMessage = "The object representing the role definition to be removed.")]
        [ValidateNotNullOrEmpty]
        public PSRoleDefinition InputObject { get; set; }

        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.RoleDefinitionName, HelpMessage = "Scope of the existing role definition.")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = ParameterSet.RoleDefinitionId, HelpMessage = "Scope of the existing role definition.")]
        public string Scope { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            PSRoleDefinition roleDefinition = null;
            string confirmMessage = null;
            if (this.IsParameterBound(c => c.InputObject))
            {
                var tempId = Guid.Empty;
                if (!string.IsNullOrEmpty(InputObject.Id) && Guid.TryParse(InputObject.Id, out tempId))
                {
                    Id = tempId;
                }
                else
                {
                    Name = InputObject.Name;
                }
            }

            if (Id != Guid.Empty)
            {
                confirmMessage = string.Format(ProjectResources.RemoveRoleDefinition, Id);
            }
            else
            {
                confirmMessage = string.Format(ProjectResources.RemoveRoleDefinitionWithName, Name);
            }

            FilterRoleDefinitionOptions options = new FilterRoleDefinitionOptions
            {
                RoleDefinitionId = Id,
                RoleDefinitionName = Name,
                Scope = Scope,
                ResourceIdentifier = new ResourceIdentifier
                {
                    Subscription = DefaultProfile.DefaultContext.Subscription?.Id?.ToString()
                }
            };

            if (options.Scope == null && options.ResourceIdentifier.Subscription == null)
            {
                WriteTerminatingError(ProjectResources.ScopeAndSubscriptionNeitherProvided);
            }

            AuthorizationClient.ValidateScope(options.Scope, true);

            ConfirmAction(
                Force.IsPresent,
                confirmMessage,
                ProjectResources.RemoveRoleDefinition,
                Id.ToString(),
                () =>
                {
                    roleDefinition = PoliciesClient.RemoveRoleDefinition(options);
                    if (PassThru)
                    {
                        WriteObject(roleDefinition);
                    }
                });
        }
    }
}
