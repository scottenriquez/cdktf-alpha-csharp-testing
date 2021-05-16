using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DatasyncLocationS3), fullyQualifiedName: "aws.DatasyncLocationS3", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DatasyncLocationS3Config\"}}]")]
    public class DatasyncLocationS3 : HashiCorp.Cdktf.TerraformResource
    {
        public DatasyncLocationS3(Constructs.Construct scope, string id, aws.IDatasyncLocationS3Config config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationS3(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationS3(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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

        [JsiiProperty(name: "s3BucketArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BucketArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3ConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationS3S3Config\"},\"kind\":\"array\"}}")]
        public virtual aws.IDatasyncLocationS3S3Config[] S3ConfigInput
        {
            get => GetInstanceProperty<aws.IDatasyncLocationS3S3Config[]>()!;
        }

        [JsiiProperty(name: "subdirectoryInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubdirectoryInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "s3BucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BucketArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Config", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationS3S3Config\"},\"kind\":\"array\"}}")]
        public virtual aws.IDatasyncLocationS3S3Config[] S3Config
        {
            get => GetInstanceProperty<aws.IDatasyncLocationS3S3Config[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdirectory
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
    }
}
