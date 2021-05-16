using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatement")]
    public class Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatement : aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementAndStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
