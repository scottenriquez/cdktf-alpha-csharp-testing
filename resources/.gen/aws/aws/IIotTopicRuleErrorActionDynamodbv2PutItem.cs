using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionDynamodbv2PutItem), fullyQualifiedName: "aws.IotTopicRuleErrorActionDynamodbv2PutItem")]
    public interface IIotTopicRuleErrorActionDynamodbv2PutItem
    {
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionDynamodbv2PutItem), fullyQualifiedName: "aws.IotTopicRuleErrorActionDynamodbv2PutItem")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionDynamodbv2PutItem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
