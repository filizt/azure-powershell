namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>RemotePrivateEndpointConnection resource specific properties</summary>
    public partial class RemotePrivateEndpointConnectionProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IRemotePrivateEndpointConnectionProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IRemotePrivateEndpointConnectionProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IRemotePrivateEndpointConnectionProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json ? new RemotePrivateEndpointConnectionProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject into a new instance of <see cref="RemotePrivateEndpointConnectionProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RemotePrivateEndpointConnectionProperties(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_privateEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("privateEndpoint"), out var __jsonPrivateEndpoint) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ArmIdWrapper.FromJson(__jsonPrivateEndpoint) : PrivateEndpoint;}
            {_privateLinkServiceConnectionState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("privateLinkServiceConnectionState"), out var __jsonPrivateLinkServiceConnectionState) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.PrivateLinkConnectionState.FromJson(__jsonPrivateLinkServiceConnectionState) : PrivateLinkServiceConnectionState;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_iPAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray>("ipAddresses"), out var __jsonIPAddresses) ? If( __jsonIPAddresses as Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : IPAddress;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RemotePrivateEndpointConnectionProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RemotePrivateEndpointConnectionProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._privateEndpoint ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._privateEndpoint.ToJson(null,serializationMode) : null, "privateEndpoint" ,container.Add );
            AddIf( null != this._privateLinkServiceConnectionState ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._privateLinkServiceConnectionState.ToJson(null,serializationMode) : null, "privateLinkServiceConnectionState" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (null != this._iPAddress)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.XNodeArray();
                foreach( var __x in this._iPAddress )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("ipAddresses",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}