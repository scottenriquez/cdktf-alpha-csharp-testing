using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>processors block.</summary>
        [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessors[]? Processors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>processors block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessors[]? Processors
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessors[]?>();
            }
        }
    }
}
