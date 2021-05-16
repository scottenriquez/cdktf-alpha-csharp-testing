using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEcrImage), fullyQualifiedName: "aws.DataAwsEcrImage", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsEcrImageConfig\"}}]")]
    public class DataAwsEcrImage : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsEcrImage(Constructs.Construct scope, string id, aws.IDataAwsEcrImageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcrImage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcrImage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetImageDigest")]
        public virtual void ResetImageDigest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageTag")]
        public virtual void ResetImageTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryId")]
        public virtual void ResetRegistryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imagePushedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImagePushedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "imageSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImageSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "imageTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ImageTags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "repositoryNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageDigestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageDigestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageTag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
