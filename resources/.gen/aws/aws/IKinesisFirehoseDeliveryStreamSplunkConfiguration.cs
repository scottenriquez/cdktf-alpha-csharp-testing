using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamSplunkConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamSplunkConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamSplunkConfiguration
    {
        [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string HecEndpoint
        {
            get;
        }

        [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}")]
        string HecToken
        {
            get;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HecAcknowledgmentTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HecEndpointType
        {
            get
            {
                return null;
            }
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration[]? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BackupMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamSplunkConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamSplunkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamSplunkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "hecEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string HecEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "hecToken", typeJson: "{\"primitive\":\"string\"}")]
            public string HecToken
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions[]? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hecAcknowledgmentTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HecAcknowledgmentTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hecEndpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HecEndpointType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>processing_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration[]? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "retryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryDuration
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3BackupMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BackupMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
