using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatement")]
    public interface IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement[]>()!;
            }
        }
    }
}
