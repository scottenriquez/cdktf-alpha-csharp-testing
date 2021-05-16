using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncGraphqlApiLogConfig")]
    public class AppsyncGraphqlApiLogConfig : aws.IAppsyncGraphqlApiLogConfig
    {
        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CloudwatchLogsRoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FieldLogLevel
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ExcludeVerboseContent
        {
            get;
            set;
        }
    }
}
