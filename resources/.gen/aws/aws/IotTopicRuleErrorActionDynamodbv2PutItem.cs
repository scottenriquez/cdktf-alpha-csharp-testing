using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionDynamodbv2PutItem")]
    public class IotTopicRuleErrorActionDynamodbv2PutItem : aws.IIotTopicRuleErrorActionDynamodbv2PutItem
    {
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TableName
        {
            get;
            set;
        }
    }
}
