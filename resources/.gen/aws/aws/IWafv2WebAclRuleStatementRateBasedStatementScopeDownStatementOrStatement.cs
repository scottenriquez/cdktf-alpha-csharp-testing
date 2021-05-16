using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatement[]>()!;
            }
        }
    }
}
