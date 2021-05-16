using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafWebAclRulesAction), fullyQualifiedName: "aws.WafWebAclRulesAction")]
    public interface IWafWebAclRulesAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclRulesAction), fullyQualifiedName: "aws.WafWebAclRulesAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafWebAclRulesAction
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
