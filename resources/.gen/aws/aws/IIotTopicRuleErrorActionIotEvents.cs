using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionIotEvents), fullyQualifiedName: "aws.IotTopicRuleErrorActionIotEvents")]
    public interface IIotTopicRuleErrorActionIotEvents
    {
        [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}")]
        string InputName
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionIotEvents), fullyQualifiedName: "aws.IotTopicRuleErrorActionIotEvents")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionIotEvents
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}")]
            public string InputName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
