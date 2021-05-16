using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.WafregionalRuleGroupActivatedRuleAction")]
    public interface IWafregionalRuleGroupActivatedRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.WafregionalRuleGroupActivatedRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalRuleGroupActivatedRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
