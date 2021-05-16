using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3Configuration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3Configuration
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketArn
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_format_conversion_configuration block.</summary>
        [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration[]? DataFormatConversionConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorOutputPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration[]? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_backup_configuration block.</summary>
        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration[]? S3BackupConfiguration
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

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3Configuration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferInterval
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>data_format_conversion_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration[]? DataFormatConversionConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorOutputPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>processing_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration[]? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration[]?>();
            }

            /// <summary>s3_backup_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration[]? S3BackupConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BackupMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
