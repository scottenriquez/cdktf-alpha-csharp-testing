using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementRateBasedStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatement : aws.IWafv2WebAclRuleStatementRateBasedStatement
    {
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Limit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AggregateKeyType
        {
            get;
            set;
        }

        /// <summary>scope_down_statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement[]? ScopeDownStatement
        {
            get;
            set;
        }
    }
}
