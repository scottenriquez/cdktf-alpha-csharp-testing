using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions")]
    public class KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions : aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogGroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logStreamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogStreamName
        {
            get;
            set;
        }
    }
}
