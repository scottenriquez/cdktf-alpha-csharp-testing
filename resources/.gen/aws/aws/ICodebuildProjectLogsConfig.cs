using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectLogsConfig), fullyQualifiedName: "aws.CodebuildProjectLogsConfig")]
    public interface ICodebuildProjectLogsConfig
    {
        /// <summary>cloudwatch_logs block.</summary>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfigCloudwatchLogs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectLogsConfigCloudwatchLogs[]? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_logs block.</summary>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfigS3Logs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectLogsConfigS3Logs[]? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectLogsConfig), fullyQualifiedName: "aws.CodebuildProjectLogsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectLogsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfigCloudwatchLogs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectLogsConfigCloudwatchLogs[]? CloudwatchLogs
            {
                get => GetInstanceProperty<aws.ICodebuildProjectLogsConfigCloudwatchLogs[]?>();
            }

            /// <summary>s3_logs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfigS3Logs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectLogsConfigS3Logs[]? S3Logs
            {
                get => GetInstanceProperty<aws.ICodebuildProjectLogsConfigS3Logs[]?>();
            }
        }
    }
}
