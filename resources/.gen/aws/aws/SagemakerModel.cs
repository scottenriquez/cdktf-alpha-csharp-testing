using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel), fullyQualifiedName: "aws.SagemakerModel", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SagemakerModelConfig\"}}]")]
    public class SagemakerModel : HashiCorp.Cdktf.TerraformResource
    {
        public SagemakerModel(Constructs.Construct scope, string id, aws.ISagemakerModelConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModel(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContainer")]
        public virtual void ResetContainer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableNetworkIsolation")]
        public virtual void ResetEnableNetworkIsolation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryContainer")]
        public virtual void ResetPrimaryContainer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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

        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelContainer\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISagemakerModelContainer[]? ContainerInput
        {
            get => GetInstanceProperty<aws.ISagemakerModelContainer[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableNetworkIsolationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableNetworkIsolationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryContainerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelPrimaryContainer\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISagemakerModelPrimaryContainer[]? PrimaryContainerInput
        {
            get => GetInstanceProperty<aws.ISagemakerModelPrimaryContainer[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISagemakerModelVpcConfig[]? VpcConfigInput
        {
            get => GetInstanceProperty<aws.ISagemakerModelVpcConfig[]?>();
        }

        [JsiiProperty(name: "container", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelContainer\"},\"kind\":\"array\"}}")]
        public virtual aws.ISagemakerModelContainer[] Container
        {
            get => GetInstanceProperty<aws.ISagemakerModelContainer[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableNetworkIsolation
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryContainer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelPrimaryContainer\"},\"kind\":\"array\"}}")]
        public virtual aws.ISagemakerModelPrimaryContainer[] PrimaryContainer
        {
            get => GetInstanceProperty<aws.ISagemakerModelPrimaryContainer[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SagemakerModelVpcConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ISagemakerModelVpcConfig[] VpcConfig
        {
            get => GetInstanceProperty<aws.ISagemakerModelVpcConfig[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
