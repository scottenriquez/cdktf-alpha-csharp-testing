using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterLoggingInfoBrokerLogsS3")]
    public class MskClusterLoggingInfoBrokerLogsS3 : aws.IMskClusterLoggingInfoBrokerLogsS3
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
