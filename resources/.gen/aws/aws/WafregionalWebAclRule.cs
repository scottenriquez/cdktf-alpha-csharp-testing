using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WafregionalWebAclRule")]
    public class WafregionalWebAclRule : aws.IWafregionalWebAclRule
    {
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

        /// <summary>action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRuleAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafregionalWebAclRuleAction[]? Action
        {
            get;
            set;
        }

        /// <summary>override_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrideAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRuleOverrideAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafregionalWebAclRuleOverrideAction[]? OverrideAction
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
