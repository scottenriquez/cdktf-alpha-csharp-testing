using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElbHealthCheck")]
    public class ElbHealthCheck : aws.IElbHealthCheck
    {
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double HealthyThreshold
        {
            get;
            set;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Interval
        {
            get;
            set;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Target
        {
            get;
            set;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Timeout
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
    }
}
