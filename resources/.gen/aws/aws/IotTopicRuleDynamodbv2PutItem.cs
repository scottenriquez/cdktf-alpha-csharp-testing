using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleDynamodbv2PutItem")]
    public class IotTopicRuleDynamodbv2PutItem : aws.IIotTopicRuleDynamodbv2PutItem
    {
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TableName
        {
            get;
            set;
        }
    }
}
