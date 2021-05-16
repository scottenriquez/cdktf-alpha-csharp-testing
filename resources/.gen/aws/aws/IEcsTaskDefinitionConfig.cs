using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionConfig), fullyQualifiedName: "aws.EcsTaskDefinitionConfig")]
    public interface IEcsTaskDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerDefinitions
        {
            get;
        }

        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        string Family
        {
            get;
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cpu
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>inference_accelerator block.</summary>
        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionInferenceAccelerator[]? InferenceAccelerator
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpcMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Memory
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PidMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_constraints block.</summary>
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionPlacementConstraints[]? PlacementConstraints
        {
            get
            {
                return null;
            }
        }

        /// <summary>proxy_configuration block.</summary>
        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionProxyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionProxyConfiguration[]? ProxyConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RequiresCompatibilities
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>volume block.</summary>
        [JsiiProperty(name: "volume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsTaskDefinitionVolume[]? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionConfig), fullyQualifiedName: "aws.EcsTaskDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsTaskDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerDefinitions
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
            public string Family
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cpu
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>inference_accelerator block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionInferenceAccelerator[]? InferenceAccelerator
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionInferenceAccelerator[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpcMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Memory
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PidMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>placement_constraints block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionPlacementConstraints[]? PlacementConstraints
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionPlacementConstraints[]?>();
            }

            /// <summary>proxy_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionProxyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionProxyConfiguration[]? ProxyConfiguration
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionProxyConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RequiresCompatibilities
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volume block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsTaskDefinitionVolume[]? Volume
            {
                get => GetInstanceProperty<aws.IEcsTaskDefinitionVolume[]?>();
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
