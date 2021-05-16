using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3Configuration")]
    public class KinesisFirehoseDeliveryStreamExtendedS3Configuration : aws.IKinesisFirehoseDeliveryStreamExtendedS3Configuration
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
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
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

        /// <summary>data_format_conversion_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFormatConversionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration[]? DataFormatConversionConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ErrorOutputPrefix
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

        /// <summary>processing_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration[]? ProcessingConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_backup_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BackupConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationS3BackupConfiguration[]? S3BackupConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3BackupMode
        {
            get;
            set;
        }
    }
}
