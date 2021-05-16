using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AlbListenerDefaultActionForward")]
    public class AlbListenerDefaultActionForward : aws.IAlbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAlbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AlbListenerDefaultActionForwardStickiness\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAlbListenerDefaultActionForwardStickiness[]? Stickiness
        {
            get;
            set;
        }
    }
}
