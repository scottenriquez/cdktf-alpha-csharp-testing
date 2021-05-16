using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.EcsTaskDefinition), fullyQualifiedName: "aws.EcsTaskDefinition", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.EcsTaskDefinitionConfig\"}}]")]
    public class EcsTaskDefinition : HashiCorp.Cdktf.TerraformResource
    {
        public EcsTaskDefinition(Constructs.Construct scope, string id, aws.IEcsTaskDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpu")]
        public virtual void ResetCpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRoleArn")]
        public virtual void ResetExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceAccelerator")]
        public virtual void ResetInferenceAccelerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpcMode")]
        public virtual void ResetIpcMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemory")]
        public virtual void ResetMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkMode")]
        public virtual void ResetNetworkMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPidMode")]
        public virtual void ResetPidMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraints")]
        public virtual void ResetPlacementConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyConfiguration")]
        public virtual void ResetProxyConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiresCompatibilities")]
        public virtual void ResetRequiresCompatibilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskRoleArn")]
        public virtual void ResetTaskRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolume")]
        public virtual void ResetVolume()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerDefinitionsInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDefinitionsInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "familyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FamilyInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Revision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceAcceleratorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsTaskDefinitionInferenceAccelerator[]? InferenceAcceleratorInput
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionInferenceAccelerator[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipcModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpcModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pidModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PidModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsTaskDefinitionPlacementConstraints[]? PlacementConstraintsInput
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionPlacementConstraints[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionProxyConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsTaskDefinitionProxyConfiguration[]? ProxyConfigurationInput
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionProxyConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiresCompatibilitiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RequiresCompatibilitiesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsTaskDefinitionVolume[]? VolumeInput
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionVolume[]?>();
        }

        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDefinitions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cpu
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Family
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsTaskDefinitionInferenceAccelerator[] InferenceAccelerator
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionInferenceAccelerator[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpcMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Memory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PidMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsTaskDefinitionPlacementConstraints[] PlacementConstraints
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionPlacementConstraints[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionProxyConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsTaskDefinitionProxyConfiguration[] ProxyConfiguration
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionProxyConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequiresCompatibilities
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsTaskDefinitionVolume[] Volume
        {
            get => GetInstanceProperty<aws.IEcsTaskDefinitionVolume[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
