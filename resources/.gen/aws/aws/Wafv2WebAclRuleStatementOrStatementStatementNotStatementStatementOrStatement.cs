using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatement : aws.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
