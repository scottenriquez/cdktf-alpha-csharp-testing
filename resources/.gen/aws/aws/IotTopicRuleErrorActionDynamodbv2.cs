using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionDynamodbv2")]
    public class IotTopicRuleErrorActionDynamodbv2 : aws.IIotTopicRuleErrorActionDynamodbv2
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>put_item block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "putItem", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodbv2PutItem\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionDynamodbv2PutItem[]? PutItem
        {
            get;
            set;
        }
    }
}
