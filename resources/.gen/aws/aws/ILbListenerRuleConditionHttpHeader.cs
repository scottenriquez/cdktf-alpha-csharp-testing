using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleConditionHttpHeader), fullyQualifiedName: "aws.LbListenerRuleConditionHttpHeader")]
    public interface ILbListenerRuleConditionHttpHeader
    {
        [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        string HttpHeaderName
        {
            get;
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleConditionHttpHeader), fullyQualifiedName: "aws.LbListenerRuleConditionHttpHeader")]
        internal sealed class _Proxy : DeputyBase, aws.ILbListenerRuleConditionHttpHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpHeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
