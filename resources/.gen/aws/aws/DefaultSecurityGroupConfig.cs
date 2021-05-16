using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DefaultSecurityGroupConfig")]
    public class DefaultSecurityGroupConfig : aws.IDefaultSecurityGroupConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupEgress\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDefaultSecurityGroupEgress[]? Egress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultSecurityGroupIngress\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDefaultSecurityGroupIngress[]? Ingress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "revokeRulesOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RevokeRulesOnDelete
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DefaultSecurityGroupTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IDefaultSecurityGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VpcId
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
