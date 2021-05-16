using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration")]
    public class KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration : aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>processors block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors[]? Processors
        {
            get;
            set;
        }
    }
}
