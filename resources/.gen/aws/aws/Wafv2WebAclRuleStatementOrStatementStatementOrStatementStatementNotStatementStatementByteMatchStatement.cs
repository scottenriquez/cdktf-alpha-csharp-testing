using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatement : aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatement
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
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatementFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementByteMatchStatementFieldToMatch[]? FieldToMatch
        {
            get;
            set;
        }
    }
}
