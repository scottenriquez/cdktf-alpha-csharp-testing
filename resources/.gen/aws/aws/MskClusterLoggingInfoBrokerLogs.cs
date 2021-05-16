using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MskClusterLoggingInfoBrokerLogs")]
    public class MskClusterLoggingInfoBrokerLogs : aws.IMskClusterLoggingInfoBrokerLogs
    {
        /// <summary>cloudwatch_logs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs[]? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsFirehose\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterLoggingInfoBrokerLogsFirehose[]? Firehose
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogsS3\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterLoggingInfoBrokerLogsS3[]? S3
        {
            get;
            set;
        }
    }
}
