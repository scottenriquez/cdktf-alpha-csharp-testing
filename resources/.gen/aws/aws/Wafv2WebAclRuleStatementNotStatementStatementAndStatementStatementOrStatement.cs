using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatement : aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
