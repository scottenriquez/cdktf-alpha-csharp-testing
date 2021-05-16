using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.NetworkAclRule), fullyQualifiedName: "aws.NetworkAclRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.NetworkAclRuleConfig\"}}]")]
    public class NetworkAclRule : HashiCorp.Cdktf.TerraformResource
    {
        public NetworkAclRule(Constructs.Construct scope, string id, aws.INetworkAclRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkAclRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkAclRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCidrBlock")]
        public virtual void ResetCidrBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEgress")]
        public virtual void ResetEgress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromPort")]
        public virtual void ResetFromPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpCode")]
        public virtual void ResetIcmpCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcmpType")]
        public virtual void ResetIcmpType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6CidrBlock")]
        public virtual void ResetIpv6CidrBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToPort")]
        public virtual void ResetToPort()
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

        [JsiiProperty(name: "networkAclIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAclIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleActionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleActionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleNumberInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuleNumberInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EgressInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FromPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IcmpCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IcmpTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6CidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ipv6CidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ToPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "egress", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Egress
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FromPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IcmpCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IcmpType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6CidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkAclId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAclId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuleNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ToPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
