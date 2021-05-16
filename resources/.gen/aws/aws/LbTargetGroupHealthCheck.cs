using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LbTargetGroupHealthCheck")]
    public class LbTargetGroupHealthCheck : aws.ILbTargetGroupHealthCheck
    {
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Interval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "matcher", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Matcher
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Path
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Port
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Protocol
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Timeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
