using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Ec2TransitGatewayVpcAttachment), fullyQualifiedName: "aws.Ec2TransitGatewayVpcAttachment", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Ec2TransitGatewayVpcAttachmentConfig\"}}]")]
    public class Ec2TransitGatewayVpcAttachment : HashiCorp.Cdktf.TerraformResource
    {
        public Ec2TransitGatewayVpcAttachment(Constructs.Construct scope, string id, aws.IEc2TransitGatewayVpcAttachmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TransitGatewayVpcAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TransitGatewayVpcAttachment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDnsSupport")]
        public virtual void ResetDnsSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6Support")]
        public virtual void ResetIpv6Support()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitGatewayDefaultRouteTableAssociation")]
        public virtual void ResetTransitGatewayDefaultRouteTableAssociation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitGatewayDefaultRouteTablePropagation")]
        public virtual void ResetTransitGatewayDefaultRouteTablePropagation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIdsInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "transitGatewayIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcOwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsSupportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsSupportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6SupportInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6SupportInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayDefaultRouteTableAssociationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? TransitGatewayDefaultRouteTableAssociationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayDefaultRouteTablePropagationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? TransitGatewayDefaultRouteTablePropagationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "dnsSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsSupport
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6Support", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Support
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitGatewayDefaultRouteTableAssociation", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool TransitGatewayDefaultRouteTableAssociation
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitGatewayDefaultRouteTablePropagation", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool TransitGatewayDefaultRouteTablePropagation
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
