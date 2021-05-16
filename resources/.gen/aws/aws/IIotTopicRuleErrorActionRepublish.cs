using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionRepublish), fullyQualifiedName: "aws.IotTopicRuleErrorActionRepublish")]
    public interface IIotTopicRuleErrorActionRepublish
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
        string Topic
        {
            get;
        }

        [JsiiProperty(name: "qos", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Qos
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionRepublish), fullyQualifiedName: "aws.IotTopicRuleErrorActionRepublish")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionRepublish
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}")]
            public string Topic
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "qos", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Qos
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
