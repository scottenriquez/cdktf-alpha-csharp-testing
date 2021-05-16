using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamElasticsearchConfiguration
    {
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        string DomainArn
        {
            get;
        }

        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        string IndexName
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "bufferingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferingInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bufferingSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferingSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "indexRotationPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexRotationPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration[]? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BackupMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TypeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
            public string IndexName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "bufferingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferingInterval
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bufferingSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferingSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "indexRotationPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexRotationPeriod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>processing_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration[]? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryDuration
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BackupMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TypeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
