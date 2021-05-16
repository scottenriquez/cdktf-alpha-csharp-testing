using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclRuleOverrideAction), fullyQualifiedName: "aws.WafregionalWebAclRuleOverrideAction")]
    public interface IWafregionalWebAclRuleOverrideAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclRuleOverrideAction), fullyQualifiedName: "aws.WafregionalWebAclRuleOverrideAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalWebAclRuleOverrideAction
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
