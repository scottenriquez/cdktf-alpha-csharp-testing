using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionIotEvents")]
    public class IotTopicRuleErrorActionIotEvents : aws.IIotTopicRuleErrorActionIotEvents
    {
        [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InputName
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MessageId
        {
            get;
            set;
        }
    }
}
