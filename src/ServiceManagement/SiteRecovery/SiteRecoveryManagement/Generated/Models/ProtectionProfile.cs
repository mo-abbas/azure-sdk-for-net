// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Protection profile object.
    /// </summary>
    public partial class ProtectionProfile : ServiceResourceBase
    {
        private IList<ProtectionProfileAssociationDetails> _associationDetail;
        
        /// <summary>
        /// Required. The list of association details.
        /// </summary>
        public IList<ProtectionProfileAssociationDetails> AssociationDetail
        {
            get { return this._associationDetail; }
            set { this._associationDetail = value; }
        }
        
        private bool _canDissociate;
        
        /// <summary>
        /// Required. the value indicating whether profile can be dissociated
        /// or not.
        /// </summary>
        public bool CanDissociate
        {
            get { return this._canDissociate; }
            set { this._canDissociate = value; }
        }
        
        private int _protectedEntityCount;
        
        /// <summary>
        /// Required. the count of the protected entities assosciated to this
        /// profile
        /// </summary>
        public int ProtectedEntityCount
        {
            get { return this._protectedEntityCount; }
            set { this._protectedEntityCount = value; }
        }
        
        private string _replicationProvider;
        
        /// <summary>
        /// Required. Name of replication provider
        /// </summary>
        public string ReplicationProvider
        {
            get { return this._replicationProvider; }
            set { this._replicationProvider = value; }
        }
        
        private string _replicationProviderSetting;
        
        /// <summary>
        /// Required. the replication provider settings
        /// </summary>
        public string ReplicationProviderSetting
        {
            get { return this._replicationProviderSetting; }
            set { this._replicationProviderSetting = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProtectionProfile class.
        /// </summary>
        public ProtectionProfile()
        {
            this.AssociationDetail = new LazyList<ProtectionProfileAssociationDetails>();
        }
    }
}