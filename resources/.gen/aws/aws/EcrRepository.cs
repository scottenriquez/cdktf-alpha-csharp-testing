using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.EcrRepository), fullyQualifiedName: "aws.EcrRepository", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.EcrRepositoryConfig\"}}]")]
    public class EcrRepository : HashiCorp.Cdktf.TerraformResource
    {
        public EcrRepository(Constructs.Construct scope, string id, aws.IEcrRepositoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrRepository(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrRepository(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetImageScanningConfiguration")]
        public virtual void ResetImageScanningConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageTagMutability")]
        public virtual void ResetImageTagMutability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageScanningConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcrRepositoryImageScanningConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcrRepositoryImageScanningConfiguration[]? ImageScanningConfigurationInput
        {
            get => GetInstanceProperty<aws.IEcrRepositoryImageScanningConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageTagMutabilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageTagMutabilityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.EcrRepositoryTimeouts\"}", isOptional: true)]
        public virtual aws.IEcrRepositoryTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IEcrRepositoryTimeouts?>();
        }

        [JsiiProperty(name: "imageScanningConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcrRepositoryImageScanningConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcrRepositoryImageScanningConfiguration[] ImageScanningConfiguration
        {
            get => GetInstanceProperty<aws.IEcrRepositoryImageScanningConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageTagMutability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageTagMutability
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EcrRepositoryTimeouts\"}")]
        public virtual aws.IEcrRepositoryTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IEcrRepositoryTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
