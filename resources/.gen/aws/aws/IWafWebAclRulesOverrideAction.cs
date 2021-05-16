using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafWebAclRulesOverrideAction), fullyQualifiedName: "aws.WafWebAclRulesOverrideAction")]
    public interface IWafWebAclRulesOverrideAction
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclRulesOverrideAction), fullyQualifiedName: "aws.WafWebAclRulesOverrideAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafWebAclRulesOverrideAction
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
