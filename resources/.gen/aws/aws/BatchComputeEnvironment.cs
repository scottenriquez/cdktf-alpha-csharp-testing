using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.BatchComputeEnvironment), fullyQualifiedName: "aws.BatchComputeEnvironment", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.BatchComputeEnvironmentConfig\"}}]")]
    public class BatchComputeEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        public BatchComputeEnvironment(Constructs.Construct scope, string id, aws.IBatchComputeEnvironmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputeEnvironmentName")]
        public virtual void ResetComputeEnvironmentName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeEnvironmentNamePrefix")]
        public virtual void ResetComputeEnvironmentNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeResources")]
        public virtual void ResetComputeResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
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

        [JsiiProperty(name: "eccClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EccClusterArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcsClusterArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeEnvironmentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeEnvironmentNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeResourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchComputeEnvironmentComputeResources\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IBatchComputeEnvironmentComputeResources[]? ComputeResourcesInput
        {
            get => GetInstanceProperty<aws.IBatchComputeEnvironmentComputeResources[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeEnvironmentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeEnvironmentNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeEnvironmentNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeResources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchComputeEnvironmentComputeResources\"},\"kind\":\"array\"}}")]
        public virtual aws.IBatchComputeEnvironmentComputeResources[] ComputeResources
        {
            get => GetInstanceProperty<aws.IBatchComputeEnvironmentComputeResources[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
