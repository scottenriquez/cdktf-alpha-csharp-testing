using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration")]
    public class KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration : aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration
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
        [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]? Processors
        {
            get;
            set;
        }
    }
}
