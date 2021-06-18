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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ImageConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSImage))]
    public partial class NewAzureRmImageConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/images")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Sets the edge zone name. If set, the query will be routed to the specified edgezone instead of the main region.")]
        public string EdgeZone { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string SourceVirtualMachineId { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public ImageOSDisk OsDisk { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("V1", "V2")]
        public string HyperVGeneration { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public ImageDataDisk[] DataDisk { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter ZoneResilient { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("Image", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // SourceVirtualMachine
            SubResource vSourceVirtualMachine = null;

            // StorageProfile
            ImageStorageProfile vStorageProfile = null;

            // ExtendedLocation
            ExtendedLocation vExtendedLocation = null;

            if (this.IsParameterBound(c => c.SourceVirtualMachineId))
            {
                if (vSourceVirtualMachine == null)
                {
                    vSourceVirtualMachine = new SubResource();
                }
                vSourceVirtualMachine.Id = this.SourceVirtualMachineId;
            }

            if (this.IsParameterBound(c => c.OsDisk))
            {
                if (vStorageProfile == null)
                {
                    vStorageProfile = new ImageStorageProfile();
                }
                vStorageProfile.OsDisk = this.OsDisk;
            }

            if (this.IsParameterBound(c => c.DataDisk))
            {
                if (vStorageProfile == null)
                {
                    vStorageProfile = new ImageStorageProfile();
                }
                vStorageProfile.DataDisks = this.DataDisk;
            }

            if (vStorageProfile == null)
            {
                vStorageProfile = new ImageStorageProfile();
            }
            vStorageProfile.ZoneResilient = this.ZoneResilient.IsPresent;

            if (this.IsParameterBound(c => c.EdgeZone))
            {
                vExtendedLocation = new ExtendedLocation { Name = this.EdgeZone, Type = ExtendedLocationTypes.EdgeZone };
            }

            var vImage = new PSImage
            {
                HyperVGeneration = this.IsParameterBound(c => c.HyperVGeneration) ? this.HyperVGeneration : "V1",
                Location = this.IsParameterBound(c => c.Location) ? this.Location : null,
                ExtendedLocation = vExtendedLocation,
                Tags = this.IsParameterBound(c => c.Tag) ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                SourceVirtualMachine = vSourceVirtualMachine,
                StorageProfile = vStorageProfile,
            };

            WriteObject(vImage);
        }
    }
}
