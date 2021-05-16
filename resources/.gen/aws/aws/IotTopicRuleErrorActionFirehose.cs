using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionFirehose")]
    public class IotTopicRuleErrorActionFirehose : aws.IIotTopicRuleErrorActionFirehose
    {
        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeliveryStreamName
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
        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Separator
        {
            get;
            set;
        }
    }
}
