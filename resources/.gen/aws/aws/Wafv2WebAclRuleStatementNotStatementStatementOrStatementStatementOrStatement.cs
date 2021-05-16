using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement : aws.IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementOrStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
