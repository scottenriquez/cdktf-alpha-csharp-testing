using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatement : aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementXssMatchStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
