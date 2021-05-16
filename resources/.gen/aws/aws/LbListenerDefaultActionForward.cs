using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerDefaultActionForward")]
    public class LbListenerDefaultActionForward : aws.ILbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ILbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbListenerDefaultActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbListenerDefaultActionForwardStickiness[]? Stickiness
        {
            get;
            set;
        }
    }
}
