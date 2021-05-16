using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters
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
