using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement")]
    public class Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement : aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementAndStatementStatementAndStatementStatementAndStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
