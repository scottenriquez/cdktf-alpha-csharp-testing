using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatement")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatement : aws.IWafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementNotStatementStatementSqliMatchStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
