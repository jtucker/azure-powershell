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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.SiteRecovery
{
    /// <summary>
    /// Retrieves Azure Site Recovery Vault Settings.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureSiteRecoveryVaultSettings")]
    [OutputType(typeof(ASRVaultSettings))]
    public class GetAzureSiteRecoveryVaultSettings : SiteRecoveryCmdletBase
    {
        /// <summary>
        /// ProcessRecord of the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            this.WriteObject(new ASRVaultSettings(
                PSRecoveryServicesClient.asrVaultCreds.ResourceName,
                PSRecoveryServicesClient.asrVaultCreds.ResourceGroupName));
        }
    }
}