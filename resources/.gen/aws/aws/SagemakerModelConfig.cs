using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SagemakerModelConfig")]
    public class SagemakerModelConfig : aws.ISagemakerModelConfig
    {
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>container block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "container", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelContainer\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISagemakerModelContainer[]? Container
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableNetworkIsolation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>primary_container block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryContainer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelPrimaryContainer\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISagemakerModelPrimaryContainer[]? PrimaryContainer
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

        /// <summary>vpc_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelVpcConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISagemakerModelVpcConfig[]? VpcConfig
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
