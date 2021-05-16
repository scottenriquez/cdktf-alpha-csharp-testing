using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatement : aws.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatement
    {
        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PositionalConstraint
        {
            get;
            set;
        }

        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SearchString
        {
            get;
            set;
        }

        /// <summary>text_transformation block.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementByteMatchStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
