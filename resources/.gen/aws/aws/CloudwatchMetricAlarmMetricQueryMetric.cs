using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudwatchMetricAlarmMetricQueryMetric")]
    public class CloudwatchMetricAlarmMetricQueryMetric : aws.ICloudwatchMetricAlarmMetricQueryMetric
    {
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricName
        {
            get;
            set;
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Period
        {
            get;
            set;
        }

        [JsiiProperty(name: "stat", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Stat
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Dimensions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Namespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Unit
        {
            get;
            set;
        }
    }
}
