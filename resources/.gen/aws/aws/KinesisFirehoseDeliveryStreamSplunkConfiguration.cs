using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamSplunkConfiguration")]
    public class KinesisFirehoseDeliveryStreamSplunkConfiguration : aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration
    {
        [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HecEndpoint
        {
            get;
            set;
        }

        [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HecToken
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HecAcknowledgmentTimeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HecEndpointType
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration[]? ProcessingConfiguration
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
    }
}
