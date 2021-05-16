using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamConfig), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamConfig")]
    public interface IKinesisFirehoseDeliveryStreamConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_configuration block.</summary>
        [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[]? ElasticsearchConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>extended_s3_configuration block.</summary>
        [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[]? ExtendedS3Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_source_configuration block.</summary>
        [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[]? KinesisSourceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift_configuration block.</summary>
        [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[]? RedshiftConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_configuration block.</summary>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamS3Configuration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamS3Configuration[]? S3Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_side_encryption block.</summary>
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[]? ServerSideEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>splunk_configuration block.</summary>
        [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[]? SplunkConfiguration
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

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamConfig), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>elasticsearch_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[]? ElasticsearchConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration[]?>();
            }

            /// <summary>extended_s3_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[]? ExtendedS3Configuration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration[]?>();
            }

            /// <summary>kinesis_source_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[]? KinesisSourceConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration[]?>();
            }

            /// <summary>redshift_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[]? RedshiftConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamRedshiftConfiguration[]?>();
            }

            /// <summary>s3_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamS3Configuration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamS3Configuration[]? S3Configuration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamS3Configuration[]?>();
            }

            /// <summary>server_side_encryption block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[]? ServerSideEncryption
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamServerSideEncryption[]?>();
            }

            /// <summary>splunk_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[]? SplunkConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionId
            {
                get => GetInstanceProperty<string?>();
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
