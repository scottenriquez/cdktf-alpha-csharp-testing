using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclRuleAction), fullyQualifiedName: "aws.WafregionalWebAclRuleAction")]
    public interface IWafregionalWebAclRuleAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclRuleAction), fullyQualifiedName: "aws.WafregionalWebAclRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalWebAclRuleAction
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
