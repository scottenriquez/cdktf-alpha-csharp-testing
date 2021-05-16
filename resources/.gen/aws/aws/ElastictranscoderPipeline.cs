using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPipeline), fullyQualifiedName: "aws.ElastictranscoderPipeline", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ElastictranscoderPipelineConfig\"}}]")]
    public class ElastictranscoderPipeline : HashiCorp.Cdktf.TerraformResource
    {
        public ElastictranscoderPipeline(Constructs.Construct scope, string id, aws.IElastictranscoderPipelineConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipeline(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAwsKmsKeyArn")]
        public virtual void ResetAwsKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentConfig")]
        public virtual void ResetContentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentConfigPermissions")]
        public virtual void ResetContentConfigPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotifications")]
        public virtual void ResetNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputBucket")]
        public virtual void ResetOutputBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailConfig")]
        public virtual void ResetThumbnailConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnailConfigPermissions")]
        public virtual void ResetThumbnailConfigPermissions()
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

        [JsiiProperty(name: "inputBucketInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputBucketInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsKmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsKmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPipelineContentConfig[]? ContentConfigInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineContentConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentConfigPermissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPipelineContentConfigPermissions[]? ContentConfigPermissionsInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineContentConfigPermissions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineNotifications\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPipelineNotifications[]? NotificationsInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineNotifications[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPipelineThumbnailConfig[]? ThumbnailConfigInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineThumbnailConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigPermissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElastictranscoderPipelineThumbnailConfigPermissions[]? ThumbnailConfigPermissionsInput
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineThumbnailConfigPermissions[]?>();
        }

        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsKmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPipelineContentConfig[] ContentConfig
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineContentConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPipelineContentConfigPermissions[] ContentConfigPermissions
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineContentConfigPermissions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputBucket
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

        [JsiiProperty(name: "notifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineNotifications\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPipelineNotifications[] Notifications
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineNotifications[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputBucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPipelineThumbnailConfig[] ThumbnailConfig
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineThumbnailConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElastictranscoderPipelineThumbnailConfigPermissions[] ThumbnailConfigPermissions
        {
            get => GetInstanceProperty<aws.IElastictranscoderPipelineThumbnailConfigPermissions[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
