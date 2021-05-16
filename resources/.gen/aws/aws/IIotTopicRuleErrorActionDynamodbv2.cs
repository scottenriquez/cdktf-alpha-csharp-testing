using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionDynamodbv2), fullyQualifiedName: "aws.IotTopicRuleErrorActionDynamodbv2")]
    public interface IIotTopicRuleErrorActionDynamodbv2
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>put_item block.</summary>
        [JsiiProperty(name: "putItem", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodbv2PutItem\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionDynamodbv2PutItem[]? PutItem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionDynamodbv2), fullyQualifiedName: "aws.IotTopicRuleErrorActionDynamodbv2")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionDynamodbv2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>put_item block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "putItem", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodbv2PutItem\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionDynamodbv2PutItem[]? PutItem
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionDynamodbv2PutItem[]?>();
            }
        }
    }
}
