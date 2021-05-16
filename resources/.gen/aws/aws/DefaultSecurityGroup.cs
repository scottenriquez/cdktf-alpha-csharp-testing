using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DefaultSecurityGroup), fullyQualifiedName: "aws.DefaultSecurityGroup", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DefaultSecurityGroupConfig\"}}]")]
    public class DefaultSecurityGroup : HashiCorp.Cdktf.TerraformResource
    {
        public DefaultSecurityGroup(Constructs.Construct scope, string id, aws.IDefaultSecurityGroupConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DefaultSecurityGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DefaultSecurityGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEgress")]
        public virtual void ResetEgress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIngress")]
        public virtual void ResetIngress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevokeRulesOnDelete")]
        public virtual void ResetRevokeRulesOnDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcId")]
        public virtual void ResetVpcId()
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupEgress\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDefaultSecurityGroupEgress[]? EgressInput
        {
            get => GetInstanceProperty<aws.IDefaultSecurityGroupEgress[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupIngress\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDefaultSecurityGroupIngress[]? IngressInput
        {
            get => GetInstanceProperty<aws.IDefaultSecurityGroupIngress[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revokeRulesOnDeleteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RevokeRulesOnDeleteInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.DefaultSecurityGroupTimeouts\"}", isOptional: true)]
        public virtual aws.IDefaultSecurityGroupTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IDefaultSecurityGroupTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupEgress\"},\"kind\":\"array\"}}")]
        public virtual aws.IDefaultSecurityGroupEgress[] Egress
        {
            get => GetInstanceProperty<aws.IDefaultSecurityGroupEgress[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupIngress\"},\"kind\":\"array\"}}")]
        public virtual aws.IDefaultSecurityGroupIngress[] Ingress
        {
            get => GetInstanceProperty<aws.IDefaultSecurityGroupIngress[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "revokeRulesOnDelete", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RevokeRulesOnDelete
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DefaultSecurityGroupTimeouts\"}")]
        public virtual aws.IDefaultSecurityGroupTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IDefaultSecurityGroupTimeouts>()!;
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
