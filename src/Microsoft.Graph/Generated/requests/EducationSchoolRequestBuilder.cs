// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EducationSchoolRequestBuilder.
    /// </summary>
    public partial class EducationSchoolRequestBuilder : EducationOrganizationRequestBuilder, IEducationSchoolRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationSchoolRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationSchoolRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEducationSchoolRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEducationSchoolRequest Request(IEnumerable<Option> options)
        {
            return new EducationSchoolRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Classes.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolClassesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IEducationSchoolClassesCollectionWithReferencesRequestBuilder Classes
        {
            get
            {
                return new EducationSchoolClassesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("classes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Users.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolUsersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IEducationSchoolUsersCollectionWithReferencesRequestBuilder Users
        {
            get
            {
                return new EducationSchoolUsersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("users"), this.Client);
            }
        }
    
    }
}
