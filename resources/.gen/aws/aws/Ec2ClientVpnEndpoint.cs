using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Ec2ClientVpnEndpoint), fullyQualifiedName: "aws.Ec2ClientVpnEndpoint", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Ec2ClientVpnEndpointConfig\"}}]")]
    public class Ec2ClientVpnEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        public Ec2ClientVpnEndpoint(Constructs.Construct scope, string id, aws.IEc2ClientVpnEndpointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2ClientVpnEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2ClientVpnEndpoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsServers")]
        public virtual void ResetDnsServers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSplitTunnel")]
        public virtual void ResetSplitTunnel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportProtocol")]
        public virtual void ResetTransportProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointAuthenticationOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2ClientVpnEndpointAuthenticationOptions[] AuthenticationOptionsInput
        {
            get => GetInstanceProperty<aws.IEc2ClientVpnEndpointAuthenticationOptions[]>()!;
        }

        [JsiiProperty(name: "clientCidrBlockInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCidrBlockInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionLogOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointConnectionLogOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2ClientVpnEndpointConnectionLogOptions[] ConnectionLogOptionsInput
        {
            get => GetInstanceProperty<aws.IEc2ClientVpnEndpointConnectionLogOptions[]>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverCertificateArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DnsServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "splitTunnelInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SplitTunnelInput
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
        [JsiiProperty(name: "transportProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransportProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authenticationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointAuthenticationOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2ClientVpnEndpointAuthenticationOptions[] AuthenticationOptions
        {
            get => GetInstanceProperty<aws.IEc2ClientVpnEndpointAuthenticationOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionLogOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2ClientVpnEndpointConnectionLogOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2ClientVpnEndpointConnectionLogOptions[] ConnectionLogOptions
        {
            get => GetInstanceProperty<aws.IEc2ClientVpnEndpointConnectionLogOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "splitTunnel", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool SplitTunnel
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

        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
