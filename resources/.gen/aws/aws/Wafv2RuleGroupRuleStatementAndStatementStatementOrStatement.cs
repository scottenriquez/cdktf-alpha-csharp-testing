using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement")]
    public class Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement : aws.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
