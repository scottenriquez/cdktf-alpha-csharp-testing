using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleIotAnalytics), fullyQualifiedName: "aws.IotTopicRuleIotAnalytics")]
    public interface IIotTopicRuleIotAnalytics
    {
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        string ChannelName
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleIotAnalytics), fullyQualifiedName: "aws.IotTopicRuleIotAnalytics")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleIotAnalytics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
            public string ChannelName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
