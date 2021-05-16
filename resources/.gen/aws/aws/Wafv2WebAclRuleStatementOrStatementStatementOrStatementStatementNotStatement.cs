using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatement : aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
