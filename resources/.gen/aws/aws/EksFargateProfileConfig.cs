using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EksFargateProfileConfig")]
    public class EksFargateProfileConfig : aws.IEksFargateProfileConfig
    {
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterName
        {
            get;
            set;
        }

        [JsiiProperty(name: "fargateProfileName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FargateProfileName
        {
            get;
            set;
        }

        [JsiiProperty(name: "podExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PodExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>selector block.</summary>
        [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksFargateProfileSelector\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IEksFargateProfileSelector[] Selector
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

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksFargateProfileTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IEksFargateProfileTimeouts? Timeouts
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
