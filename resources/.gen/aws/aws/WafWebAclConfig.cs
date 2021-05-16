using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafWebAclConfig")]
    public class WafWebAclConfig : aws.IWafWebAclConfig
    {
        /// <summary>default_action block.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclDefaultAction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafWebAclDefaultAction[] DefaultAction
        {
            get;
            set;
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricName
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>logging_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafWebAclLoggingConfiguration[]? LoggingConfiguration
        {
            get;
            set;
        }

        /// <summary>rules block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclRules\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafWebAclRules[]? Rules
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
