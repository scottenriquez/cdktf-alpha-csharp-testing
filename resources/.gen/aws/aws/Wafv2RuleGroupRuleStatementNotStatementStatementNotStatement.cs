using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatement")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementNotStatement : aws.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
