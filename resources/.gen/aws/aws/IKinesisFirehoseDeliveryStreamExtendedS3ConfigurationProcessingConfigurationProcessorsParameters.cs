using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters
    {
        [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterName
        {
            get;
        }

        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorsParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
