using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementRuleGroupReferenceStatement")]
    public class Wafv2WebAclRuleStatementRuleGroupReferenceStatement : aws.IWafv2WebAclRuleStatementRuleGroupReferenceStatement
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>excluded_rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementRuleGroupReferenceStatementExcludedRule[]? ExcludedRule
        {
            get;
            set;
        }
    }
}
