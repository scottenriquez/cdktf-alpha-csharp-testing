using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions")]
    public interface IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions
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

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions
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
