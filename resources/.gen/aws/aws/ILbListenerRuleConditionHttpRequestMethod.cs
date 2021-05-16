using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleConditionHttpRequestMethod), fullyQualifiedName: "aws.LbListenerRuleConditionHttpRequestMethod")]
    public interface ILbListenerRuleConditionHttpRequestMethod
    {
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleConditionHttpRequestMethod), fullyQualifiedName: "aws.LbListenerRuleConditionHttpRequestMethod")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleConditionHttpRequestMethod
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
