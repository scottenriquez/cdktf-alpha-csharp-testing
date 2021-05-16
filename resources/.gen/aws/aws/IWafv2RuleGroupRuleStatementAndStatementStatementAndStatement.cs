using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatement")]
    public interface IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement), fullyQualifiedName: "aws.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2RuleGroupRuleStatementAndStatementStatementAndStatementStatement[]>()!;
            }
        }
    }
}
