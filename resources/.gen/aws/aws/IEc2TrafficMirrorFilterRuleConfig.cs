using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2TrafficMirrorFilterRuleConfig), fullyQualifiedName: "aws.Ec2TrafficMirrorFilterRuleConfig")]
    public interface IEc2TrafficMirrorFilterRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationCidrBlock
        {
            get;
        }

        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        string RuleAction
        {
            get;
        }

        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        double RuleNumber
        {
            get;
        }

        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string SourceCidrBlock
        {
            get;
        }

        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        string TrafficDirection
        {
            get;
        }

        [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}")]
        string TrafficMirrorFilterId
        {
            get;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_port_range block.</summary>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleDestinationPortRange\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]? DestinationPortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port_range block.</summary>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleSourcePortRange\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2TrafficMirrorFilterRuleConfig), fullyQualifiedName: "aws.Ec2TrafficMirrorFilterRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2TrafficMirrorFilterRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationCidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleAction
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceCidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
            public string TrafficDirection
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}")]
            public string TrafficMirrorFilterId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>destination_port_range block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleDestinationPortRange\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]? DestinationPortRange
            {
                get => GetInstanceProperty<aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Protocol
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_port_range block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleSourcePortRange\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]? SourcePortRange
            {
                get => GetInstanceProperty<aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
