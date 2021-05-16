using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.OpsworksPermissionConfig")]
    public class OpsworksPermissionConfig : aws.IOpsworksPermissionConfig
    {
        [JsiiProperty(name: "userArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowSsh", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowSsh
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowSudo", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowSudo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Level
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StackId
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
