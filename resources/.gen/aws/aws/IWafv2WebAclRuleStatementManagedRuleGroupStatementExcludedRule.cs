using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
