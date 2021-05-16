using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleSns), fullyQualifiedName: "aws.IotTopicRuleSns")]
    public interface IIotTopicRuleSns
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetArn
        {
            get;
        }

        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleSns), fullyQualifiedName: "aws.IotTopicRuleSns")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleSns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageFormat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
