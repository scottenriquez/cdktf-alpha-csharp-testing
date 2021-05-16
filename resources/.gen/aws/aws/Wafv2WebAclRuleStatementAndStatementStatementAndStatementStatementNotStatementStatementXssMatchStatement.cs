using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatement")]
    public class Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatement : aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
