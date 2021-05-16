using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfoBrokerLogs), fullyQualifiedName: "aws.MskClusterLoggingInfoBrokerLogs")]
    public interface IMskClusterLoggingInfoBrokerLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs[]? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterLoggingInfoBrokerLogsFirehose[]? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsS3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterLoggingInfoBrokerLogsS3[]? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfoBrokerLogs), fullyQualifiedName: "aws.MskClusterLoggingInfoBrokerLogs")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterLoggingInfoBrokerLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs[]? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs[]?>();
            }

            /// <summary>firehose block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterLoggingInfoBrokerLogsFirehose[]? Firehose
            {
                get => GetInstanceProperty<aws.IMskClusterLoggingInfoBrokerLogsFirehose[]?>();
            }

            /// <summary>s3 block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsS3\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterLoggingInfoBrokerLogsS3[]? S3
            {
                get => GetInstanceProperty<aws.IMskClusterLoggingInfoBrokerLogsS3[]?>();
            }
        }
    }
}
