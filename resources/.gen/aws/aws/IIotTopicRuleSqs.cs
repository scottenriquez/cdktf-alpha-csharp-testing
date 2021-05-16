using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleSqs), fullyQualifiedName: "aws.IotTopicRuleSqs")]
    public interface IIotTopicRuleSqs
    {
        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
        string QueueUrl
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "useBase64", typeJson: "{\"primitive\":\"boolean\"}")]
        bool UseBase64
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleSqs), fullyQualifiedName: "aws.IotTopicRuleSqs")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleSqs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "useBase64", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool UseBase64
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
