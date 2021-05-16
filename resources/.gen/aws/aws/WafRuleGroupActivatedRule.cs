using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafRuleGroupActivatedRule")]
    public class WafRuleGroupActivatedRule : aws.IWafRuleGroupActivatedRule
    {
        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafRuleGroupActivatedRuleAction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IWafRuleGroupActivatedRuleAction[] Action
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
