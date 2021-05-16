using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleRepublish")]
    public class IotTopicRuleRepublish : aws.IIotTopicRuleRepublish
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Topic
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "qos", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Qos
        {
            get;
            set;
        }
    }
}
