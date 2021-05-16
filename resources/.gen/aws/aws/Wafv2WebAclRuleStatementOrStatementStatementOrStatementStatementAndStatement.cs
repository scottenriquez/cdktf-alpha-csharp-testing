using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatement : aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementAndStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
