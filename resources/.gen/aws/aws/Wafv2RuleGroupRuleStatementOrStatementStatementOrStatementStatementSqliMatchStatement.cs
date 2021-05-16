using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatement")]
    public class Wafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatement : aws.IWafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleStatementOrStatementStatementOrStatementStatementSqliMatchStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
