using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafRulePredicates), fullyQualifiedName: "aws.WafRulePredicates")]
    public interface IWafRulePredicates
    {
        [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}")]
        string DataId
        {
            get;
        }

        [JsiiProperty(name: "negated", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Negated
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRulePredicates), fullyQualifiedName: "aws.WafRulePredicates")]
        internal sealed class _Proxy : DeputyBase, aws.IWafRulePredicates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "dataId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "negated", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Negated
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
