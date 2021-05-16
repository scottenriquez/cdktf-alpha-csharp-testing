using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleConditionHttpRequestMethod), fullyQualifiedName: "aws.AlbListenerRuleConditionHttpRequestMethod")]
    public interface IAlbListenerRuleConditionHttpRequestMethod
    {
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleConditionHttpRequestMethod), fullyQualifiedName: "aws.AlbListenerRuleConditionHttpRequestMethod")]
        internal sealed class _Proxy : DeputyBase, aws.IAlbListenerRuleConditionHttpRequestMethod
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
