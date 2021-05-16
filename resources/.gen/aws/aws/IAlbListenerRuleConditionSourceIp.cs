using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleConditionSourceIp), fullyQualifiedName: "aws.AlbListenerRuleConditionSourceIp")]
    public interface IAlbListenerRuleConditionSourceIp
    {
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleConditionSourceIp), fullyQualifiedName: "aws.AlbListenerRuleConditionSourceIp")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerRuleConditionSourceIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
