using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatement : aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementNotStatementStatementNotStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
