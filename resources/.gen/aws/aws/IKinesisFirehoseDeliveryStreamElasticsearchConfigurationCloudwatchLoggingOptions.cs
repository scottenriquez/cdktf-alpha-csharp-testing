using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions")]
    public interface IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions
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

        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "logStreamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogStreamName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationCloudwatchLoggingOptions
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

            [JsiiOptional]
            [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "logStreamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogStreamName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
