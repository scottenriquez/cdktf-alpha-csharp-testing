using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfiguration")]
    public class KinesisFirehoseDeliveryStreamElasticsearchConfiguration : aws.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration
    {
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IndexName
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
        [JsiiProperty(name: "bufferingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BufferingInterval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bufferingSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BufferingSize
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexRotationPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IndexRotationPeriod
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration[]? ProcessingConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RetryDuration
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

        [JsiiOptional]
        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TypeName
        {
            get;
            set;
        }
    }
}
