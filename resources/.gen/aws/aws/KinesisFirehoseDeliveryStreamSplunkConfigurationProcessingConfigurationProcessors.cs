using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors")]
    public class KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors : aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters[]? Parameters
        {
            get;
            set;
        }
    }
}
