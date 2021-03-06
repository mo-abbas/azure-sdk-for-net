// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIDedicated.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an instance of a Dedicated Capacity resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DedicatedCapacity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedCapacity class.
        /// </summary>
        public DedicatedCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedCapacity class.
        /// </summary>
        /// <param name="location">Location of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="sku">The SKU of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="id">An identifier that represents the PowerBI
        /// Dedicated resource.</param>
        /// <param name="name">The name of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="type">The type of the PowerBI Dedicated
        /// resource.</param>
        /// <param name="tags">Key-value pairs of additional resource
        /// provisioning properties.</param>
        /// <param name="administration">A collection of Dedicated capacity
        /// administrators</param>
        /// <param name="state">The current state of PowerBI Dedicated
        /// resource. The state is to indicate more states outside of resource
        /// provisioning. Possible values include: 'Deleting', 'Succeeded',
        /// 'Failed', 'Paused', 'Suspended', 'Provisioning', 'Updating',
        /// 'Suspending', 'Pausing', 'Resuming', 'Preparing', 'Scaling'</param>
        /// <param name="provisioningState">The current deployment state of
        /// PowerBI Dedicatedresource. The provisioningState is to indicate
        /// states for resource provisioning. Possible values include:
        /// 'Deleting', 'Succeeded', 'Failed', 'Paused', 'Suspended',
        /// 'Provisioning', 'Updating', 'Suspending', 'Pausing', 'Resuming',
        /// 'Preparing', 'Scaling'</param>
        public DedicatedCapacity(string location, ResourceSku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DedicatedCapacityAdministrators administration = default(DedicatedCapacityAdministrators), string state = default(string), string provisioningState = default(string))
            : base(location, sku, id, name, type, tags)
        {
            Administration = administration;
            State = state;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of Dedicated capacity administrators
        /// </summary>
        [JsonProperty(PropertyName = "properties.administration")]
        public DedicatedCapacityAdministrators Administration { get; set; }

        /// <summary>
        /// Gets the current state of PowerBI Dedicated resource. The state is
        /// to indicate more states outside of resource provisioning. Possible
        /// values include: 'Deleting', 'Succeeded', 'Failed', 'Paused',
        /// 'Suspended', 'Provisioning', 'Updating', 'Suspending', 'Pausing',
        /// 'Resuming', 'Preparing', 'Scaling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the current deployment state of PowerBI Dedicatedresource. The
        /// provisioningState is to indicate states for resource provisioning.
        /// Possible values include: 'Deleting', 'Succeeded', 'Failed',
        /// 'Paused', 'Suspended', 'Provisioning', 'Updating', 'Suspending',
        /// 'Pausing', 'Resuming', 'Preparing', 'Scaling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
