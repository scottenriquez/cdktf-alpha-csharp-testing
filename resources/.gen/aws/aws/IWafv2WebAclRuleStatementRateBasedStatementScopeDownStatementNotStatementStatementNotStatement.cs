using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatement[]>()!;
            }
        }
    }
}
