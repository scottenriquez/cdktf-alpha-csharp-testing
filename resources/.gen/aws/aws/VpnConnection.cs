using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.VpnConnection), fullyQualifiedName: "aws.VpnConnection", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpnConnectionConfig\"}}]")]
    public class VpnConnection : HashiCorp.Cdktf.TerraformResource
    {
        public VpnConnection(Constructs.Construct scope, string id, aws.IVpnConnectionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnection(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetStaticRoutesOnly")]
        public virtual void ResetStaticRoutesOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitGatewayId")]
        public virtual void ResetTransitGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1InsideCidr")]
        public virtual void ResetTunnel1InsideCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1PresharedKey")]
        public virtual void ResetTunnel1PresharedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2InsideCidr")]
        public virtual void ResetTunnel2InsideCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2PresharedKey")]
        public virtual void ResetTunnel2PresharedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnGatewayId")]
        public virtual void ResetVpnGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "routes", returnsJson: "{\"type\":{\"fqn\":\"aws.VpnConnectionRoutes\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.VpnConnectionRoutes Routes(string index)
        {
            return InvokeInstanceMethod<aws.VpnConnectionRoutes>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "vgwTelemetry", returnsJson: "{\"type\":{\"fqn\":\"aws.VpnConnectionVgwTelemetry\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.VpnConnectionVgwTelemetry VgwTelemetry(string index)
        {
            return InvokeInstanceMethod<aws.VpnConnectionVgwTelemetry>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerGatewayConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerGatewayConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerGatewayIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerGatewayIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transitGatewayAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayAttachmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1BgpAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1BgpAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1BgpHoldtime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1BgpHoldtime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tunnel1CgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1CgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1VgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1VgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2BgpAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2BgpAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2BgpHoldtime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2BgpHoldtime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tunnel2CgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2CgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2VgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2VgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "staticRoutesOnlyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? StaticRoutesOnlyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransitGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1InsideCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1InsideCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1PresharedKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1PresharedKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2InsideCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2InsideCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2PresharedKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2PresharedKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpnGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customerGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "staticRoutesOnly", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool StaticRoutesOnly
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1InsideCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1InsideCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1PresharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1PresharedKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2InsideCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2InsideCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2PresharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2PresharedKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
