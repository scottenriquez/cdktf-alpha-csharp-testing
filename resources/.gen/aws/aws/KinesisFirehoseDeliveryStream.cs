using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.KinesisFirehoseDeliveryStream), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStream", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamConfig\"}}]")]
    public class KinesisFirehoseDeliveryStream : HashiCorp.Cdktf.TerraformResource
    {
        public KinesisFirehoseDeliveryStream(Constructs.Construct scope, string id, aws.IKinesisFirehoseDeliveryStreamConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStream(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStream(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDestinationId")]
        public virtual void ResetDestinationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchConfiguration")]
        public virtual void ResetElasticsearchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendedS3Configuration")]
        public virtual void ResetExtendedS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisSourceConfiguration")]
        public virtual void ResetKinesisSourceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftConfiguration")]
        public virtual void ResetRedshiftConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Configuration")]
        public virtual void ResetS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSplunkConfiguration")]
        public virtual void ResetSplunkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionId")]
        public virtual void ResetVersionId()
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

        [JsiiProperty(name: "destinationInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationInput
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

        [JsiiOptional]
        [JsiiProperty(name: "destinationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[]? ElasticsearchConfigurationInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedS3ConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[]? ExtendedS3ConfigurationInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisSourceConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[]? KinesisSourceConfigurationInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[]? RedshiftConfigurationInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamS3Configuration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamS3Configuration[]? S3ConfigurationInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamS3Configuration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[]? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "splunkConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[]? SplunkConfigurationInput
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Destination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[] ElasticsearchConfiguration
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[] ExtendedS3Configuration
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[] KinesisSourceConfiguration
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[] RedshiftConfiguration
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamS3Configuration\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamS3Configuration[] S3Configuration
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamS3Configuration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamServerSideEncryption\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[] ServerSideEncryption
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[] SplunkConfiguration
        {
            get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
