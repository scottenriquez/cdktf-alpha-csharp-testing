using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerRuleActionForward")]
    public class AlbListenerRuleActionForward : aws.IAlbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAlbListenerRuleActionForwardTargetGroup[] TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerRuleActionForwardStickiness[]? Stickiness
        {
            get;
            set;
        }
    }
}
