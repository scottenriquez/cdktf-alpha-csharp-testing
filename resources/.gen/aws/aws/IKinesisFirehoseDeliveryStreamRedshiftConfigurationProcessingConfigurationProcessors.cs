using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors")]
    public interface IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>parameters block.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorsParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorsParameters[]? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessors
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
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorsParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorsParameters[]? Parameters
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorsParameters[]?>();
            }
        }
    }
}
