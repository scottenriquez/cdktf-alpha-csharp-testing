using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2TrafficMirrorFilterRuleConfig")]
    public class Ec2TrafficMirrorFilterRuleConfig : aws.IEc2TrafficMirrorFilterRuleConfig
    {
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationCidrBlock
        {
            get;
            set;
        }

        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RuleAction
        {
            get;
            set;
        }

        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double RuleNumber
        {
            get;
            set;
        }

        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SourceCidrBlock
        {
            get;
            set;
        }

        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TrafficDirection
        {
            get;
            set;
        }

        [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TrafficMirrorFilterId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>destination_port_range block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleDestinationPortRange\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEc2TrafficMirrorFilterRuleDestinationPortRange[]? DestinationPortRange
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Protocol
        {
            get;
            set;
        }

        /// <summary>source_port_range block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2TrafficMirrorFilterRuleSourcePortRange\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEc2TrafficMirrorFilterRuleSourcePortRange[]? SourcePortRange
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
