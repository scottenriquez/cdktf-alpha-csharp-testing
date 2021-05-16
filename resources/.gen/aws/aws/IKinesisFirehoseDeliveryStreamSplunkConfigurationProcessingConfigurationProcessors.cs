using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors")]
    public interface IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>parameters block.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters[]? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters[]? Parameters
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters[]?>();
            }
        }
    }
}
