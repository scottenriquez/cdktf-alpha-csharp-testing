using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleDynamodbv2")]
    public class IotTopicRuleDynamodbv2 : aws.IIotTopicRuleDynamodbv2
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>put_item block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "putItem", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodbv2PutItem\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleDynamodbv2PutItem[]? PutItem
        {
            get;
            set;
        }
    }
}
