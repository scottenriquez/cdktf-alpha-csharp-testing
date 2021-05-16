using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Ec2TrafficMirrorFilterRule), fullyQualifiedName: "aws.Ec2TrafficMirrorFilterRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleConfig\"}}]")]
    public class Ec2TrafficMirrorFilterRule : HashiCorp.Cdktf.TerraformResource
    {
        public Ec2TrafficMirrorFilterRule(Constructs.Construct scope, string id, aws.IEc2TrafficMirrorFilterRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TrafficMirrorFilterRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TrafficMirrorFilterRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationPortRange")]
        public virtual void ResetDestinationPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "destinationCidrBlockInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidrBlockInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "sourceCidrBlockInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidrBlockInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trafficDirectionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficDirectionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trafficMirrorFilterIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficMirrorFilterIdInput
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
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleDestinationPortRange\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]? DestinationPortRangeInput
        {
            get => GetInstanceProperty<aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProtocolInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleSourcePortRange\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]? SourcePortRangeInput
        {
            get => GetInstanceProperty<aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleDestinationPortRange\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[] DestinationPortRange
        {
            get => GetInstanceProperty<aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Protocol
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleSourcePortRange\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2TrafficMirrorFilterRuleSourcePortRange[] SourcePortRange
        {
            get => GetInstanceProperty<aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficDirection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficMirrorFilterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
