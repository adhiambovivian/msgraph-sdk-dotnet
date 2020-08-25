// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Teams Async Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsAsyncOperation : Entity
    {
    
		///<summary>
		/// The TeamsAsyncOperation constructor
		///</summary>
        public TeamsAsyncOperation()
        {
            this.ODataType = "microsoft.graph.teamsAsyncOperation";
        }
	
        /// <summary>
        /// Gets or sets operation type.
        /// Denotes which type of operation is being described.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operationType", Required = Newtonsoft.Json.Required.Default)]
        public TeamsAsyncOperationType? OperationType { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Time when the operation was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Operation status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public TeamsAsyncOperationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// Time when the async operation was last updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets attempts count.
        /// Number of times the operation was attempted before being marked successful or failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attemptsCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AttemptsCount { get; set; }
    
        /// <summary>
        /// Gets or sets target resource id.
        /// The ID of the object that's created or modified as result of this async operation, typically a team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetResourceId", Required = Newtonsoft.Json.Required.Default)]
        public string TargetResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets target resource location.
        /// The location of the object that's created or modified as result of this async operation. This URL should be treated as an opaque value and not parsed into its component paths.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetResourceLocation", Required = Newtonsoft.Json.Required.Default)]
        public string TargetResourceLocation { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// Any error that causes the async operation to fail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "error", Required = Newtonsoft.Json.Required.Default)]
        public OperationError Error { get; set; }
    
    }
}

