using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleDynamodbv2PutItem), fullyQualifiedName: "aws.IotTopicRuleDynamodbv2PutItem")]
    public interface IIotTopicRuleDynamodbv2PutItem
    {
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleDynamodbv2PutItem), fullyQualifiedName: "aws.IotTopicRuleDynamodbv2PutItem")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleDynamodbv2PutItem
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
