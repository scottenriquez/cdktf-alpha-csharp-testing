using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatement")]
    public class Wafv2RuleGroupRuleStatementOrStatementStatementNotStatement : aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementNotStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
