using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DefaultNetworkAclConfig")]
    public class DefaultNetworkAclConfig : aws.IDefaultNetworkAclConfig
    {
        [JsiiProperty(name: "defaultNetworkAclId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultNetworkAclId
        {
            get;
            set;
        }

        /// <summary>egress block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultNetworkAclEgress\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDefaultNetworkAclEgress[]? Egress
        {
            get;
            set;
        }

        /// <summary>ingress block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DefaultNetworkAclIngress\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDefaultNetworkAclIngress[]? Ingress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubnetIds
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
