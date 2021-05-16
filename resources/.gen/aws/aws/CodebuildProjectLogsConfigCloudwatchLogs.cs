using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodebuildProjectLogsConfigCloudwatchLogs")]
    public class CodebuildProjectLogsConfigCloudwatchLogs : aws.ICodebuildProjectLogsConfigCloudwatchLogs
    {
        [JsiiOptional]
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Status
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StreamName
        {
            get;
            set;
        }
    }
}
