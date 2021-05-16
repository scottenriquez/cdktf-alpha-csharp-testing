using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.RdsClusterScalingConfiguration")]
    public class RdsClusterScalingConfiguration : aws.IRdsClusterScalingConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "autoPause", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AutoPause
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondsUntilAutoPause", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SecondsUntilAutoPause
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TimeoutAction
        {
            get;
            set;
        }
    }
}
