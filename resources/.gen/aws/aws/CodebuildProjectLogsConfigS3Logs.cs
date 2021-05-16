using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodebuildProjectLogsConfigS3Logs")]
    public class CodebuildProjectLogsConfigS3Logs : aws.ICodebuildProjectLogsConfigS3Logs
    {
        [JsiiOptional]
        [JsiiProperty(name: "encryptionDisabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EncryptionDisabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Location
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
    }
}
