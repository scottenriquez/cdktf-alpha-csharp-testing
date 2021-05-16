using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodebuildProjectLogsConfig")]
    public class CodebuildProjectLogsConfig : aws.ICodebuildProjectLogsConfig
    {
        /// <summary>cloudwatch_logs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfigCloudwatchLogs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectLogsConfigCloudwatchLogs[]? CloudwatchLogs
        {
            get;
            set;
        }

        /// <summary>s3_logs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfigS3Logs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectLogsConfigS3Logs[]? S3Logs
        {
            get;
            set;
        }
    }
}
