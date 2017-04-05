// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The callback url parameters.
    /// </summary>
    public partial class GetCallbackUrlParameters
    {
        /// <summary>
        /// Initializes a new instance of the GetCallbackUrlParameters class.
        /// </summary>
        public GetCallbackUrlParameters() { }

        /// <summary>
        /// Initializes a new instance of the GetCallbackUrlParameters class.
        /// </summary>
        public GetCallbackUrlParameters(DateTime? notAfter = default(DateTime?), KeyType? keyType = default(KeyType?))
        {
            NotAfter = notAfter;
            KeyType = keyType;
        }

        /// <summary>
        /// Gets or sets the expiry time.
        /// </summary>
        [JsonProperty(PropertyName = "notAfter")]
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Gets or sets the key type. Possible values include:
        /// 'NotSpecified', 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public KeyType? KeyType { get; set; }

    }
}