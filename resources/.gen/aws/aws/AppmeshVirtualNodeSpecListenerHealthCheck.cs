using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecListenerHealthCheck")]
    public class AppmeshVirtualNodeSpecListenerHealthCheck : aws.IAppmeshVirtualNodeSpecListenerHealthCheck
    {
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double HealthyThreshold
        {
            get;
            set;
        }

        [JsiiProperty(name: "intervalMillis", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double IntervalMillis
        {
            get;
            set;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Protocol
        {
            get;
            set;
        }

        [JsiiProperty(name: "timeoutMillis", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TimeoutMillis
        {
            get;
            set;
        }

        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double UnhealthyThreshold
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
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
