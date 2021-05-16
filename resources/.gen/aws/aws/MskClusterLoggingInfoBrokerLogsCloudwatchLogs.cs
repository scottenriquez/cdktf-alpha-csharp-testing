using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterLoggingInfoBrokerLogsCloudwatchLogs")]
    public class MskClusterLoggingInfoBrokerLogsCloudwatchLogs : aws.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogGroup
        {
            get;
            set;
        }
    }
}
