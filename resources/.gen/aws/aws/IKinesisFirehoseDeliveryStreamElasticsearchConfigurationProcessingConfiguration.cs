using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration
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
        [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]? Processors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration
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
            [JsiiProperty(name: "processors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]? Processors
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors[]?>();
            }
        }
    }
}
