using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.NetworkAclRuleConfig")]
    public class NetworkAclRuleConfig : aws.INetworkAclRuleConfig
    {
        [JsiiProperty(name: "networkAclId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NetworkAclId
        {
            get;
            set;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Protocol
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

        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Egress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FromPort
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IcmpCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IcmpType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Ipv6CidrBlock
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ToPort
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
