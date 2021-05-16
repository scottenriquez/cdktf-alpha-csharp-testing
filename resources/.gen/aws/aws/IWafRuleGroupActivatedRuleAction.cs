using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.WafRuleGroupActivatedRuleAction")]
    public interface IWafRuleGroupActivatedRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafRuleGroupActivatedRuleAction), fullyQualifiedName: "aws.WafRuleGroupActivatedRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafRuleGroupActivatedRuleAction
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
