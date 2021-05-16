using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration
    {
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BufferInterval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BufferSize
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CompressionFormat
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
