// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The approval stage.
    /// </summary>
    public partial class ApprovalStage
    {
        /// <summary>
        /// Initializes a new instance of the ApprovalStage class.
        /// </summary>
        public ApprovalStage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApprovalStage class.
        /// </summary>
        /// <param name="approvalStageTimeOutInDays">The time in days when
        /// approval request would be timed out</param>
        /// <param name="isApproverJustificationRequired">Determines whether
        /// approver need to provide justification for his decision.</param>
        /// <param name="escalationTimeInMinutes">The time in minutes when the
        /// approval request would be escalated if the primary approver does
        /// not approve</param>
        /// <param name="primaryApprovers">The primary approver of the
        /// request.</param>
        /// <param name="isEscalationEnabled">The value determine whether
        /// escalation feature is enabled.</param>
        /// <param name="escalationApprovers">The escalation approver of the
        /// request.</param>
        public ApprovalStage(int? approvalStageTimeOutInDays = default(int?), bool? isApproverJustificationRequired = default(bool?), int? escalationTimeInMinutes = default(int?), IList<UserSet> primaryApprovers = default(IList<UserSet>), bool? isEscalationEnabled = default(bool?), IList<UserSet> escalationApprovers = default(IList<UserSet>))
        {
            ApprovalStageTimeOutInDays = approvalStageTimeOutInDays;
            IsApproverJustificationRequired = isApproverJustificationRequired;
            EscalationTimeInMinutes = escalationTimeInMinutes;
            PrimaryApprovers = primaryApprovers;
            IsEscalationEnabled = isEscalationEnabled;
            EscalationApprovers = escalationApprovers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time in days when approval request would be timed
        /// out
        /// </summary>
        [JsonProperty(PropertyName = "approvalStageTimeOutInDays")]
        public int? ApprovalStageTimeOutInDays { get; set; }

        /// <summary>
        /// Gets or sets determines whether approver need to provide
        /// justification for his decision.
        /// </summary>
        [JsonProperty(PropertyName = "isApproverJustificationRequired")]
        public bool? IsApproverJustificationRequired { get; set; }

        /// <summary>
        /// Gets or sets the time in minutes when the approval request would be
        /// escalated if the primary approver does not approve
        /// </summary>
        [JsonProperty(PropertyName = "escalationTimeInMinutes")]
        public int? EscalationTimeInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the primary approver of the request.
        /// </summary>
        [JsonProperty(PropertyName = "primaryApprovers")]
        public IList<UserSet> PrimaryApprovers { get; set; }

        /// <summary>
        /// Gets or sets the value determine whether escalation feature is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "isEscalationEnabled")]
        public bool? IsEscalationEnabled { get; set; }

        /// <summary>
        /// Gets or sets the escalation approver of the request.
        /// </summary>
        [JsonProperty(PropertyName = "escalationApprovers")]
        public IList<UserSet> EscalationApprovers { get; set; }

    }
}
