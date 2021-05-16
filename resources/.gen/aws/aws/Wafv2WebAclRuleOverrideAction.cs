using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Wafv2WebAclRuleOverrideAction")]
    public class Wafv2WebAclRuleOverrideAction : aws.IWafv2WebAclRuleOverrideAction
    {
        /// <summary>count block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideActionCount\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleOverrideActionCount[]? Count
        {
            get;
            set;
        }

        /// <summary>none block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "none", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideActionNone\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWafv2WebAclRuleOverrideActionNone[]? None
        {
            get;
            set;
        }
    }
}
