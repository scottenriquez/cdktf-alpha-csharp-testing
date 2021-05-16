using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleSns")]
    public class IotTopicRuleSns : aws.IIotTopicRuleSns
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TargetArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageFormat
        {
            get;
            set;
        }
    }
}
