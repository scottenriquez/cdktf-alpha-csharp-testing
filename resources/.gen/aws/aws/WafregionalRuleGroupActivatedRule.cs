using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafregionalRuleGroupActivatedRule")]
    public class WafregionalRuleGroupActivatedRule : aws.IWafregionalRuleGroupActivatedRule
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalRuleGroupActivatedRuleAction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafregionalRuleGroupActivatedRuleAction[] Action
        {
            get;
            set;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Priority
        {
            get;
            set;
        }

        [JsiiProperty(name: "ruleId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RuleId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
