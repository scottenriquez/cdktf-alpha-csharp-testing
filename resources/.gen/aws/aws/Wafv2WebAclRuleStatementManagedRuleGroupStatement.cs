using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatement : aws.IWafv2WebAclRuleStatementManagedRuleGroupStatement
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VendorName
        {
            get;
            set;
        }

        /// <summary>excluded_rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule[]? ExcludedRule
        {
            get;
            set;
        }
    }
}
