// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// The SKU (pricing tier) of the CDN profile.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of the pricing tier. Possible values
        /// include: 'Standard_Verizon', 'Premium_Verizon', 'Custom_Verizon',
        /// 'Standard_Akamai', 'Standard_ChinaCdn'</param>
        public Sku(string name = default(string))
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets name of the pricing tier. Possible values include:
        /// 'Standard_Verizon', 'Premium_Verizon', 'Custom_Verizon',
        /// 'Standard_Akamai', 'Standard_ChinaCdn'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
