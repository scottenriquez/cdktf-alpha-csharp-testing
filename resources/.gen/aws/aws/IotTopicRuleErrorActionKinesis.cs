using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionKinesis")]
    public class IotTopicRuleErrorActionKinesis : aws.IIotTopicRuleErrorActionKinesis
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StreamName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PartitionKey
        {
            get;
            set;
        }
    }
}
