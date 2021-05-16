using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatement")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementOrStatement : aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
