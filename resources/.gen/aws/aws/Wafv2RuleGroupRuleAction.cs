using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2RuleGroupRuleAction")]
    public class Wafv2RuleGroupRuleAction : aws.IWafv2RuleGroupRuleAction
    {
        /// <summary>allow block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionAllow\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleActionAllow[]? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionBlock\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleActionBlock[]? Block
        {
            get;
            set;
        }

        /// <summary>count block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2RuleGroupRuleActionCount\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2RuleGroupRuleActionCount[]? Count
        {
            get;
            set;
        }
    }
}
