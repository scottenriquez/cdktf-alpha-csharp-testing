using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerRuleActionForward")]
    public class LbListenerRuleActionForward : aws.ILbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ILbListenerRuleActionForwardTargetGroup[] TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerRuleActionForwardStickiness[]? Stickiness
        {
            get;
            set;
        }
    }
}
