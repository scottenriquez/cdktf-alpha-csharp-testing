using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionFirehose), fullyQualifiedName: "aws.IotTopicRuleErrorActionFirehose")]
    public interface IIotTopicRuleErrorActionFirehose
    {
        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
        string DeliveryStreamName
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Separator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionFirehose), fullyQualifiedName: "aws.IotTopicRuleErrorActionFirehose")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionFirehose
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeliveryStreamName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Separator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
