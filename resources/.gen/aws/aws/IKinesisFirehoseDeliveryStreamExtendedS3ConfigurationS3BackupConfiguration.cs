using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration
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
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
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

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration
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
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionFormat
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
        }
    }
}
