using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader
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
