using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters")]
    public class KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters : aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters
    {
        [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ParameterName
        {
            get;
            set;
        }

        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ParameterValue
        {
            get;
            set;
        }
    }
}
