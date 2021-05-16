using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsTaskDefinitionConfig")]
    public class EcsTaskDefinitionConfig : aws.IEcsTaskDefinitionConfig
    {
        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ContainerDefinitions
        {
            get;
            set;
        }

        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Family
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Cpu
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>inference_accelerator block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionInferenceAccelerator[]? InferenceAccelerator
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IpcMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Memory
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NetworkMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PidMode
        {
            get;
            set;
        }

        /// <summary>placement_constraints block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionPlacementConstraints[]? PlacementConstraints
        {
            get;
            set;
        }

        /// <summary>proxy_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionProxyConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionProxyConfiguration[]? ProxyConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? RequiresCompatibilities
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

        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TaskRoleArn
        {
            get;
            set;
        }

        /// <summary>volume block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsTaskDefinitionVolume[]? Volume
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
