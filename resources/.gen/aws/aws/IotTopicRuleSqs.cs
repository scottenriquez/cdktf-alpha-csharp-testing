using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleSqs")]
    public class IotTopicRuleSqs : aws.IIotTopicRuleSqs
    {
        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string QueueUrl
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

        [JsiiProperty(name: "useBase64", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool UseBase64
        {
            get;
            set;
        }
    }
}
