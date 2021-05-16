using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatement")]
    public class Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatement : aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatement
    {
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ComparisonOperator
        {
            get;
            set;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Size
        {
            get;
            set;
        }

        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatementSizeConstraintStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
