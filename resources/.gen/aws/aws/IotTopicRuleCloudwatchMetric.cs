using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleCloudwatchMetric")]
    public class IotTopicRuleCloudwatchMetric : aws.IIotTopicRuleCloudwatchMetric
    {
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricName
        {
            get;
            set;
        }

        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricNamespace
        {
            get;
            set;
        }

        [JsiiProperty(name: "metricUnit", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricUnit
        {
            get;
            set;
        }

        [JsiiProperty(name: "metricValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MetricValue
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MetricTimestamp
        {
            get;
            set;
        }
    }
}
