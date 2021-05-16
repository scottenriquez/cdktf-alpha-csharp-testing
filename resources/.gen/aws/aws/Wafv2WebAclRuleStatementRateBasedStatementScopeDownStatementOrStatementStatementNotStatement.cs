using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatement : aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
