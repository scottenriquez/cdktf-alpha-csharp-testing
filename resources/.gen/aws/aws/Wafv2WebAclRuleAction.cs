using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleAction")]
    public class Wafv2WebAclRuleAction : aws.IWafv2WebAclRuleAction
    {
        /// <summary>allow block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionAllow\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleActionAllow[]? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionBlock\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleActionBlock[]? Block
        {
            get;
            set;
        }

        /// <summary>count block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionCount\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleActionCount[]? Count
        {
            get;
            set;
        }
    }
}
