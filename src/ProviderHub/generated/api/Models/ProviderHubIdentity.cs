// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class ProviderHubIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProviderHubIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProviderHubIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="NestedResourceTypeFirst" /> property.</summary>
        private string _nestedResourceTypeFirst;

        /// <summary>The first child resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string NestedResourceTypeFirst { get => this._nestedResourceTypeFirst; set => this._nestedResourceTypeFirst = value; }

        /// <summary>Backing field for <see cref="NestedResourceTypeSecond" /> property.</summary>
        private string _nestedResourceTypeSecond;

        /// <summary>The second child resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string NestedResourceTypeSecond { get => this._nestedResourceTypeSecond; set => this._nestedResourceTypeSecond = value; }

        /// <summary>Backing field for <see cref="NestedResourceTypeThird" /> property.</summary>
        private string _nestedResourceTypeThird;

        /// <summary>The third child resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string NestedResourceTypeThird { get => this._nestedResourceTypeThird; set => this._nestedResourceTypeThird = value; }

        /// <summary>Backing field for <see cref="NotificationRegistrationName" /> property.</summary>
        private string _notificationRegistrationName;

        /// <summary>The notification registration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string NotificationRegistrationName { get => this._notificationRegistrationName; set => this._notificationRegistrationName = value; }

        /// <summary>Backing field for <see cref="ProviderNamespace" /> property.</summary>
        private string _providerNamespace;

        /// <summary>The name of the resource provider hosted within ProviderHub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string ProviderNamespace { get => this._providerNamespace; set => this._providerNamespace = value; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Backing field for <see cref="RolloutName" /> property.</summary>
        private string _rolloutName;

        /// <summary>The rollout name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string RolloutName { get => this._rolloutName; set => this._rolloutName = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>The SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; set => this._sku = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="ProviderHubIdentity" /> instance.</summary>
        public ProviderHubIdentity()
        {

        }
    }
    public partial interface IProviderHubIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable
    {
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The first child resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The first child resource type.",
        SerializedName = @"nestedResourceTypeFirst",
        PossibleTypes = new [] { typeof(string) })]
        string NestedResourceTypeFirst { get; set; }
        /// <summary>The second child resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The second child resource type.",
        SerializedName = @"nestedResourceTypeSecond",
        PossibleTypes = new [] { typeof(string) })]
        string NestedResourceTypeSecond { get; set; }
        /// <summary>The third child resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The third child resource type.",
        SerializedName = @"nestedResourceTypeThird",
        PossibleTypes = new [] { typeof(string) })]
        string NestedResourceTypeThird { get; set; }
        /// <summary>The notification registration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The notification registration.",
        SerializedName = @"notificationRegistrationName",
        PossibleTypes = new [] { typeof(string) })]
        string NotificationRegistrationName { get; set; }
        /// <summary>The name of the resource provider hosted within ProviderHub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource provider hosted within ProviderHub.",
        SerializedName = @"providerNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderNamespace { get; set; }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }
        /// <summary>The rollout name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The rollout name.",
        SerializedName = @"rolloutName",
        PossibleTypes = new [] { typeof(string) })]
        string RolloutName { get; set; }
        /// <summary>The SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IProviderHubIdentityInternal

    {
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The first child resource type.</summary>
        string NestedResourceTypeFirst { get; set; }
        /// <summary>The second child resource type.</summary>
        string NestedResourceTypeSecond { get; set; }
        /// <summary>The third child resource type.</summary>
        string NestedResourceTypeThird { get; set; }
        /// <summary>The notification registration.</summary>
        string NotificationRegistrationName { get; set; }
        /// <summary>The name of the resource provider hosted within ProviderHub.</summary>
        string ProviderNamespace { get; set; }
        /// <summary>The resource type.</summary>
        string ResourceType { get; set; }
        /// <summary>The rollout name.</summary>
        string RolloutName { get; set; }
        /// <summary>The SKU.</summary>
        string Sku { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        string SubscriptionId { get; set; }

    }
}