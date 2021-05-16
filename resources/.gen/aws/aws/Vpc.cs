using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Vpc), fullyQualifiedName: "aws.Vpc", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.VpcConfig\"}}]")]
    public class Vpc : HashiCorp.Cdktf.TerraformResource
    {
        public Vpc(Constructs.Construct scope, string id, aws.IVpcConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Vpc(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Vpc(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAssignGeneratedIpv6CidrBlock")]
        public virtual void ResetAssignGeneratedIpv6CidrBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableClassiclink")]
        public virtual void ResetEnableClassiclink()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableClassiclinkDnsSupport")]
        public virtual void ResetEnableClassiclinkDnsSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableDnsHostnames")]
        public virtual void ResetEnableDnsHostnames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableDnsSupport")]
        public virtual void ResetEnableDnsSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceTenancy")]
        public virtual void ResetInstanceTenancy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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

        [JsiiProperty(name: "cidrBlockInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CidrBlockInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultNetworkAclId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultNetworkAclId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRouteTableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dhcpOptionsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DhcpOptionsId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6AssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6AssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6CidrBlock
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mainRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MainRouteTableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignGeneratedIpv6CidrBlockInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AssignGeneratedIpv6CidrBlockInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableClassiclinkDnsSupportInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableClassiclinkDnsSupportInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableClassiclinkInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableClassiclinkInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableDnsHostnamesInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableDnsHostnamesInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableDnsSupportInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableDnsSupportInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTenancyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTenancyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "assignGeneratedIpv6CidrBlock", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AssignGeneratedIpv6CidrBlock
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableClassiclink", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableClassiclink
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableClassiclinkDnsSupport", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableClassiclinkDnsSupport
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableDnsHostnames", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableDnsHostnames
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableDnsSupport", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableDnsSupport
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceTenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceTenancy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
