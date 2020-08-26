// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedDeviceMobileAppConfigurationRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceMobileAppConfigurationRequestBuilder : EntityRequestBuilder, IManagedDeviceMobileAppConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedDeviceMobileAppConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceMobileAppConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagedDeviceMobileAppConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagedDeviceMobileAppConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceMobileAppConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationDeviceStatusesCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationDeviceStatusesCollectionRequestBuilder DeviceStatuses
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationDeviceStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder UserStatuses
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatusSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationDeviceSummaryRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationDeviceSummaryRequestBuilder DeviceStatusSummary
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationDeviceSummaryRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatusSummary"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatusSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationUserSummaryRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationUserSummaryRequestBuilder UserStatusSummary
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationUserSummaryRequestBuilder(this.AppendSegmentToRequestUrl("userStatusSummary"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceMobileAppConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationAssignRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationAssignRequestBuilder Assign(
            IEnumerable<ManagedDeviceMobileAppConfigurationAssignment> assignments = null)
        {
            return new ManagedDeviceMobileAppConfigurationAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                assignments);
        }
    
    }
}