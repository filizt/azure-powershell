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

namespace Microsoft.Azure.Commands.ActiveDirectory
{
    public class PSADApplication : PSADObject
    {
        public string ObjectId { get; set; }

        public IList<string> IdentifierUris { get; set; }

        public string HomePage { get; set; }

        public Guid ApplicationId { get; set; }

        public bool AvailableToOtherTenants { get; set; }

        public IList<string> AppPermissions { get; set; }

        public IList<string> ReplyUrls { get; set; }

        public string ObjectType => "Application";
    }
}
