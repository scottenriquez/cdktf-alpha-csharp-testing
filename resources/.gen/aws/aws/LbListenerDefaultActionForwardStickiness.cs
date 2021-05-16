using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LbListenerDefaultActionForwardStickiness")]
    public class LbListenerDefaultActionForwardStickiness : aws.ILbListenerDefaultActionForwardStickiness
    {
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Duration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }
    }
}
