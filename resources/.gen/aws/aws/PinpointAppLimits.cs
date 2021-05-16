using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.PinpointAppLimits")]
    public class PinpointAppLimits : aws.IPinpointAppLimits
    {
        [JsiiOptional]
        [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Daily
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumDuration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MessagesPerSecond
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Total
        {
            get;
            set;
        }
    }
}
